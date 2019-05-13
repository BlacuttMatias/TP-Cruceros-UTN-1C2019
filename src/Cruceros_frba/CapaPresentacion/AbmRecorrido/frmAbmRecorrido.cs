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
    public partial class frmAbmRecorrido : Form
    {
        public frmAbmRecorrido()
        {
            InitializeComponent();
        }

        private void frmAbmRecorrido_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaRecorrido frmAltaRecorrido = new frmAltaRecorrido();
            frmAltaRecorrido.Visible = true;
        }

        private void btnModificacionBaja_Click(object sender, EventArgs e)
        {
            frmListadoRecorridos frmListadoRecorridos = new frmListadoRecorridos();
            frmListadoRecorridos.Visible = true;
        }
    }
}
