using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    public partial class frmModificarPuerto : Form
    {
        private string puer_Description = "";
        private string puer_Codigo = "";
        private string puer_esta_habilitado = "";
        private string puer_ciudad = "";
        public frmModificarPuerto()
        {
            InitializeComponent();
        }
        private void frmModificarPuerto_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Puerto abm = new Puerto();
            this.dataGridPuertos.DataSource = abm.mostrarPuertos();
            if (dataGridPuertos.Rows.Count == 0)
            {
                MessageBox.Show("Actualmente no hay roles para modificar", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void dataGridPuertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridPuertos.Rows[e.RowIndex];

                puer_Codigo = Fila.Cells["Codigo"].Value.ToString();
                puer_Description = Fila.Cells["Descripcion"].Value.ToString();
                puer_esta_habilitado = Fila.Cells["Habilitado"].Value.ToString();
                puer_ciudad = Fila.Cells["Ciudad"].Value.ToString();
                frmModificarPuertoSeleccionado frmModificarPuertoSeleccionado = new frmModificarPuertoSeleccionado(puer_Codigo,puer_ciudad, puer_Description, puer_esta_habilitado);
                frmModificarPuertoSeleccionado.Show();
                this.Hide();
                frmModificarPuertoSeleccionado.FormClosing += FrmModificarPuertoSeleccionado_FormClosing;

            }
        }

        private void FrmModificarPuertoSeleccionado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
