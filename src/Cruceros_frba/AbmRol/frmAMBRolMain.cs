using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero.AbmRol
{
    //public partial class ABMRol : Form
    //{

    //    public ABMRol()
    //    {
    //        InitializeComponent();
    //    }

    //}
    public partial class frmABMRolMain : Form
    {
        public frmABMRolMain()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaRol frmAlta = new frmAltaRol();
            frmAlta.Show();
            this.Hide();
            frmAlta.FormClosing += frmAlta_Closing;
        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmModificarRol frmModificacion = new frmModificarRol();
            frmModificacion.Show();
            this.Hide();
            frmModificacion.FormClosing += frmModificacion_Closing;
        }

        private void frmABMRolInicio_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void frmAlta_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void frmModificacion_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
