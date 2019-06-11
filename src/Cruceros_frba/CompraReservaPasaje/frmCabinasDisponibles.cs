﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class frmCabinasDisponibles : Form
    {
        public int codigoViaje;
        public int codigoCliente;
        Compra nuevaCompra = new Compra();

        public frmCabinasDisponibles(int codigoViaje, int codigoCliente)
        {
            InitializeComponent();
            dataGridCabinasDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCabinasDisponibles.MultiSelect = true;
            dataGridCabinasDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #region Llenar Grid
            GestionCompra gestion = new GestionCompra();
            dataGridCabinasDisponibles.DataSource = gestion.llenarGridCabinas(codigoViaje);
            #endregion
            this.codigoCliente = codigoCliente;
            this.codigoViaje = codigoViaje;
            nuevaCompra.setCodigoCliente(codigoCliente);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea Comprar estas cabinas?", "Comprar Cabinas", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {

                int cantCabinas = dataGridCabinasDisponibles.SelectedRows.Count;
                if (cantCabinas > 0) //Me fijo si selecciono alguna cabina
                {
                    foreach (DataGridViewRow row in dataGridCabinasDisponibles.SelectedRows)
                    {
                        #region Creacion de Pasaje
                        Pasaje nuevoPasaje = new Pasaje();
                        int codigoCabina = (int)(row.Cells[0].Value);
                        double precioViaje = Convert.ToDouble(row.Cells["Precio"].Value);
                        nuevoPasaje.setCodigoCabina(codigoCabina);
                        nuevoPasaje.setCodigoCliente(codigoCliente);
                        nuevoPasaje.setCodigoViaje(codigoViaje);
                        nuevoPasaje.setPrecio(precioViaje);
                        #endregion

                        #region Llenar Compra
                        nuevaCompra.agregarPasaje(nuevoPasaje);
                        #endregion


                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar almenos una cabina que desee Comprar", "Falta seleccionar cabina/s deseadas", MessageBoxButtons.OK);
                }

                frmMedioDePago frm = new frmMedioDePago(nuevaCompra);
                frm.Show();
                frm.FormClosed += frm_FormClosed;
                this.Hide();
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
