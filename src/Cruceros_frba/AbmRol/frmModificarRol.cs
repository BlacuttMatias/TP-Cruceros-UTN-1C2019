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
        public frmModificarRol()
        {
            InitializeComponent();
        }

        private void dataGridRoles_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.dataGridRoles.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Deberia hacer un select con un rol_descipcion = textBox1.Text o algo asi
            //y pasar los valores del dataset al dataGridRoles
        }
    }
}
