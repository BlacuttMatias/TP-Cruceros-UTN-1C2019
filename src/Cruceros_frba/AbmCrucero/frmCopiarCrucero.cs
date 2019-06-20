using CapaDatos;
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
    public partial class frmCopiarCrucero : Form
    {
        Crucero abm;
        string codigoViejo = "";
        string codigoNuevo = "";
        DateTime fechaBaja;
        public frmCopiarCrucero(string codigo, Crucero abmCrucero, DateTime baja)
        {
            InitializeComponent();
            codigoViejo = codigo;
            lblViejo.Text = "Crucero a Reemplazar:" + codigo;
            btnAceptar.Enabled = false;
            abm = abmCrucero;
            fechaBaja = baja;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            abm.crearCruceroIgualAlAnterior(codigoViejo, codigoNuevo, Coneccion.getFechaSistema());
            abm.actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente(codigoViejo, codigoNuevo, fechaBaja);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxCrucero_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Z]{6}-[0-9]{5}$").IsMatch(txtBoxCrucero.Text))
            {
                txtBoxCrucero.ForeColor = Color.Black;
                txtBoxCrucero.Enabled = true;
                codigoNuevo = txtBoxCrucero.Text;
                btnAceptar.Enabled = true;
            }
            else
            {
                txtBoxCrucero.ForeColor = Color.Red;
            }
        }
    }
}
