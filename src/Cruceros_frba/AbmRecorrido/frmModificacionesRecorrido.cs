using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class frmModificacionesRecorrido : Form
    {
        DataTable dt;
        string filtroOrigen = "";
        string filtroDestino = "";
        string filtroPrecio = "";
        string filtro = "";
        string filtroID = "";
        public frmModificacionesRecorrido()
        {
            InitializeComponent();
            Load += new EventHandler(frmModificacionesRecorrido_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            txtBoxFiltroDestino.TextChanged += new EventHandler(txtBoxFiltroDestino_TextChanged);
            txtBoxFiltroOrigen.TextChanged += new EventHandler(txtBoxFiltroOrigen_TextChanged);
        }
        private void frmModificacionesRecorrido_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Recorrido abm = new Recorrido();
            dt = abm.mostrarRecorrido();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridView1.Rows[e.RowIndex];
                object[] args = { Fila.Cells["ID"].Value, Fila.Cells["Puerto_origen"].Value, Fila.Cells["Puerto_destino"].Value, Fila.Cells["Precio"].Value, Fila.Cells["Habilitado"].Value };
                frmABMRecorridoModificarSeleccionado frmABMRecorridoModificarSeleccionado = new frmABMRecorridoModificarSeleccionado(args);
                frmABMRecorridoModificarSeleccionado.Show();
                this.Enabled = false;
                frmABMRecorridoModificarSeleccionado.FormClosing += FrmABMRecorridoModificarSeleccionado_FormClosing;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void FrmABMRecorridoModificarSeleccionado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void txtBoxFiltroOrigen_TextChanged(object sender, EventArgs e)
        {
            filtroDestino = txtBoxFiltroDestino.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroOrigen, filtroDestino, filtroPrecio, filtroID);
        }

        private void txtBoxFiltroDestino_TextChanged(object sender, EventArgs e)
        {
            filtroDestino = txtBoxFiltroDestino.Text;
            dt.DefaultView.RowFilter = actualizarFiltro(filtroOrigen, filtroDestino, filtroPrecio, filtroID);
        }

        private void txtBoxFiltroPrecio_TextChanged(object sender, EventArgs e)
        {
            Decimal aux;
            filtroPrecio = "";
            try
            {
                aux = Convert.ToDecimal(txtBoxFiltroPrecio.Text);
                filtroPrecio= txtBoxFiltroPrecio.Text;
            }
            catch (Exception)
            {
                if(txtBoxFiltroPrecio.Text != "")
                MessageBox.Show("Solo puede ingresar numeros.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filtroPrecio = "";
                txtBoxFiltroPrecio.Clear();
            }
            dt.DefaultView.RowFilter = actualizarFiltro(filtroOrigen, filtroDestino, filtroPrecio, filtroID);
        }

        private void txtBoxFiltroID_TextChanged(object sender, EventArgs e)
        {
            int aux;
            filtroID = "";
            try
            {
                aux = Convert.ToInt32(txtBoxFiltroID.Text);
                filtroID = txtBoxFiltroID.Text;
            }
            catch (Exception)
            {
                if(txtBoxFiltroID.Text !="")
                MessageBox.Show("Solo puede ingresar numeros.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filtroPrecio = "";
                txtBoxFiltroPrecio.Clear();
            }
            dt.DefaultView.RowFilter = actualizarFiltro(filtroOrigen, filtroDestino, filtroPrecio, filtroID);
        }
        private string actualizarFiltro(string a,string b,string c,string d)
        {
            filtro = string.Format("Puerto_origen Like '%{0}%'", a);
            filtro += string.Format("And Puerto_destino Like '%{0}%'", b);
            filtro += string.Format("And Convert(Precio,'System.String') Like '%{0}%'", c);
            filtro += string.Format("And Convert(ID,'System.String') Like '%{0}%'", d);
            return filtro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
