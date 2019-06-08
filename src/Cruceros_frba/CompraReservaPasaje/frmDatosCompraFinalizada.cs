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
    public partial class frmDatosCompraFinalizada : Form
    {
        private int codigoCompra;

        public frmDatosCompraFinalizada(int unCodigoCompra)
        {
            InitializeComponent();
            this.codigoCompra = unCodigoCompra;
        }

        private void frmDatosCompraFinalizada_Load(object sender, EventArgs e)
        {
            this.Width = 1540;
            this.CenterToScreen();
            dataGridDatosCompra.Width = this.Width-25;

            dataGridDatosCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatosMediosDePago datosMediosDePago = new DatosMediosDePago();

            dataGridDatosCompra.DataSource = datosMediosDePago.mostrarDatosCompraFinalizada(this.codigoCompra);
        }
    }
}
