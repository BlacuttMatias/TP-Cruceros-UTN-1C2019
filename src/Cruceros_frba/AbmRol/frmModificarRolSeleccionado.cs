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
        private int codigo=-1;
        private string descripcion = "";
        private bool modNombre = false;
        private bool modFuncionalidad = false;
        string[] backupFuncionalidadesExistentes= { };
        string[] backupFuncionalidadesFaltantes= { };

        string descripcionOriginal;

        public frmModificarRolSeleccionado(string rol_codigo,string rol_descripcion,string rol_esta_habilitado)
        {
            InitializeComponent();
            this.textBox1.Text=rol_descripcion;
            descripcionOriginal = rol_descripcion;
            if(rol_esta_habilitado == "SI")
            {
                this.checkBoxHabilitado.Checked=true;
            }
            codigo = Convert.ToInt32(rol_codigo);
            this.label1.Text = "Codigo:" + codigo+ " Descripcion:";
            Rol abm = new Rol();
            DataTable listaDeFuncionalidadesFaltantes = abm.getFuncionalidades(rol_descripcion); 
            foreach (DataRow fila in listaDeFuncionalidadesFaltantes.Rows)
            {
                listBox1.Items.Add(fila[0].ToString());
                Array.Resize(ref backupFuncionalidadesFaltantes, backupFuncionalidadesFaltantes.Length + 1);
                backupFuncionalidadesFaltantes[backupFuncionalidadesFaltantes.Length - 1] = fila[0].ToString();
            }
            DataTable listaDeFuncionalidadesPresentes = abm.getFuncionalidadesAsignadas(rol_descripcion);
            foreach (DataRow fila in listaDeFuncionalidadesPresentes.Rows)
            {
                listBox2.Items.Add(fila[0].ToString());
                Array.Resize(ref backupFuncionalidadesExistentes, backupFuncionalidadesExistentes.Length + 1);
                backupFuncionalidadesExistentes[backupFuncionalidadesExistentes.Length - 1] = fila[0].ToString();
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            modNombre = true;
        }

        private void FuncionalidadesFaltantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            modFuncionalidad = true;
            if(listBox1.SelectedIndex==-1)
            {

            }
            else
            {
                string curItem = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                int index = listBox2.FindString(curItem);
                if (index == -1)
                {
                    listBox2.Items.Add(curItem);
                }
                else
                    listBox2.SetSelected(index, true);
            }
        }
        private void FuncionalidadesExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            modFuncionalidad = true;
            if (listBox2.SelectedIndex == -1)
            {

            }
            else
            {
                string curItem = listBox2.SelectedItem.ToString();

                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                int index = listBox1.FindString(curItem);
                if (index == -1)
                    listBox1.Items.Add(curItem);
                else
                    listBox1.SetSelected(index, true);
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Rol abm = new Rol();
            if (modNombre)
                descripcion = this.textBox1.Text;

            int resultado = abm.cambiarNombreRol(codigo, descripcion);

            if (resultado == 0)
            {
                MessageBox.Show("Ya existe un rol con ese nombre", "Nombre de rol existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = descripcionOriginal;
            }
            else {
                if (!this.checkBoxHabilitado.Checked)
                {
                    abm.deshabilitarRol(codigo);
                }
                else
                {
                    abm.habilitarRol(codigo);
                }
                if (modFuncionalidad)
                {
                    string imprimirAgregar = "";
                    string imprimirQuitar = "";
                    IEnumerable<string> quitar = backupFuncionalidadesExistentes.Where(x => !listBox2.Items.Contains(x));
                    foreach (string a in quitar)
                    {
                        imprimirQuitar += Environment.NewLine + a;
                        abm.eliminarFuncionalidadARol(codigo, a);
                    }
                    IEnumerable<string> agregar = backupFuncionalidadesFaltantes.Where(x => !listBox1.Items.Contains(x));

                    foreach (string a in agregar)
                    {
                        imprimirAgregar += Environment.NewLine + a;
                        abm.agregarFuncionalidadARol(descripcion, a);
                    }
                    MessageBox.Show("El rol se ha modificado exitosamente", "Modificación de rol exitosa", MessageBoxButtons.OK);
                    DialogResult result2 = MessageBox.Show("Rol: " + this.textBox1.Text + Environment.NewLine + "Funcionabilidades Obtenidas:" + imprimirAgregar + Environment.NewLine + "Funcionabilidades Perdidas:" + imprimirQuitar, "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show("El rol se ha modificado exitosamente", "Modificación de rol exitosa", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            
        }
    }
}
