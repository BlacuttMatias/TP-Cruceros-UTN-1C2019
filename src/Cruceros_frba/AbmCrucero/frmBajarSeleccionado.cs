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
    public partial class frmBajarSeleccionado : Form
    {
        DataTable dt;
        Crucero abm=new Crucero();
        string codigo = "";
        public frmBajarSeleccionado(params object[] args)
        {
            InitializeComponent();
            this.Load += FrmBajarSeleccionado_Load;
            codigo = args[0] as string;
            lblCodigo.Text += $":{codigo}";
            dtpBaja.Value = Convert.ToDateTime(args[3]);
            dtpAlta.Value = Convert.ToDateTime(args[4]);
            btnAceptar.Enabled = false;
        }

        private void FrmBajarSeleccionado_Load(object sender, EventArgs e)
        {
            dt = abm.mostrarTipoBaja();
            llenarCB(comboBox1, dt, "Descripcion");
        }

        private void llenarCB(ComboBox cb, DataTable source, string columna)
        {
            foreach (DataRow marca in source.Rows)
                cb.Items.Add(marca[columna]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(new Regex(@"[(Permanente)(Temporal)]").IsMatch(comboBox1.Text))
            {
                comboBox1.ForeColor = Color.Black;
                btnAceptar.Enabled = true;
            }
            else
            {
                comboBox1.ForeColor = Color.Red;
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Crucero abm = new Crucero();
            abm.bajaCrucero(codigo, dtpBaja.Value, dtpAlta.Value, comboBox1.Text);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            
            btnAceptar.Enabled = false;
        }
    }
}
