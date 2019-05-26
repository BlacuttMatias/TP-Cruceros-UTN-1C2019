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
    public partial class frmABMRecorridoMain : Form
    {
        public frmABMRecorridoMain()
        {
            InitializeComponent();
        }

        private void btnAltaRecorrido_Click(object sender, EventArgs e)
        {
            frmAltaRecorrido frmAltaRecorrido = new frmAltaRecorrido();
            frmAltaRecorrido.Show();
            this.Hide();
            frmAltaRecorrido.FormClosing += FrmAltaRecorrido_FormClosing;
        }

        private void FrmAltaRecorrido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmModificacionesRecorrido frmModificacionesRecorrido = new frmModificacionesRecorrido();
            frmModificacionesRecorrido.Show();
            this.Hide();
            frmModificacionesRecorrido.FormClosing += FrmModificacionesRecorrido_FormClosing;
        }

        private void FrmModificacionesRecorrido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
