using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmPuerto;

namespace FrbaCrucero.AbmRecorrido
{

    public partial class frmNuevoTramo : Form
    {
        public DataTable dt = new DataTable();
        TramoElegido unTramo;
        public frmNuevoTramo(ref TramoElegido _unTramo)
        {
            InitializeComponent();
            unTramo = _unTramo;
            cBoxOrigen.SelectedIndexChanged += new EventHandler(cBoxOrigen_SelectedIndexChanged);
            cBoxDestino.SelectedIndexChanged += new EventHandler(cBoxDestino_SelectedIndexChanged);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            if (unTramo.origen=="")
            {

            }
            else
            {
                cBoxOrigen.Enabled = false;
                cBoxOrigen.Text = unTramo.origen;
            }
            #region Eventos
            Load += new EventHandler(frmNuevoTramo_Load);

            #endregion
        }

        private void frmNuevoTramo_Load(object sender, EventArgs e)
        {
            AbmPuerto.Puerto puerto =new AbmPuerto.Puerto();
            dt = puerto.mostrarPuertosHabilitados();
            foreach (DataRow row in dt.Rows)
            {
                cBoxOrigen.Items.Add(row["Ciudad"]);
                cBoxDestino.Items.Add(row["Ciudad"]);
            }
        }

        private void cBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cBoxOrigen.Text != "" && cBoxDestino.Text != "" && txtBoxPrecio.Text != "")
            {
                unTramo.origen = cBoxOrigen.Text;
                unTramo.destino = cBoxDestino.Text;
                unTramo.precio = Convert.ToDecimal(txtBoxPrecio.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Faltaban completar Campos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            Decimal aux;
            try
            {
                aux = Convert.ToDecimal(txtBoxPrecio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Solo puede ingresar numeros.","FrbaCruceros",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtBoxPrecio.Clear();
            }
        }
    }
}
