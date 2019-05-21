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
    public partial class frmModificarRolSeleccionado : Form
    {
        public frmModificarRolSeleccionado()
        {
            InitializeComponent();
            this.textBox1.Text="TiraFruta";
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Se se tildo o destildo
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Si Cambio El nombre que se actualize una variable que sera enviada al update
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = listBox1.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = FuncAgregadas.FindString(curItem);
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                FuncAgregadas.Items.Add(curItem);
            else
                FuncAgregadas.SetSelected(index, true);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (FuncAgregadas.SelectedIndex == -1)
            {

            }
            else
            {
                string curItem = FuncAgregadas.SelectedItem.ToString();

                FuncAgregadas.Items.RemoveAt(FuncAgregadas.SelectedIndex);
            }
        }
    }
}
