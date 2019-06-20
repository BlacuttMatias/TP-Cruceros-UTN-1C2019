using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class frmModificarCruceroSeleccionado : Form
    {
        string codigo = "";
        DataTable dt = new DataTable();
        Crucero abm = new Crucero();
        public frmModificarCruceroSeleccionado(params object[] args)
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
            codigo = args[0] as string;
            lblCodigo.Text += string.Format(" {0}", codigo);
            cBoxMarca.Text = args[1] as string;
            cBoxModelo.Text = args[2] as string;
            Load += new EventHandler(frmModificarCruceroSeleccionado_Load);
        }
        private void frmModificarCruceroSeleccionado_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataTable dtMarcas = abm.mostrarMarcas();
            llenarCB(cBoxMarca, dtMarcas, "Marca");

            DataTable dtModelos = abm.mostrarModelos();
            llenarCB(cBoxModelo, dtModelos, "Modelo");
        }

        private void imprimir(List<int> c)
        {
            Console.Write("\n");
            foreach (int i in c)
                Console.Write(i + ",");
        }
        private void llenarCB(ComboBox cb, DataTable source, string columna)
        {
            cb.Items.Clear();
            foreach (DataRow marca in source.Rows)
                cb.Items.Add(marca[columna]);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cBoxMarca.Text = "";
            cBoxModelo.Text = "";
        }

        private void cBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void cBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            abm.modificarCrucero(codigo, cBoxMarca.Text, cBoxModelo.Text);
            this.Close();
        }
    }
}