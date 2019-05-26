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
    public partial class frmBajaRol : Form
    {
        public frmBajaRol()
        {
            InitializeComponent();
        }
        private void frmBajaRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Rol abm = new Rol();
            this.dataGridRoles.DataSource = abm.mostrarRolesHabilitados();
            if (dataGridRoles.Rows.Count == 0)
            {
                MessageBox.Show("Actualmente no hay roles para dar de baja", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void dataGridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dataGridRoles.Rows[e.RowIndex];

                this.rolCodigo.Text = Fila.Cells["Codigo"].Value.ToString();
                this.rolDescripcion.Text = Fila.Cells["Descripcion"].Value.ToString();

                this.btnEliminarRol.Enabled = true;
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            Rol abm = new Rol();
            abm.deshabilitarRol(Convert.ToInt32(rolCodigo.Text));
            this.dataGridRoles.DataSource = abm.mostrarRolesHabilitados();
            this.rolCodigo.Text = "";
            this.rolDescripcion.Text = "";
            this.btnEliminarRol.Enabled = false;
            MessageBox.Show("Baja de rol exitosa", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dataGridRoles.Rows.Count == 0)
            {
                MessageBox.Show("Actualmente no hay roles para dar de baja", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
