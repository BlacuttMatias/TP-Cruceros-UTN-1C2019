using CapaDatos;
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
    public partial class frmTarjeta : Form
    {
        public Compra compra;
        public frmMedioDePago frmAnterior;
        public bool esTarjetaDeCredito;
        //solo lo uso para saber si el form se cerro porque se finalizo/efectuo o se cancelo la compra
        private bool seFinalizoLaCompra;

        public frmTarjeta(Compra unaCompra, frmMedioDePago unFrmAnterior, bool esUnaTarjetaDeCredito)
        {
            InitializeComponent();
            this.compra = unaCompra;
            this.frmAnterior = unFrmAnterior;
            this.esTarjetaDeCredito = esUnaTarjetaDeCredito;

            //seteo el cliente en la compra en caso de que no se haya hecho
            this.compra.setCodigoCliente(this.compra.getPasajes()[0].getCodigoCliente());

            double montoTotal = this.compra.getPasajes().Sum(pasaje => pasaje.getPrecio());
            txtMontoTotal.Enabled = false;
            txtMontoTotal.Text = "$ " + montoTotal.ToString();
            
        }

        private void frmTarjeta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

            //cargo los datos de la empresa en el comboBox
            List<String> listaEmpresas = new List<String>();
            foreach (DataRow fila in datosMediosDePago.obtenerEmpresasTarjetas().Rows)
            {
                listaEmpresas.Add(fila[1].ToString());
            }
            cmbEmpresa.DataSource = listaEmpresas;
            cmbEmpresa.SelectedIndex = 0;
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;

            //cargo los datos de la cuotas de esa empresa en el comboBox
            List<int> listaCantidadCuotas = new List<int>();
            foreach (DataRow fila in datosMediosDePago.obtenerCantidadDeCuotasDeUnaEmpresa(cmbEmpresa.SelectedIndex + 1).Rows)
            {
                listaCantidadCuotas.Add(Convert.ToInt32(fila[0].ToString()));
            }

            cmbCantidadCuotas.DataSource = listaCantidadCuotas;
            cmbCantidadCuotas.SelectedIndex = 0;
            cmbCantidadCuotas.DropDownStyle = ComboBoxStyle.DropDownList;

            //Si se eligio pagar por tarjeta de credito, no se daran a elegir las cuotas, ya que con debito
            //se paga siempre en una sola cuota
            if (!this.esTarjetaDeCredito) {
                cmbCantidadCuotas.Visible = false;
                lblCantidadDeCuotas.Visible = false;
            }

        }

        
        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cada vez que cambio la empresa, actualizo el comboBox para mostrar las cuotas que acepta
            //esa empresa

            DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

            List<int> listaCantidadCuotas = new List<int>();
            foreach (DataRow fila in datosMediosDePago.obtenerCantidadDeCuotasDeUnaEmpresa(cmbEmpresa.SelectedIndex + 1).Rows)
            {
                listaCantidadCuotas.Add(Convert.ToInt32(fila[0].ToString()));
            }

            cmbCantidadCuotas.DataSource = listaCantidadCuotas;
            cmbCantidadCuotas.SelectedIndex = 0;

        }

        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Vuelvo al formulario anterior
            this.Hide();
            this.frmAnterior.Show();
        }

        private void frmTarjeta_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Si cierro el formulario, cierro tambien el de medio de pago, avisandole que lo cerre yo
            //para que no salgo de nuevo el cartel de si desea estar seguro de cerrarlo
            this.frmAnterior.cerroElFormularioSiguiente = true;
            this.frmAnterior.Close();
            
        }

        private void frmTarjeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.seFinalizoLaCompra) {
                //Al quererse cerrar, se pregunta si desea de verdad hacerlo
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cancelar la compra?", "Cancelación compra"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //si no se completo algun campo, le mando un mensaje para que los complete
            if (String.IsNullOrWhiteSpace(txtNumeroTarjeta.Text) || String.IsNullOrWhiteSpace(txtCodigoVerificador.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error: Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                //cargo los datos de los textBox y comboBox
                int numeroTarjeta = Convert.ToInt32(txtNumeroTarjeta.Text);
                int codigoVerificador = Convert.ToInt32(txtCodigoVerificador.Text);
                //lo inicialize en un valor cualquiera, sino me tiraba warning
                int codigoEmpresa = 1;
                //la cantidad de cuotas sera 1 si es de debito la tarjeta
                int cantidadDeCuotas = 1;
                //si es de credito se toma las del comboBox
                if (this.esTarjetaDeCredito)
                {
                    cantidadDeCuotas = Convert.ToInt32(cmbCantidadCuotas.SelectedValue);
                }
                //defino el tipo de tarjeta
                string tipoDeTarjeta;
                if (this.esTarjetaDeCredito)
                {
                    tipoDeTarjeta = "CREDITO";
                }
                else
                {
                    tipoDeTarjeta = "DEBITO";
                }

                DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

                //cargo el codigo de la empresa con los datos del comboBox y obteniendo el codigo de la BD
                foreach (DataRow fila in datosMediosDePago.obtenerEmpresasTarjetas().Rows)
                {
                    if (fila[1].ToString() == cmbEmpresa.SelectedValue)
                    {
                        codigoEmpresa = Convert.ToInt32(fila[0].ToString());
                    }
                }

                int codigoMedioDePago;
                int codigoCompra;

                //persisto todos los datos del medio de pago
                datosMediosDePago.persistirTarjeta(numeroTarjeta, codigoVerificador, tipoDeTarjeta, codigoEmpresa);
                codigoMedioDePago = datosMediosDePago.persistirMedioDePago(compra.getMedioDePago().getCodigoTipoMedioDePago()
                    , numeroTarjeta, cantidadDeCuotas);

                //persisto la compra
                codigoCompra = datosMediosDePago.persistirCompra(this.compra.getCodigoCliente(), codigoMedioDePago);

                //si ya se paga una reserva, ya está persistido el pasaje, entonces solo lo vinculo el mismo
                //a la compra. Sino, si es una compra directa, persisto los pasajes y los agrego a la compra
                if (this.compra.getEsUnaCompraDeUnaReserva())
                {
                    foreach (Pasaje pasaje in this.compra.getPasajes())
                    {
                       datosMediosDePago.agregarPasajeAUnaCompra(pasaje.getCodigoPasaje(), codigoCompra);
                    }
                }
                else {
                    foreach(Pasaje pasaje in this.compra.getPasajes()){
                        int codigoPasaje = datosMediosDePago.persistirPasaje(pasaje.getCodigoCliente(), 
                            pasaje.getCodigoViaje(), pasaje.getCodigoCabina());
                        datosMediosDePago.agregarPasajeAUnaCompra(codigoPasaje, codigoCompra);
                    }
                    
                }

                MessageBox.Show("Su compra se ha registrado con éxito.", "Compra finalizada", MessageBoxButtons.OK);
                this.seFinalizoLaCompra = true;
                
                //muestro los datos de la compra
                frmDatosCompraFinalizada frm = new frmDatosCompraFinalizada(codigoCompra);
                frm.FormClosed += frm_FormClosed;
                frm.Show();
                
                this.Hide();

            }
            

        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

       
        private void txtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifico que solo se puedan escribit numeros en ese txtNumeroTarjeta
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
                toolTipNumeroTarjeta.Show("Solo puede escribir números (0-9) en este campo", txtNumeroTarjeta, 3000);
            }
        }

        private void txtCodigoVerificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifico que solo se puedan escribit numeros en ese txtCodigoVerificador
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTipCodigoVerificador.Show("Solo puede escribir números (0-9) en este campo", txtCodigoVerificador, 3000);
            }
        }

    }
}
