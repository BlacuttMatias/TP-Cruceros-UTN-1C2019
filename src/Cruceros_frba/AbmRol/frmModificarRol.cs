using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class frmModificarRol : Form
    {
        private string rol_Description = "";
        private string rol_Codigo = "";
        private string rol_esta_habilitado="";
        public frmModificarRol()
        {
            InitializeComponent();
        }
        private void frmModificarRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Rol abm = new Rol();
            this.dataGridRoles.DataSource = abm.mostrarRoles();
            if (dataGridRoles.Rows.Count == 0)
            {
                MessageBox.Show("Actualmente no hay roles para modificar", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void dataGridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridRoles.Rows[e.RowIndex];

                rol_Codigo = Fila.Cells["Codigo"].Value.ToString();
                rol_Description = Fila.Cells["Descripcion"].Value.ToString();
                rol_esta_habilitado = Fila.Cells["Habilitado"].Value.ToString();
                frmModificarRolSeleccionado frmRolSeleccionado = new frmModificarRolSeleccionado(rol_Codigo, rol_Description, rol_esta_habilitado);
                frmRolSeleccionado.Show();
                this.Hide();
                frmRolSeleccionado.FormClosing += frmRolSeleccionado_Closing;

            }
        }
        private void frmRolSeleccionado_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        
    }
}
