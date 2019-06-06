using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class frmMedioDePago : Form
    {

        public Compra compra = new Compra();
        public bool cerroElFormularioSiguiente;

        public frmMedioDePago(Compra unaCompra)
        {
            InitializeComponent();
            this.compra = unaCompra;
            compra.setMedioDePago(new MedioDePago());
        }

        

        private void frmMedioDePago_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

            List<String> listaTiposDeMediosDePago = new List<String>();
            foreach (DataRow fila in datosMediosDePago.obtenerTiposMediosDePago().Rows)
            {
                listaTiposDeMediosDePago.Add(fila[1].ToString());
            }
            cmbMediosDePago.DataSource = listaTiposDeMediosDePago;
            cmbMediosDePago.SelectedIndex = 0;
            cmbMediosDePago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            compra.getMedioDePago().setCodigoTipoMedioDePago(cmbMediosDePago.SelectedIndex + 1);
            bool esTarjetaDeCredito = (Convert.ToString(cmbMediosDePago.SelectedValue) == "Tarjeta de credito");
            frmTarjeta frmSiguiente = new frmTarjeta(compra, this, esTarjetaDeCredito);
            this.Hide();
            frmSiguiente.Show();
        }

        private void frmMedioDePago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerroElFormularioSiguiente) {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cancelar la compra?", "Cancelación compra"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

    }
}
