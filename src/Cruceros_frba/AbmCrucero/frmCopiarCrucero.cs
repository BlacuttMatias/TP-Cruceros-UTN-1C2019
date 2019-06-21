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
            int resultado = abm.crearCruceroIgualAlAnterior(codigoViejo, codigoNuevo, Coneccion.getFechaSistema());
            if (resultado == 0)
            {
                MessageBox.Show("Ya existe un crucero con ese codigo. Por favor, ingrese otro codigo", "Error: codigo de crucero existente"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                abm.actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente(codigoViejo, codigoNuevo, fechaBaja);
                MessageBox.Show("Se reemplazo el crucero:" + codigoViejo + " por el crucero:" + codigoNuevo, "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                abm.bajaCrucero(codigoViejo, fechaBaja, Coneccion.getFechaSistema(), "Permanente");
                MessageBox.Show(string.Format("El Crucero {0} fue dado de baja de forma Permanente", codigoViejo), "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
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
