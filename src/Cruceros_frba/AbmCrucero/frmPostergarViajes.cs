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
    public partial class frmPostergarViajes : Form
    {
        Crucero abm;
        string crucero_codigo = "";
        DateTime fechaBaja;
        DateTime fechaAlta;
        public frmPostergarViajes(string codigo, Crucero ABMcrucero, DateTime alta, DateTime baja)
        {
            InitializeComponent();
            abm = ABMcrucero;
            crucero_codigo = codigo;
            fechaBaja = baja;
            fechaAlta = alta;
            this.Text = "Postergar Viajes de:" + codigo;
            lblFecha.Text = "A partir de:" + alta.ToString();
            btnAceptar.Enabled = false;
        }

        private void frmPostergarViajes_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int diasBaja = ((TimeSpan)(fechaAlta - fechaBaja)).Days;
            int cantidadDeDiasMovidos = Convert.ToInt32(textBox1.Text) + diasBaja;
            abm.corrimientoDiasViaje(crucero_codigo, cantidadDeDiasMovidos, fechaBaja);
            MessageBox.Show("Los viajes se postergaron " + cantidadDeDiasMovidos.ToString() + " dias"
                , "Corrimiento de viajes exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            abm.bajaCrucero(crucero_codigo, fechaBaja, fechaAlta, "Temporal");
            MessageBox.Show(string.Format("El Crucero {0} fue dado de baja de forma Temporal", crucero_codigo), "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[0-9]+").IsMatch(textBox1.Text))
            {
                btnAceptar.Enabled = true;
            }
        }
    }
}
