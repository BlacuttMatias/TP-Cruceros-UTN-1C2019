using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaCrucero.AbmRol;
using FrbaCrucero.FormsPrincipales;

namespace FrbaCrucero.UserLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datosUsuario = Login.loguearUsuario(this.usuarioTxt.Text, this.passwordTxt.Text);

            if (datosUsuario.Rows.Count == 0)
            {
                MessageBox.Show("No existe el Usuario o la Contraseña no es correcta", "Login Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (datosUsuario.Rows[0][2].ToString() == "False")
            {
                MessageBox.Show("El usuario se encuentra deshabilitado", "Login Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmPrincipalAdmin frm = new frmPrincipalAdmin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
