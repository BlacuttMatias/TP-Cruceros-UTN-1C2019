using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{

    public partial class frmAltaCrucero : Form
    {
        Crucero abm;
        public frmAltaCrucero()
        {
            InitializeComponent();
            this.Load += frmAltaCrucero_Load;
            btnAceptar.Enabled = false;
        }
        int cantPisos = 0;
        int piso = 0;
        //List<int> cabinas = new List<int>();
        DataTable dtCabinas;
        AbmRecorrido.Debugger debugger;
        List<nodoCabina> cabinas = new List<nodoCabina>();
        //List<Button> listaTrack = new List<Button>();

        string checkmark = "✔";
        private void frmAltaCrucero_Load(object sender, EventArgs e)
        {
            debugger = new AbmRecorrido.Debugger();
            //debugger.Show();
            abm = new Crucero();
            DataTable dtMarcas = abm.mostrarMarcas();
            llenarCB(cBoxMarca, dtMarcas, "Marca");

            DataTable dtModelos = abm.mostrarModelos();
            llenarCB(cBoxModelo, dtModelos, "Modelo");
            cBoxMarca.Enabled = false;
            cBoxModelo.Enabled = false;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";

            dtCabinas = abm.mostrarTipoCabina();

            foreach (DataRow row in dtCabinas.Rows)
            {
                AddItem(row["Cabina"].ToString());
            }
            superTabla.Enabled = false;
            llblAnterior.Hide();
            lblCodigoAlerta.Hide();

            cBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxModelo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void AddItem(string descripcionCabina)
        {
            //get a reference to the previous existent 
            RowStyle temp = superTabla.RowStyles[superTabla.RowCount - 1];
            //increase panel rows count by one
            superTabla.RowCount++;
            //add a new RowStyle as a copy of the previous one
            superTabla.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            superTabla.Controls.Add(new Label() { Text = descripcionCabina }, 0, superTabla.RowCount - 1);
            Button m = new Button();
            m.Name = "0" + (superTabla.RowCount - 1);
            m.Text = "-";
            m.Height = 20;
            m.Width = 20;
            m.Click += M_Click;
            superTabla.Controls.Add(m, 1, superTabla.RowCount - 1);

            superTabla.Controls.Add(new Label() { Text = "0" }, 2, superTabla.RowCount - 1);

            Button p = new Button();
            p.Name = "2" + (superTabla.RowCount - 1);
            p.Text = "+";
            p.Height = 20;
            p.Width = 20;
            p.Click += P_Click;
            superTabla.Controls.Add(p, 3, superTabla.RowCount - 1);
        }
        private void P_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            TableLayoutPanelCellPosition a = superTabla.GetPositionFromControl(b);
            int c = Convert.ToInt32(superTabla.GetControlFromPosition(a.Column - 1, a.Row).Text) + 1;
            superTabla.GetControlFromPosition(a.Column - 1, a.Row).Text = "" + c;
            guardarTabla();
        }
        private void guardarTabla()
        {
            nodoCabina n;
            if (cabinas.Count <= piso)
            {
                n = new nodoCabina();
                for (int i = 0; i < superTabla.RowCount - 1; i++)
                {
                    n.cabinas.Add(Convert.ToInt32(superTabla.GetControlFromPosition(2, i + 1).Text));
                    n.piso = piso;
                }
                cabinas.Add(n);
                debugger.log("Se agrego piso:" + n.piso + ":" + piso + "\nCabina estandar:" + n.cabinas[0] + "\nCabina Exterior:" + n.cabinas[1] + "\nSuite:" + n.cabinas[2] + "\nCabina Balcón:" + n.cabinas[3] + "\nEjecutivo" + n.cabinas[4]);
            }
            else
            {
                n = cabinas[piso];
                for (int i = 0; i < superTabla.RowCount - 1; i++)
                {
                    n.cabinas[i] = Convert.ToInt32(superTabla.GetControlFromPosition(2, i + 1).Text);
                    n.piso = piso;
                }
                debugger.log("Se modifico piso:" + n.piso + ":" + piso + "\nCabina estandar:" + n.cabinas[0] + "\nCabina Exterior:" + n.cabinas[1] + "\nSuite:" + n.cabinas[2] + "\nCabina Balcón:" + n.cabinas[3] + "\nEjecutivo" + n.cabinas[4]);
            }

        }
        private void cargarTabla()
        {
            for (int i = 0; i < superTabla.RowCount - 1; i++)
            {
                superTabla.GetControlFromPosition(2, i + 1).Text = cabinas[piso].cabinas[i].ToString();
                debugger.log("Se cargo piso:" + piso + " cabi_codigo:" + i + " cabi_cantidad" + cabinas[piso].cabinas[i].ToString());
            }
        }
        private void limpiarTabla()
        {
            for (int i = 0; i < superTabla.RowCount - 1; i++)
            {
                superTabla.GetControlFromPosition(2, i + 1).Text = "0";
            }
        }
        private void M_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            TableLayoutPanelCellPosition a = superTabla.GetPositionFromControl(b);
            int c = Convert.ToInt32(superTabla.GetControlFromPosition(a.Column + 1, a.Row).Text) - 1;
            if (c >= 0)
            {
                superTabla.GetControlFromPosition(a.Column + 1, a.Row).Text = "" + c;
                guardarTabla();
            }
        }

        private void imprimir(List<int> c)
        {
            Console.Write("\n");
            foreach (int i in c)
                Console.Write(i + ",");
        }
        private void llenarCB(ComboBox cb, DataTable source, string columna)
        {
            foreach (DataRow marca in source.Rows)
                cb.Items.Add(marca[columna]);
        }

        private void llblSiguiente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guardarTabla();
            piso++;

            limpiarTabla();
            llblAnterior.Show();
            lblPiso.Text = "" + piso;
            if (piso > cantPisos)
            {
                cantPisos++;
                lblPiso.Text += "/" + cantPisos;
                //crear piso. Preservar flowchart y hacer un clear del flowchart. piso++ y lblPiso=piso;
            }
            else if (piso <= cantPisos)
            {
                cargarTabla();
                //cargar flowchart listaFlowchart.ElementAt[piso++]
            }
        }

        private void llblAnterior_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guardarTabla();
            piso--;
            cargarTabla();
            lblPiso.Text = "" + piso;
            if (piso == 0)
            {
                llblAnterior.Hide();
                lblPiso.Text += "/" + cantPisos;
            }
            else
            {
                lblPiso.Text += "/" + cantPisos;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cBoxMarca.Text = "";
            cBoxModelo.Text = "";
            cBoxModelo.Enabled = false;

            for (int i = 0; i < superTabla.RowCount - 1; i++)
            {
                superTabla.GetControlFromPosition(2, i + 1).Text = "0";
            }

            superTabla.Enabled = false;
            cantPisos = 0;
        }

        private void cBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxModelo.Enabled = true;
        }

        private void cBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            superTabla.Enabled = true;
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            debugger.log(string.Format("Codigo:{0} Marca:{1} Modelo:{2} CantidadCabinas:{3}", textBox1.Text, cBoxMarca.Text, cBoxModelo.Text, contarCabinas()));
            if (abm.crearCrucero(textBox1.Text, cBoxMarca.Text, cBoxModelo.Text, contarCabinas(), dateTimePicker1.Value) == 1)
            {
                foreach (nodoCabina a in cabinas)
                {
                    string log = "piso:" + a.piso;
                    int numero = 0;
                    string[] cabs = { "Cabina Estandar", "Cabina Exterior", "Suite", "Cabina Balcón", "Ejecutivo" };
                    for (int i = 0; i <= a.cabinas.Count - 1; i++)
                    {
                        log += string.Format(" {0}:{1}", cabs[i], a.cabinas[i]);
                        for(int j=0;j<=a.cabinas[i]-1;j++)
                        {
                            abm.agregarCabinaAUnCrucero(textBox1.Text, numero, a.piso, cabs[i]);
                            numero++;
                        }
                    }
                    debugger.log(log);
                }
                MessageBox.Show(string.Format("El crucero '{0}' se ha creado con exito", textBox1.Text), "FRBACruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(string.Format("Ya existe:{0}", textBox1.Text), "FRBACruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int contarCabinas()
        {
            int contador = 0;
            foreach (nodoCabina a in cabinas)
            {
                for (int i = 0; i <= a.cabinas.Count - 1; i++)
                {
                    contador += a.cabinas[i];
                }
            }
            return contador;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Z]{6}-[0-9]{5}$").IsMatch(textBox1.Text))
            {
                textBox1.ForeColor = Color.Black;
                lblCodigoAlerta.Show();
                lblCodigoAlerta.Text = checkmark;
                cBoxMarca.Enabled = true;
            }
            else
            {
                textBox1.ForeColor = Color.Red;
            }
        }
    }
}
