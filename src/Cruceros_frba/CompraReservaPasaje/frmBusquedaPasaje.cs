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
    public partial class frmBusquedaPasaje : Form
    {
        GestionCompra gestion = new GestionCompra();
        public frmBusquedaPasaje()
        {
            InitializeComponent();
            fechaPartida.Format = DateTimePickerFormat.Custom;
            fechaPartida.CustomFormat = "MM/dd/yyyy";
            #region LLENAR COMBO BOX
            DataTable dt = new DataTable();
            AbmPuerto.Puerto puerto = new AbmPuerto.Puerto();
            dt = puerto.mostrarPuertosHabilitados();
            foreach (DataRow row in dt.Rows)
            {
                puertoOrigen.Items.Add(row["Ciudad"]);
                puertoDestino.Items.Add(row["Ciudad"]);
            }
            #endregion

            #region LLENAR GRID

            
            this.dataGridViajesDisponibles.DataSource = gestion.llenarGrid();

            #endregion
        }

        private void frmBusquedaPasaje_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoOrigen.SelectedItem == null || puertoDestino.SelectedItem == null)
            {
                MessageBox.Show("No puede faltar ningun campo de Filtrado.", "Filtrado de Pasajes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.dataGridViajesDisponibles.DataSource = gestion.filtrarViaje(fechaPartida.Value, puertoOrigen.Text, puertoDestino.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViajesDisponibles.SelectedRows.Count > 0)
            {

                int codigoViaje = (int)(dataGridViajesDisponibles.SelectedRows[0].Cells[0].Value);
                frmCliente frm = new frmCliente();
                frm.ShowDialog();
                //int codigoCliente = 1;
                //frmCabinasDisponibles frm1 = new frmCabinasDisponibles(codigoViaje, codigoCliente);
                //frm1.ShowDialog();
                if (frm.valorRetornado != -1)
                {
                    int codigoCliente = frm.valorRetornado;

                    frmCabinasDisponibles frm1 = new frmCabinasDisponibles(codigoViaje, codigoCliente);
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usted no se identificó como cliente, vuelva a intentarlo", "Error de Identificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                
                

            }
            else
            {
                MessageBox.Show("Seleccione un viaje a Comprar", "Compra Pasaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int codigoViaje = (int)(dataGridViajesDisponibles.SelectedRows[0].Cells[0].Value);
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
            if (frm.valorRetornado != -1)
            {
                int codigoCliente = frm.valorRetornado;

                frmCabinasParaReserva frm1 = new frmCabinasParaReserva(codigoViaje, codigoCliente);
                frm1.Show();
                this.Hide();
        
            }
            else
            {
                MessageBox.Show("Usted no se identificó como cliente, vuelva a intentarlo", "Error de Identificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
