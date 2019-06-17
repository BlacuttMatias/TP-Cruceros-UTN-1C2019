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
    public partial class frmModificarPuertoSeleccionado : Form
    {
        private int puer_codigo;
        private string puer_descripcion = "";
        private string puer_ciudad = "";
        private string puer_esta_habilitado = "";
        private bool modCiudad = false;
        private bool modDescripcion = false;
        public frmModificarPuertoSeleccionado(string puer_Codigo,string puer_Ciudad, string puer_Description, string puer_Esta_Habilitado)
        {
            InitializeComponent();
            lblErrorCiudad.Hide();
            label1.Hide();
            puer_codigo = Convert.ToInt32(puer_Codigo);
            lblTitulo.Text = "Codigo:" + puer_codigo;
            puer_ciudad = puer_Ciudad;
            txtBoxCiudad.Text = puer_ciudad;
            if (puer_Description != "-")
            {
               this.puer_descripcion = puer_Description;
            }
            txtBoxDescripcion.Text = puer_descripcion;
            puer_esta_habilitado = puer_Esta_Habilitado;
            if (puer_esta_habilitado == "SI")
                ckBoxHabilitado.Checked = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtBoxCiudad.Text))
            {
                lblErrorCiudad.Show();
                label1.Show();
            }
            else
            {
                Puerto abm = new Puerto();
                int resultado = 1;
                if(modCiudad || modDescripcion)
                    resultado = abm.modificarPuerto(puer_codigo, txtBoxCiudad.Text, txtBoxDescripcion.Text);

                if (resultado == 0)
                {
                    MessageBox.Show("Ya existe un puerto con esa ciudad. Ingrese otro nombre de ciudad."
                        , "Error: Ciudad ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxCiudad.Text = this.puer_ciudad;
                }
                else {
                    if (!this.ckBoxHabilitado.Checked)
                    {
                        abm.deshabilitarPuerto(puer_codigo);
                    }
                    else
                    {
                        abm.habilitarPuerto(puer_codigo);
                    }
                    //if(modCiudad || modDescripcion)
                    MessageBox.Show("Se modifico el puerto correctamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtBoxCiudad_TextChanged(object sender, EventArgs e)
        {
            modCiudad = true;
        }

        private void txtBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            modDescripcion = true;
        }
    }
}
