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
    public partial class frmAbmRol : Form
    {
        public frmAbmRol()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaRol frmAltaRol = new frmAltaRol();
            frmAltaRol.Visible = true;
        }

        private void frmAbmRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnModificacionBaja_Click(object sender, EventArgs e)
        {
            frmListadoRoles frmListadoRoles = new frmListadoRoles();
            frmListadoRoles.Visible = true;
        }


    }
}
