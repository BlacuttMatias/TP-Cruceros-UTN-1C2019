﻿using CapaDatos;
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
        DataTable dtTipoBaja;
        DataTable dtViajes;
        public Crucero abm = new Crucero();
        string codigo = "";
        string filtro = "";
        string filtroAlta = "";
        string filtroBaja = "";
        bool init = true;
        int tipoBaja;
        DateTime baja;
        DateTime alta;
        public frmBajarSeleccionado(params object[] args)
        {
            InitializeComponent();
            this.Load += FrmBajarSeleccionado_Load;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            codigo = args[0] as string;
            lblCodigo.Text += string.Format(":{0}", codigo);
            baja = Coneccion.getFechaSistema();
            alta = Coneccion.getFechaSistema().AddDays(1);
            btnAceptar.Enabled = false;
            btnPostergarTodos.Enabled = false;
            btnReemplazarCrucero.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmBajarSeleccionado_Load(object sender, EventArgs e)
        {
            dtTipoBaja = abm.mostrarTipoBaja();
            llenarCB(comboBox1, dtTipoBaja, "Descripcion");

            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.label2.Visible = false;
            this.dtpAlta.Visible = false;
            tipoBaja = 1;

            btnAceptar.Enabled = false;
            btnPostergarTodos.Enabled = false;
            btnReemplazarCrucero.Enabled = false;
            btnCancelarTodos.Enabled = false;

            dtpAlta.Format = DateTimePickerFormat.Custom;
            dtpAlta.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpAlta.Value = alta;
            dtpBaja.Format = DateTimePickerFormat.Custom;
            dtpBaja.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpBaja.Value = baja;
            
        }

        private void llenarCB(ComboBox cb, DataTable source, string columna)
        {
            foreach (DataRow marca in source.Rows)
                cb.Items.Add(marca[columna]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            btnPostergarTodos.Enabled = false;
            btnReemplazarCrucero.Enabled = false;
            btnCancelarTodos.Enabled = false;
            dataGridView1.DataSource = null;
            lblDescripcion.Text = "";
            if (new Regex(@"[(Permanente)(Temporal)]").IsMatch(comboBox1.Text))
            {
                comboBox1.ForeColor = Color.Black;
                //btnCancelarTodos.Enabled = true;
                if (new Regex(@"(Permanente)").IsMatch(comboBox1.Text))
                {
                    //btnPostergarTodos.Enabled = false;
                    //btnReemplazarCrucero.Enabled = true;
                    this.label2.Visible = false;
                    this.dtpAlta.Visible = false;
                    tipoBaja = 1;
                }
                else
                {
                    //btnReemplazarCrucero.Enabled=false;
                    //btnPostergarTodos.Enabled = true;
                    this.label2.Visible = true;
                    this.dtpAlta.Visible = true;
                    tipoBaja = 2;
                }
            }
            else
            {
                comboBox1.ForeColor = Color.Red;
                //btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            abm.bajaCrucero(codigo, dtpBaja.Value, dtpAlta.Value, comboBox1.Text);
            MessageBox.Show(string.Format("El Crucero {0} fue dado de baja de forma {1}", codigo, comboBox1.Text), "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            baja = Coneccion.getFechaSistema();
            alta = Coneccion.getFechaSistema().AddDays(1);
            dtpBaja.Value = baja;
            dtpAlta.Value = alta;
            dtpAlta.Visible = false;
            label2.Visible = false;
            btnAceptar.Enabled = false;
            btnPostergarTodos.Enabled = false;
            btnReemplazarCrucero.Enabled = false;
            btnCancelarTodos.Enabled = false;
            dataGridView1.DataSource = null;
            //actualizar();
        }

        private void dtpBaja_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBaja.Value != baja)
            {
                dtpAlta.Value = dtpBaja.Value;
                baja = dtpBaja.Value;
            }
        }

        private void dtpAlta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAlta.Value != alta)
            {
                if (dtpAlta.Value < dtpBaja.Value)
                {
                    dtpAlta.Value = dtpBaja.Value;

                }
                alta = dtpAlta.Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }
        private void actualizar()
        {
            if (tipoBaja == 1)
            {
                dtViajes = abm.mostrarViajesDeUnCrucero(codigo, baja);
            }
            else {
                dtViajes = abm.mostrarViajesDeCruceroEntre(codigo, baja, alta);
            }
            dataGridView1.DataSource = dtViajes;
            if(dtViajes.Rows.Count==0)
            {
                btnAceptar.Enabled = true;
                btnCancelarTodos.Enabled = false;
                btnPostergarTodos.Enabled = false;
                btnReemplazarCrucero.Enabled = false;
                lblDescripcion.Text = "No tiene viajes programados en esas fechas";
            }
            else
            {
                if (comboBox1.Text == "Permanente")
                {
                    btnCancelarTodos.Enabled = true;
                    btnReemplazarCrucero.Enabled = true;
                    btnPostergarTodos.Enabled = false;
                    btnAceptar.Enabled = false;
                    lblDescripcion.Text = string.Format("Viajes de :{0} que tiene programados a partir del {1}", codigo, dtpBaja.Value.ToString());
                }
                else
                {
                    btnCancelarTodos.Enabled = true;
                    btnReemplazarCrucero.Enabled = false;
                    btnPostergarTodos.Enabled = true;
                    btnAceptar.Enabled = false;
                    lblDescripcion.Text = string.Format("Viajes de :{0} que tiene programados entre el {1} y el {2}", codigo, dtpBaja.Value.ToString(), dtpAlta.Value.ToString());
                }
            }
        }
        private void btnReemplazarCrucero_Click(object sender, EventArgs e)
        {
            //Si la inactivad es por fin de la vida útil 
            //se reemplazan todos los viajes futuros por otro crucero.
            //El crucero reemplazante debe disponer de fechas libres para cumplir 
            //con el recorrido en cuestión en tiempo y forma.
            DataTable unCurcero = abm.cruceroParaReemplazarAOtro(codigo, baja);
            if (unCurcero.Rows.Count == 1)
            {
                string codigoNuevo = unCurcero.Rows[0]["Codigo"] as string;
                abm.actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente(codigo, codigoNuevo, baja);
                MessageBox.Show("Se reemplazo el crucero:" + codigo + " por el crucero:" + codigoNuevo, "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //actualizar();
                abm.bajaCrucero(codigo, dtpBaja.Value, dtpAlta.Value, comboBox1.Text);
                MessageBox.Show(string.Format("El Crucero {0} fue dado de baja de forma {1}", codigo, comboBox1.Text), "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                frmCopiarCrucero frmCopiarCrucero = new frmCopiarCrucero(codigo, abm, baja);
                frmCopiarCrucero.Show();
                frmCopiarCrucero.FormClosing += FrmCopiarCrucero_FormClosing;
                this.Enabled = false;
            }
            
        }

        private void FrmCopiarCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            //actualizar();
            this.Close();
        }

        private void btnPostergarTodos_Click(object sender, EventArgs e)
        {
            //Si la inactividad es por fuera de servicio, se reprogramarán de manera "automática" la
            //fecha de TODOS los viajes implicados, para ello el administrador deberá ingresar la
            //cantidad de días de corrimiento para todos los viajes.
            //abm.corrimientoDiasViaje(codigo, 0, Coneccion.getFechaSistema());
            frmPostergarViajes frmPostergarViajes = new frmPostergarViajes(codigo, abm, alta, baja);
            frmPostergarViajes.Show();
            frmPostergarViajes.FormClosing += FrmPostergarViajes_FormClosing;
            this.Enabled = false;
        }

        private void FrmPostergarViajes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            //actualizar();
            this.Close();
        }

        private void btnCancelarTodos_Click(object sender, EventArgs e)
        {
            if (tipoBaja == 1)
                abm.cancelarViajesBajaPermanente(codigo, baja);
            else if (tipoBaja == 2)
                abm.cancelarViajesBajaTemporal(codigo, baja, alta);
            MessageBox.Show("Los viajes y pasajes vendidos fueron cancelados con éxito", "Cancelacion exitosa"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //actualizar();
            abm.bajaCrucero(codigo, dtpBaja.Value, dtpAlta.Value, comboBox1.Text);
            MessageBox.Show(string.Format("El Crucero {0} fue dado de baja de forma {1}", codigo, comboBox1.Text), "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
