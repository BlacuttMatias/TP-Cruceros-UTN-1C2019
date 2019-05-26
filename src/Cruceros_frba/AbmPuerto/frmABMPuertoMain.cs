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
    public partial class frmABMPuertoMain : Form
    {
        public frmABMPuertoMain()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaPuerto frmAltaPuerto = new frmAltaPuerto();
            frmAltaPuerto.Show();
            this.Hide();
            frmAltaPuerto.FormClosing += FrmAltaPuerto_FormClosing;
        }

        private void FrmAltaPuerto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmModificarPuerto frmModificarPuerto = new frmModificarPuerto();
            frmModificarPuerto.Show();
            this.Hide();
            frmModificarPuerto.FormClosing += FrmModificarPuerto_FormClosing;
        }

        private void FrmModificarPuerto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
