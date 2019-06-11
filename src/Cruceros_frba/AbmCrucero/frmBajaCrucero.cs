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
    public partial class frmBajaCrucero : Form
    {
        DataTable dt;
        string filtro = "";
        string filtroCodigoCrucero = "";
        public frmBajaCrucero()
        {
            InitializeComponent();
            Load += new EventHandler(frmModificacionCrucero_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            //txtBoxFiltroModelo.TextChanged += new EventHandler(txtBoxFiltroModelo_TextChanged);
            //txtBoxFiltroMarca.TextChanged += new EventHandler(txtBoxFiltroMarca_TextChanged);
        }

        private void frmModificacionCrucero_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Crucero abm = new Crucero();
            dt = abm.mostrarBajas();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridView1.Rows[e.RowIndex];
                DataRow row = dt.Rows[e.RowIndex];
                var fechaCreacion = row.Field<DateTime?>("Fecha Creacion").GetValueOrDefault(DateTime.Now);
                var fechaBaja = row.Field<DateTime?>("Fecha de Baja").GetValueOrDefault(DateTime.Now);
                var fechaAlta = row.Field<DateTime?>("Fecha de Alta").GetValueOrDefault(DateTime.Now);
                frmBajarSeleccionado frmBajarSeleccionado = new frmBajarSeleccionado(Fila.Cells["Codigo"].Value as string, fechaCreacion, Fila.Cells["Tipo Baja"].Value as string, fechaBaja, fechaAlta);
                frmBajarSeleccionado.Show();
                this.Enabled = false;
                frmBajarSeleccionado.FormClosing += frmBajarSeleccionado_FormClosing;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void frmBajarSeleccionado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void txtBoxFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
            filtroCodigoCrucero = txtBoxFiltroCodigo.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroCodigoCrucero);
        }
        private string actualizarFiltro(string codigo)
        {
            filtro = string.Format("Codigo Like '%{0}%'", codigo);
            return filtro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
