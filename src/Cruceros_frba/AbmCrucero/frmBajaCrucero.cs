using CapaDatos;
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
        DataTable dtCruceros;
        DataTable dtBajas;
        string filtro = "";
        string filtroCodigoCrucero = "";
        Crucero abm = new Crucero();
        string filtroMarca = "";
        string filtroModelo = "";
        string filtroTipoBaja = "";
        public frmBajaCrucero()
        {
            InitializeComponent();
            Load += new EventHandler(frmModificacionCrucero_Load);
            dgvCruceros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCruceros.MultiSelect = false;
            dgvCruceros.CellClick += new DataGridViewCellEventHandler(dtvCruceros_CellClick);
            dgvBajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBajas.MultiSelect = false;
            //txtBoxFiltroModelo.TextChanged += new EventHandler(txtBoxFiltroModelo_TextChanged);
            //txtBoxFiltroMarca.TextChanged += new EventHandler(txtBoxFiltroMarca_TextChanged);
        }

        private void frmModificacionCrucero_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dtCruceros = abm.mostrarCruceros();
            dgvCruceros.DataSource = dtCruceros;
            dtBajas = abm.mostrarBajas();
            dgvBajas.DataSource = dtBajas;
        }
        private void dtvCruceros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dgvCruceros.Rows[e.RowIndex];
                DataRow row = dtCruceros.Rows[e.RowIndex];
                //var fechaCreacion = row.Field<DateTime?>("Fecha Creacion").GetValueOrDefault(Coneccion.getFechaSistema());
                //var fechaBaja = row.Field<DateTime?>("Fecha de Baja").GetValueOrDefault(Coneccion.getFechaSistema());
                var fechaAlta = row.Field<DateTime?>("Fecha de Alta").GetValueOrDefault(Coneccion.getFechaSistema());
                frmBajarSeleccionado frmBajarSeleccionado = new frmBajarSeleccionado(Fila.Cells["Codigo"].Value as string, /*fechaCreacion, Fila.Cells["Tipo Baja"].Value as string, fechaBaja, */fechaAlta);
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
            dtBajas = abm.mostrarBajas();
            dgvBajas.DataSource = dtCruceros;
        }

        private void txtBoxFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
            filtroCodigoCrucero = txtBoxFiltroCodigo.Text;
            dtCruceros.DefaultView.RowFilter = actualizarFiltro();
            dtBajas.DefaultView.RowFilter = actualizarFiltroBajas();
        }
        private string actualizarFiltroBajas()
        {
            filtro = string.Format("Codigo Like '%{0}%'", filtroCodigoCrucero);
            return filtro;
        }
        private string actualizarFiltro()
        {
            filtro = string.Format("Codigo Like '%{0}%'", filtroCodigoCrucero);
            filtro += string.Format("AND Marca Like '%{0}%'", filtroMarca);
            filtro += string.Format("AND Modelo Like '%{0}%'", filtroModelo);
            return filtro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbMarca_TextChanged(object sender, EventArgs e)
        {
            filtroMarca = tbMarca.Text;
            dtCruceros.DefaultView.RowFilter = actualizarFiltro();
        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
            filtroModelo = tbModelo.Text;
            dtCruceros.DefaultView.RowFilter = actualizarFiltro();
        }
    }
}
