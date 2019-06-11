﻿using System;
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
    public partial class frmModificarCruceroSeleccionado : Form
    {
        List<nodoCabina> cabinas = new List<nodoCabina>();
        string codigo = "";
        DataTable dt = new DataTable();
        public frmModificarCruceroSeleccionado(params object[] args)
        {
            InitializeComponent();
            this.Load += frmAltaCrucero_Load;
            btnAceptar.Enabled = false;
            codigo = args[0] as string;
            lblCodigo.Text += $" {codigo}";
            cBoxMarca.Text = args[1] as string;
            cBoxModelo.Text = args[2] as string;
            Load += new EventHandler(frmModificarCruceroSeleccionado_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
        }
        private void llenarLista()
        {
            List<string> tipoCabinas = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                tipoCabinas.Add(r["Descripcion"] as string);
            }
            foreach (DataRow r in dt.Rows)
            {
                int unPiso = Convert.ToInt32(r["Piso"]);
                string cabinaTipo =r["Descripcion"] as string;
                if (cabinas.Exists(x=>x.piso==unPiso))
                {
                    nodoCabina nodo = cabinas.Find(x => x.piso == unPiso);
                    nodo.cabinas[tipoCabinas.IndexOf(cabinaTipo)]++;
                }
                else
                {
                    nodoCabina nodo = new nodoCabina();
                    nodo.piso = unPiso;
                    for (int i = 0; i < 5; i++)
                        nodo.cabinas.Add(0);
                    nodo.cabinas[tipoCabinas.IndexOf(cabinaTipo)]++;
                }
            }
        }
        private void frmModificarCruceroSeleccionado_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Crucero abm = new Crucero();
            dt = abm.mostrarCabinasDeUnCrucero(codigo);
            dataGridView1.DataSource = dt;
            llenarLista();
            foreach (nodoCabina n in cabinas)
            {
                string log = $"{nameof(n.piso)}:{n.piso}";
                int i = 0;
                foreach (int c in n.cabinas)
                {
                    log += "\n" + $"{i}:{c}";
                }

                debugger.log(log);
            }
        }

        Crucero abm;
        AbmRecorrido.Debugger debugger;
        private void frmAltaCrucero_Load(object sender, EventArgs e)
        {
            debugger = new AbmRecorrido.Debugger();
            debugger.Show();
            abm = new Crucero();
            DataTable dtMarcas = abm.mostrarMarcas();
            llenarCB(cBoxMarca, dtMarcas, "Marca");

            DataTable dtModelos = abm.mostrarModelos();
            llenarCB(cBoxModelo, dtModelos, "Modelo");
        }

        private void imprimir(List<int> c)
        {
            Console.Write("\n");
            foreach (int i in c)
                Console.Write(i + ",");
        }
        private void llenarCB(ComboBox cb, DataTable source, string columna)
        {
            foreach (DataRow marca in source.Rows)
                cb.Items.Add(marca[columna]);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cBoxMarca.Text = "";
            cBoxModelo.Text = "";
        }

        private void cBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            debugger.log($"Codigo:{codigo} Marca:{cBoxMarca.Text} Modelo:{cBoxModelo.Text}");
            abm.modigicarCrucero(codigo, cBoxMarca.Text, cBoxModelo.Text);
                //MessageBox.Show($"Ya existe:{codigo}", "FRBACruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}