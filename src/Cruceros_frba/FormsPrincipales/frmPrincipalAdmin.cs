using FrbaCrucero.AbmCrucero;
using FrbaCrucero.AbmPuerto;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.AbmRol;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.PagoReserva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.FormsPrincipales
{
    public partial class frmPrincipalAdmin : Form
    {
        private int childFormNumber = 0;

        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CenterToScreen();
        }

        private void itmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itmRoles_Click(object sender, EventArgs e)
        {
            frmABMRolMain frm = new frmABMRolMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmPuertos_Click(object sender, EventArgs e)
        {
            frmABMPuertoMain frm = new frmABMPuertoMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmRecorridos_Click(object sender, EventArgs e)
        {
            frmABMRecorridoMain frm = new frmABMRecorridoMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmListadosEstadísticos_Click(object sender, EventArgs e)
        {
            frmListadosEstadisticos frm = new frmListadosEstadisticos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmCompra_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente(true);
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmReservar_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente(false);
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmPagarReserva_Click(object sender, EventArgs e)
        {
            frmPagoReserva frm = new frmPagoReserva();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmGenerarViaje_Click(object sender, EventArgs e)
        {
            frmGenerarViaje frm = new frmGenerarViaje();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itmCruceros_Click(object sender, EventArgs e)
        {
            frmABMCruceroMain frm = new frmABMCruceroMain();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
