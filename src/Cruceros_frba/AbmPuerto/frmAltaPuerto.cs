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
    public partial class frmAltaPuerto : Form
    {
        public frmAltaPuerto()
        {
            InitializeComponent();
            this.lblError.Hide();
            this.label1.Hide();
            this.lblCiudadReq.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtCiudad.Text!="")
            {
                this.lblError.Hide();
                this.label1.Hide();
                this.lblCiudadReq.Hide();
                Puerto abm = new Puerto();
                if (abm.crearPuerto(this.txtCiudad.Text, this.txtDescripcion.Text) == 0)
                {
                    MessageBox.Show("El puerto que ingresó ya existe. Ingrese otro puerto.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El puerto fue creado correctamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.lblError.Show();
                this.label1.Show();
                this.lblCiudadReq.Show();
            }
            this.txtCiudad.Clear();
            this.txtDescripcion.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCiudad.Clear();
            this.txtDescripcion.Clear();
            this.lblError.Hide();
            this.label1.Hide();
            this.lblCiudadReq.Hide();
        }
    }
}
