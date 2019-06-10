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
    public partial class frmAltaRol : Form
    {
        Rol abm = new Rol();
        public frmAltaRol()
        {
            InitializeComponent();
            this.Load += FrmAltaRol_Load;
        }

        private void FrmAltaRol_Load(object sender, EventArgs e)
        {
            DataTable listaDeFuncionalidades = abm.getFuncionalidades(nombreRol.Text);
            foreach (DataRow fila in listaDeFuncionalidades.Rows)
            {
                listFuncionalidadesNoAgregadas.Items.Add(fila[0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listFuncionalidadesNoAgregadas.SelectedItem.ToString();
            int index = listFuncionalidadesAAgregar.FindString(curItem);
            if (index == -1)
                listFuncionalidadesAAgregar.Items.Add(curItem);
            else
                listFuncionalidadesAAgregar.SetSelected(index, true);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFuncionalidadesAAgregar.SelectedIndex == -1)
            {

            }
            else
            {
                string curItem = listFuncionalidadesAAgregar.SelectedItem.ToString();

                listFuncionalidadesAAgregar.Items.RemoveAt(listFuncionalidadesAAgregar.SelectedIndex);
            }
        }

        private void agregarRol_Click(object sender, EventArgs e)
        {
            
        }
        private void agregarRol()
        {
            if (nombreRol.Text != "")
            {
                
                if (abm.crearRol(nombreRol.Text) == 0)
                {
                    MessageBox.Show("El rol que ingresó ya existe. Ingrese otro rol", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Rol creado exitosamente", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        nombreRol.Enabled = false;
                        listFuncionalidadesNoAgregadas.Enabled = true;
                        listFuncionalidadesAAgregar.Enabled = true;
                        btnAgregarFuncionalidades.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nombre de rol vacío. Inserte el nombre del rol", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarFuncionalidades_Click(object sender, EventArgs e)
        {
            agregarRol();
            int cantidad = listFuncionalidadesAAgregar.Items.Count;
            Rol abm = new Rol();
            if (listFuncionalidadesAAgregar.Items.Count<1)
            {
                MessageBox.Show("Selección vacía. Seleccione una funcionalidad para agregar", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach(string a in listFuncionalidadesAAgregar.Items)
                {
                    abm.agregarFuncionalidadARol(nombreRol.Text, a);
                }
                DataTable listaDeFuncionalidades = abm.getFuncionalidades(nombreRol.Text);
                if (listaDeFuncionalidades.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Se Agregaron:" + cantidad.ToString() + " Funcionalidades", "FIDEOS_CON_TUCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DialogResult result2 = MessageBox.Show("Desea agregar alguna funcionalidad más a este rol?", "FIDEOS_CON_TUCO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result2 == DialogResult.Yes)
                        {
                            foreach (DataRow fila in listaDeFuncionalidades.Rows)
                            {
                                listFuncionalidadesNoAgregadas.Items.Add(fila[0].ToString());
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todas las funcionalidades del sistema han sido asignadas al rol. Ingrese un nuevo rol", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nombreRol.Enabled = true;
                    listFuncionalidadesNoAgregadas.Items.Clear();
                    listFuncionalidadesNoAgregadas.Enabled = false;
                    btnAgregarFuncionalidades.Enabled = false;
                }
            }

        }

    }
}
