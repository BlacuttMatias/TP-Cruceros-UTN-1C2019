using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class frmCabinasParaReserva : Form
    {
        public int codigoCliente;
        public int codigoViaje;
        public frmCabinasParaReserva(int viaje, int cliente)
        {
            InitializeComponent();
            codigoCliente = cliente;
            codigoViaje = viaje;
            #region Llenar Grid
            GestionCompra gestion = new GestionCompra();
            cabinasDisponibles.DataSource = gestion.llenarGridCabinas(codigoViaje);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantCabinas = cabinasDisponibles.SelectedRows.Count;
            if (cantCabinas != 1)
            {
                MessageBox.Show("Hubo un error con la seleccion de la cabina deseada, intente otra vez.", "Error en seleccion de cabina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region Creacion de Pasaje
                Pasaje nuevoPasaje = new Pasaje();
                int codigoCabina = (int)(cabinasDisponibles.SelectedRows[0].Cells[0].Value);
                // int precioViaje = (int)(row.Cells[ACA VA EL INDICE DEL VALOR EN EL DATAGRID].Value);
                nuevoPasaje.setCodigoCabina(codigoCabina);
                nuevoPasaje.setCodigoCliente(codigoCliente);
                nuevoPasaje.setCodigoViaje(codigoViaje);
                //nuevoPasaje.setPrecio(precioViaje);
                #endregion

                #region Generar Reserva
                int codigoPasaje = Coneccion.ejecutarSPR("generarPasaje","@codigoPasaje","@codigoCLiente", codigoCliente, "@codigoViaje", codigoViaje, "@codigoCabina", codigoCabina);
                DateTime fechaSistema = Coneccion.getFechaSistema();
                int codigoReserva = Coneccion.ejecutarSPR("generarReservaDeUnPasaje", "@codigoReserva", "@codigoPasaje", codigoPasaje, "@fechaSistema", fechaSistema);
                DialogResult respuesta = MessageBox.Show("Su codigo de reserva es: " + codigoReserva.ToString() + "\nEste código se le requerirá para" +
                    "poder pagar su reserva.\nRecuerde que su reserva vence si el pago no es efectuado en los proximos 3 días.\n" +
                    "Desea realizar otra reserva?", "Reserva Generada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (respuesta == DialogResult.No)
                {
                    this.Hide();
                }
                else
                {
                    frmBusquedaPasaje frm = new frmBusquedaPasaje();
                    frm.Show();
                    this.Hide();
                }
                #endregion
            }
        }

        
    }
}
