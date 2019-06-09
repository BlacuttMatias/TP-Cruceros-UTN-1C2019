using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class frmCliente : Form
    {

        private int codigoCliente;
        private int dni;
        private bool seEscogioUnClienteExistente;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
            dtpFechaNacimiento.Value = Coneccion.getFechaSistema();
            listBoxNombres.Visible = false;
        }

        bool noSeLlenaronLosCamposObligatorios() {
            return String.IsNullOrWhiteSpace(txtDni.Text) &&
                String.IsNullOrWhiteSpace(txtNombre.Text) &&
                String.IsNullOrWhiteSpace(txtApellido.Text) &&
                String.IsNullOrWhiteSpace(txtTelefono.Text) &&
                String.IsNullOrWhiteSpace(txtDireccion.Text);
        }

    

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTipDni.Show("Solo puede escribir números (0-9) en este campo", txtDni, 3000);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTipTelefono.Show("Solo puede escribir números (0-9) en este campo", txtTelefono, 3000);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
                toolTipNombre.Show("Solo puede escribir letras en este campo", txtNombre, 3000);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTipApellido.Show("Solo puede escribir letras en este campo", txtApellido, 3000);
            }
        }

        private void llenarCamposConDatosCliente(DataRow rowDatosCliente){

            codigoCliente = Convert.ToInt32(rowDatosCliente[0].ToString());

            txtNombre.Text = rowDatosCliente["Nombre"].ToString();
            txtApellido.Text = rowDatosCliente["Apellido"].ToString();
            txtTelefono.Text = rowDatosCliente["Telefono"].ToString();
            if (rowDatosCliente[5] != null) txtMail.Text = rowDatosCliente["Mail"].ToString();
            txtDireccion.Text = rowDatosCliente["Direccion"].ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(rowDatosCliente["fechaNacimiento"].ToString());
            
        }

        private void mostrarPosiblesClientesEnListBox(DataTable dataTableClientes)
        {

            listBoxNombres.Visible = true;
            foreach(DataRow rowDatosCliente in dataTableClientes.Rows){
                listBoxNombres.Items.Add(rowDatosCliente["Apellido"].ToString()
                    + ", " + rowDatosCliente["Nombre"].ToString());
            }
        
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            listBoxNombres.Visible = false;
            DatosCliente datosCliente = new DatosCliente();

            if (txtDni.TextLength > 0) {

                dni = Convert.ToInt32(txtDni.Text);
                DataTable dataTableCliente = datosCliente.obtenerDatosCliente(dni);
                if (dataTableCliente.Rows.Count > 1)
                {
                    mostrarPosiblesClientesEnListBox(dataTableCliente);
                }
            }
        }

        private void frmCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBoxNombres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DatosCliente datosCliente = new DatosCliente();
            DataTable dataTableCliente = datosCliente.obtenerDatosCliente(dni);
            llenarCamposConDatosCliente(dataTableCliente.Rows[listBoxNombres.SelectedIndex]);
            listBoxNombres.Visible = false;
            listBoxNombres.Items.Clear();
            seEscogioUnClienteExistente = true;
            txtDni.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.noSeLlenaronLosCamposObligatorios())
            {
                MessageBox.Show("Se deben llenar todos los campos obligatorios", "Error: campos obligatorios incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DatosCliente datosCliente = new DatosCliente();
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                this.dni = Convert.ToInt32(txtDni.Text);
                int telefono = Convert.ToInt32(txtTelefono.Text);
                string mail;
                if (String.IsNullOrWhiteSpace(txtMail.Text))
                {
                    mail = null;
                }
                else { 
                    mail = txtMail.Text;
                }
                string direccion = txtDireccion.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;

                if (this.seEscogioUnClienteExistente)
                {
                    datosCliente.actualizarCliente(codigoCliente, nombre, apellido, this.dni,
                        telefono, mail, direccion, fechaNacimiento);
                }
                else
                {
                    this.codigoCliente = datosCliente.persistirCliente(nombre, apellido
                        , this.dni, telefono, mail, direccion, fechaNacimiento);
                }

                //Aca se deberia llamar al siguiente formulario pasandole el codigoCliente

            }
            
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = Coneccion.getFechaSistema();

            this.seEscogioUnClienteExistente = false;
            txtDni.Enabled = true;
        }


    }
}
