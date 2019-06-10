using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class frmABMCruceroMain : Form
    {
        public frmABMCruceroMain()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaCrucero frmAltaCrucero = new frmAltaCrucero();
            frmAltaCrucero.Show();
            frmAltaCrucero.FormClosing += FrmAltaCrucero_FormClosing;
            this.Hide();
        }

        private void FrmAltaCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmModificacionCrucero frmModificacionCrucero = new frmModificacionCrucero();
            frmModificacionCrucero.Show();
            frmModificacionCrucero.FormClosing += FrmModificacionCrucero_FormClosing;
            this.Hide();
        }

        private void FrmModificacionCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            frmBajaCrucero frmBajaCrucero = new frmBajaCrucero();
            frmBajaCrucero.Show();
            frmBajaCrucero.FormClosing += FrmBajaCrucero_FormClosing;
            this.Hide();
        }

        private void FrmBajaCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
