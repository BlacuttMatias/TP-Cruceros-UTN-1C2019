using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class frmListadosEstadisticos : Form
    {

        public frmListadosEstadisticos()
        {
            InitializeComponent();

            
        }

        private void frmListadosEstadisticos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            dataGridListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmbAnio.DataSource = Enumerable.Range(1900, 2019 - 1899).ToList();
            cmbAnio.SelectedIndex = cmbAnio.Items.IndexOf(2019);
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbSemestre.DataSource = new List<int> { 1, 2 };
            cmbSemestre.SelectedIndex = cmbSemestre.Items.IndexOf(1);
            cmbSemestre.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTipoListado.DataSource = new List<String>{
                "Recorridos con mas pasajes comprados",
                "Recorridos con mas cabinas libres en cada viaje",
                "Cruceros con mas dias fuera de servicio"
            };
            cmbTipoListado.SelectedIndex = 0;
            cmbTipoListado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Listado listado = new Listado();
            int anio = Convert.ToInt32(cmbAnio.SelectedValue);
            int semestre = Convert.ToInt32(cmbSemestre.SelectedValue);
            DataTable dataTableListado;
            if (cmbTipoListado.SelectedIndex == 0) {
                dataTableListado = listado.mostrarLosCincoRecorridosConMasPasajesComprados(anio, semestre);
            }
            else if (cmbTipoListado.SelectedIndex == 1)
            {
                dataTableListado = listado.mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje(anio, semestre);
            }
            else {
                dataTableListado = listado.mostrarLosCincoCrucerosConMasDiasFueraDeServicio(anio, semestre);
            }
            dataGridListado.DataSource = dataTableListado;
            if (dataTableListado.Rows.Count == 0) {
                MessageBox.Show("No hay registros con ese intervalo de fechas","Aviso", MessageBoxButtons.OK);
            }
        }

        
    }
}
