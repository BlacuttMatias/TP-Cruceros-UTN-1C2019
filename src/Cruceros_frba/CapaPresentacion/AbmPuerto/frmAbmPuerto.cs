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
    public partial class frmAbmPuerto : Form
    {
        public frmAbmPuerto()
        {
            InitializeComponent();
        }

        private void frmAbmPuerto_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaPuerto frmAltaPuerto = new frmAltaPuerto();
            frmAltaPuerto.Visible = true;
        }

        private void btnModificacionBaja_Click(object sender, EventArgs e)
        {
            frmListadoPuertos frmListadoPuertos = new frmListadoPuertos();
            frmListadoPuertos.Visible = true;
        }
    }
}
