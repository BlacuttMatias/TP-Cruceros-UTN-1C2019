using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class frmModificacionCrucero : Form
    {
        DataTable dt;
        string filtroMarca = "";
        string filtroModelo = "";
        string filtroCantidadCabinas = "";
        string filtro = "";
        string filtroCodigoCrucero = "";
        string filtroCantidadPisos = "";
        public frmModificacionCrucero()
        {
            InitializeComponent();
            Load += new EventHandler(frmModificacionCrucero_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            txtBoxFiltroModelo.TextChanged += new EventHandler(txtBoxFiltroModelo_TextChanged);
            txtBoxFiltroMarca.TextChanged += new EventHandler(txtBoxFiltroMarca_TextChanged);
        }

        private void frmModificacionCrucero_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Crucero abm = new Crucero();
            dt = abm.mostrarCruceros();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridView1.Rows[e.RowIndex];
                object[] args = { Fila.Cells["Codigo"].Value, Fila.Cells["Marca"].Value, Fila.Cells["Modelo"].Value, Fila.Cells["Cantidad de Cabinas"].Value, Fila.Cells["Fecha de Alta"].Value };
                frmModificarCruceroSeleccionado frmModificarCruceroSeleccionado = new frmModificarCruceroSeleccionado(args);
                frmModificarCruceroSeleccionado.Show();
                this.Enabled = false;
                frmModificarCruceroSeleccionado.FormClosing += frmModificarCruceroSeleccionado_FormClosing;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void frmModificarCruceroSeleccionado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void txtBoxFiltroMarca_TextChanged(object sender, EventArgs e)
        {
            filtroMarca = txtBoxFiltroMarca.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroCodigoCrucero, filtroMarca, filtroModelo);
        }

        private void txtBoxFiltroModelo_TextChanged(object sender, EventArgs e)
        {
            filtroModelo = txtBoxFiltroModelo.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroCodigoCrucero, filtroMarca, filtroModelo);
        }

        private void txtBoxFiltroID_TextChanged(object sender, EventArgs e)
        {

            filtroCodigoCrucero = txtBoxFiltroID.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroCodigoCrucero, filtroMarca, filtroModelo);
        }
        private string actualizarFiltro(string codigo, string marca, string modelo)
        {
            filtro = string.Format("Codigo Like '%{0}%'", codigo);
            filtro += string.Format("And Marca Like '%{0}%'", marca);
            filtro += string.Format("And Modelo Like '%{0}%'", modelo);
            return filtro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxFiltroPisos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AbmRecorrido.Debugger debugger = new AbmRecorrido.Debugger();
            debugger.Show();
            debugger.log($"Fecha de Alta = #{dateTimePicker1.Value}#");
        }
    }
}
