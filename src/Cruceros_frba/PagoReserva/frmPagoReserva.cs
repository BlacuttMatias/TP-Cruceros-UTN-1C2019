using FrbaCrucero.CompraReservaPasaje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.PagoReserva
{
    public partial class frmPagoReserva : Form
    {
        public frmPagoReserva()
        {
            InitializeComponent();
        }

        private void frmPagoReserva_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            //controlo que solo puedan escribir numeros
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
                toolTipCodigoReserva.Show("Solo puede escribir números (0-9) en este campo", txtReserva, 3000);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtReserva.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error: Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else{
                DatosPagoReserva datosPagoReserva = new DatosPagoReserva();
                int codigoReserva = Convert.ToInt32(txtReserva.Text);

                //obtengo el pasaje de esa reserva
                int codigoPasaje = datosPagoReserva.obtenerPasajeDeUnaReserva(codigoReserva);
                if (codigoPasaje == -1) {
                    MessageBox.Show("No existe una reserva con ese número de código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (codigoPasaje == -2) {
                    MessageBox.Show("La reserva ya fue cancelada por haber expirado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (codigoPasaje == -3)
                {
                    MessageBox.Show("El pasaje de esta reserva fue cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (codigoPasaje == -4) {
                    MessageBox.Show("El pasaje de esta reserva ya fue pagado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

                    //creo el pasaje de la reserva con su codigo y el codigo del cliente
                    Pasaje pasaje = new Pasaje();
                    pasaje.setCodigoPasaje(codigoPasaje);
                    pasaje.setCodigoCliente(datosMediosDePago.obtenerCodigoClienteDeUnPasajePersistido(codigoPasaje));

                    //creo la compra y le agrego el pasaje de la reserva
                    Compra compra = new Compra(true);
                    compra.agregarPasaje(pasaje);

                    //paso a otro form para que ingrese el medio de pago
                    frmMedioDePago frm = new frmMedioDePago(compra);

                    frm.FormClosed += frm_FormClosed;
                    frm.Show();
                    this.Hide();
                }
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
