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
        private int codigoCliente;

        public frmBusquedaPasaje(int unCodigoCliente, bool esUnaCompra)
        {
            InitializeComponent();
            dtpFechaPartida.Format = DateTimePickerFormat.Custom;
            dtpFechaPartida.CustomFormat = "MM/dd/yyyy";
            dtpFechaPartida.Value = Coneccion.getFechaSistema();

            
            cmbPuertoOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuertoDestino.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridViajesDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (esUnaCompra)
            {
                btnComprar.Visible = true;
                btnReservar.Visible = false;
            }
            else {
                btnComprar.Visible = false;
                btnReservar.Visible = true;
            }

            this.codigoCliente = unCodigoCliente;
            #region LLENAR COMBO BOX
            DataTable dt = new DataTable();
            AbmPuerto.Puerto puerto = new AbmPuerto.Puerto();
            dt = puerto.mostrarPuertosHabilitados();
            foreach (DataRow row in dt.Rows)
            {
                cmbPuertoOrigen.Items.Add(row["Ciudad"]);
                cmbPuertoDestino.Items.Add(row["Ciudad"]);
            }
            #endregion

            #region LLENAR GRID

            
            //this.dataGridViajesDisponibles.DataSource = gestion.mostrarTodosLosViajesDisponibles();

            #endregion

            cmbPuertoOrigen.SelectedIndex = 0;
            cmbPuertoDestino.SelectedIndex = 0;
        }

        private void frmBusquedaPasaje_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPuertoOrigen.SelectedItem == null || cmbPuertoDestino.SelectedItem == null)
            {
                MessageBox.Show("No puede faltar ningun campo de Filtrado.", "Filtrado de Pasajes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.dataGridViajesDisponibles.DataSource = 
                    gestion.mostrarViajesDisponiblesParaUnCliente(dtpFechaPartida.Value
                    , cmbPuertoOrigen.Text, cmbPuertoDestino.Text, this.codigoCliente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViajesDisponibles.SelectedRows.Count > 0)
            {

                int codigoViaje = (int)(dataGridViajesDisponibles.SelectedRows[0].Cells[0].Value);

                frmCabinasDisponibles frm1 = new frmCabinasDisponibles(codigoViaje, codigoCliente);
                frm1.Show();
                frm1.FormClosed += frm1_FormClosed;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Seleccione un viaje a Comprar", "Compra Pasaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViajesDisponibles.SelectedRows.Count > 0) {

                int codigoViaje = (int)(dataGridViajesDisponibles.SelectedRows[0].Cells[0].Value);

                frmCabinasParaReserva frm1 = new frmCabinasParaReserva(codigoViaje, codigoCliente);
                frm1.Show();
                frm1.FormClosed += frm1_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un viaje a Reservar", "Reserva Pasaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
