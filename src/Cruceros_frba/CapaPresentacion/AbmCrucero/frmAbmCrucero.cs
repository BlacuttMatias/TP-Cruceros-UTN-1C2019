using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAbmCrucero : Form
    {
        public frmAbmCrucero()
        {
            InitializeComponent();
        }

        private void frmAbmCrucero_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaCrucero frmAltaCrucero = new frmAltaCrucero();
            frmAltaCrucero.Visible = true;
        }

        private void btnModificacionBaja_Click(object sender, EventArgs e)
        {
            frmListadoCruceros frmListadoCruceros = new frmListadoCruceros();
            frmListadoCruceros.Visible = true;
        }

    }
}
