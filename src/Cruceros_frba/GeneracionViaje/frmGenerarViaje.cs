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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class frmGenerarViaje : Form
    {
        public frmGenerarViaje()
        {
            InitializeComponent();
        }

        private void frmGenerarViaje_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpFechaInicio.Value = Coneccion.getFechaSistema();

            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpFechaFin.Value = Coneccion.getFechaSistema().AddDays(3);

            cmbRecorrido.DropDownStyle = ComboBoxStyle.DropDownList;

            DatosViaje datosViaje = new DatosViaje();

            foreach (DataRow row in datosViaje.mostrarRecorridosDisponibles().Rows) {
                cmbRecorrido.Items.Add(row[0].ToString());
            }

            cmbRecorrido.SelectedIndex = 0;

            dataGridCruceros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCruceros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCruceros.DataSource = datosViaje.mostrarCrucerosDisponiblesEnEsasFechas(
                dtpFechaInicio.Value, dtpFechaFin.Value);

        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
