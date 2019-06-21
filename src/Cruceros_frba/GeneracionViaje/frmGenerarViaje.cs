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

        private List<int> idRecorridos = new List<int>();

        public frmGenerarViaje()
        {
            InitializeComponent();
        }

        private void frmGenerarViaje_Load(object sender, EventArgs e)
        {
            this.Width = 1530;
            this.CenterToParent();
            
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpFechaInicio.Value = Coneccion.getFechaSistema().AddHours(1);

            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpFechaFin.Value = Coneccion.getFechaSistema().AddDays(3).AddHours(1);

            cmbRecorrido.DropDownStyle = ComboBoxStyle.DropDownList;

            lblNoExistenCruceros.Visible = false;

            DatosViaje datosViaje = new DatosViaje();

            foreach (DataRow row in datosViaje.mostrarRecorridosDisponibles().Rows) {
                this.idRecorridos.Add(Convert.ToInt32(row[0].ToString()));
                cmbRecorrido.Items.Add(row[1].ToString());
            }

            cmbRecorrido.SelectedIndex = 0;

            dataGridCruceros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCruceros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCruceros.DataSource = datosViaje.mostrarCrucerosDisponiblesEnEsasFechas(
                dtpFechaInicio.Value, dtpFechaFin.Value);
            if (dataGridCruceros.Rows.Count > 0)
            {
                lblNoExistenCruceros.Visible = false;
            }
            else
            {
                lblNoExistenCruceros.Visible = true;
            }

        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value <= Coneccion.getFechaSistema())
            {
                MessageBox.Show("La fecha de inicio del viaje debe ser mayor que la fecha actual.\nLa fecha actual es: " + Coneccion.getFechaSistema().ToString()
                    , "Fechas incorrectas", MessageBoxButtons.OK);
            }
            else if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de finalización del viaje debe ser mayor que la fecha inicial."
                    , "Fechas incorrectas", MessageBoxButtons.OK);
            }
            else if (dataGridCruceros.SelectedRows.Count < 1 || cmbRecorrido.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un crucero y un recorrido para el viaje"
                    , "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string codigoCrucero = dataGridCruceros.SelectedRows[0].Cells["Codigo"].Value.ToString();
                int idRecorrido = this.idRecorridos[cmbRecorrido.SelectedIndex];
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                DatosViaje datosViaje = new DatosViaje();

                int resultado = datosViaje.persistirViaje(idRecorrido, codigoCrucero,
                    fechaInicio, fechaFin);

                if (resultado == 1)
                {
                    MessageBox.Show("Su viaje se ha generado con éxito", "Generación de viaje exitosa",
                        MessageBoxButtons.OK);
                    dataGridCruceros.DataSource = datosViaje.mostrarCrucerosDisponiblesEnEsasFechas(
                        dtpFechaInicio.Value, dtpFechaFin.Value);
                }
                else {
                    MessageBox.Show("Error: no se ha podido generar el viaje", "Generación de viaje Fallida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DatosViaje datosViaje = new DatosViaje();
            if (dtpFechaFin.Value <= dtpFechaInicio.Value) {
                dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1);
            }
            DataTable dataTableCruceros = datosViaje.mostrarCrucerosDisponiblesEnEsasFechas(
                dtpFechaInicio.Value, dtpFechaFin.Value);

            if (dataTableCruceros.Rows.Count > 0)
            {
                lblNoExistenCruceros.Visible = false;
            }
            else
            {
                lblNoExistenCruceros.Visible = true;
            }
            dataGridCruceros.DataSource = dataTableCruceros;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            DatosViaje datosViaje = new DatosViaje();
            if (dtpFechaInicio.Value >= dtpFechaFin.Value)
            {
                dtpFechaInicio.Value = dtpFechaFin.Value.AddDays(-1);
            }
            DataTable dataTableCruceros = datosViaje.mostrarCrucerosDisponiblesEnEsasFechas(
                dtpFechaInicio.Value, dtpFechaFin.Value);

            if (dataTableCruceros.Rows.Count > 0)
            {
                lblNoExistenCruceros.Visible = false;
            }
            else
            {
                lblNoExistenCruceros.Visible = true;
            }
            dataGridCruceros.DataSource = dataTableCruceros;
        }
    }
}
