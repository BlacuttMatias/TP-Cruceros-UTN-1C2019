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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class frmABMRecorridoModificarSeleccionado : Form
    {
        int ID = 0;
        string Origen = "";
        string Destino = "";
        Decimal Precio = 0;
        bool habilitado = false;
        bool filtroElProceso = false;
        string filtroOrigen = "";
        string filtroDestino = "";
        string filtro = "";

        Recorrido abm = new Recorrido();
        List<TramoElegido> listaTramos = new List<TramoElegido>();
        List<TramoElegido> listaViejos = new List<TramoElegido>();
        DataTable misTramos;
        DataTable nuevosTramos;
        TramoElegido tramo;
        public frmABMRecorridoModificarSeleccionado(params object[] args)
        {
            InitializeComponent();
            btnCrearTramo.Enabled = false;
            checkBox1.Checked = false;
            ID = Convert.ToInt32(args[0].ToString());
            label1.Text = "ID:" + ID;
            Origen = args[1].ToString();
            lblOrigen.Text = "Origen:" + Origen;
            Destino = args[2].ToString();
            lblDestino.Text = "Destino:" + Destino;
            Precio = Convert.ToDecimal(args[3].ToString());
            if (args[4].ToString() == "SI")
                checkBox1.Checked = true;
            Load += new EventHandler(FrmABMRecorridoModificarSeleccionado_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            txtBoxFiltroDestino.TextChanged += new EventHandler(txtBoxFiltroDestino_TextChanged);
            txtBoxFiltroOrigen.TextChanged += new EventHandler(txtBoxFiltroOrigen_TextChanged);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dataGridView1.Rows[e.RowIndex];
                listaTramos.Add(new TramoElegido(Convert.ToInt32(Row.Cells["Codigo"].Value.ToString()),
                                                Row.Cells["Origen"].Value.ToString(),
                                                Row.Cells["Destino"].Value.ToString(),
                                                Convert.ToDecimal(Row.Cells["Precio"].Value.ToString())));

                listBox2.Items.Add(Row.Cells["Origen"].Value.ToString() +
                                    " - " + Row.Cells["Destino"].Value.ToString());
                if (listaTramos.Count != 0)
                {
                    TramoElegido a = listaTramos.ElementAt(0);
                    TramoElegido b = listaTramos.ElementAt(listaTramos.Count - 1);
                    lblOrigen.Text = "Origen:" + a.origen;
                    lblDestino.Text = "Desinto:" + b.destino;
                    filtroElProceso = true;
                    txtBoxFiltroOrigen.Text = b.destino;
                    txtBoxFiltroOrigen.ReadOnly = true;
                    filtroOrigen = b.destino;
                    filtroDestino = txtBoxFiltroDestino.Text;
                    actualizarFiltro();
                    Precio += b.precio;
                    lblPrecio.Text = "Precio:" + Precio;
                }
            }

            //listBox1.Items.
        }

        private void FrmABMRecorridoModificarSeleccionado_Load(object sender, EventArgs e)
        {
            //string SLCT = "SELECT tram_codigo as Codigo, P1." + Puerto.ciudad + " as Origen, P2." + Puerto.ciudad + " as Destino," + Tramo.precio + " as Precio";
            //SLCT += " FROM " + Tramo.tabla + " join [GD1C2019].[FIDEOS_CON_TUCO].[Tramos_por_recorrido] on (tram_por_reco_tramo=" + Tramo.codigo + ")";
            //SLCT += " join " + Puerto.tabla + " as P1 on (P1." + Puerto.codigo + "=" + Tramo.origen + ")";
            //SLCT += " join " + Puerto.tabla + " as P2 on (P2." + Puerto.codigo + "=" + Tramo.destino + ")";
            //SLCT += " WHERE tram_por_reco_recorrido= @ID";
            //misTramos = Coneccion.ejecutarSelect(SLCT, "@ID", ID);
            misTramos = abm.mostrarTramosDeUnRecorrido(ID);
            dataGridView1.DataSource = misTramos;

            dataGridView1.Enabled = false;
            nuevosTramos = abm.mostrarTramosExistentes();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Recorrido abm = new Recorrido();
            if (listaViejos.Count > 0)
            {
                foreach (TramoElegido t in listaViejos)
                    abm.eliminarTramoDeUnRecorrido(t.origen, t.destino, ID);
            }
            if (listaTramos.Count > 0)
            {
                abm.modificarRecorrido(ID, listaTramos.ElementAt(0).origen, listaTramos.ElementAt(listaTramos.Count - 1).destino, Precio);
                foreach (TramoElegido t in listaTramos)
                    abm.agregarTramoAUnRecorrido(t.origen, t.destino, t.precio, ID);
                this.Close();
            }
            if (checkBox1.Checked)
                abm.habilitarRecorrido(ID);
            else
                abm.deshabilitarRecorrido(ID);
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > listaViejos.Count)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    listaViejos.Add(new TramoElegido(Convert.ToInt32(r.Cells["Codigo"].Value.ToString()),
                                                    r.Cells["Origen"].Value.ToString(),
                                                    r.Cells["Destino"].Value.ToString(),
                                                    Convert.ToDecimal(r.Cells["Precio"].Value.ToString())));
                }

                foreach (TramoElegido t in listaViejos)
                {
                    listBox1.Items.Add(t.origen + " - " + t.destino);
                }

            }
            Precio = 0;
            listBox1.Enabled = false;
            btnCrearTramo.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView1.DataSource = nuevosTramos;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaTramos.Count - 1 >= 0)
            {
                Precio = Precio - listaTramos.ElementAt(listaTramos.Count - 1).precio;
                //lblPrecio.Text = "Precio:" + Precio;
                listaTramos.RemoveAt(listaTramos.Count - 1);
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
                if (listaTramos.Count == 0)
                {
                    Limpiar();
                }
                else
                {
                    TramoElegido Ultimotramo = listaTramos.Last();
                    txtBoxFiltroOrigen.Text = Ultimotramo.destino;
                    filtroOrigen = Ultimotramo.destino;
                    actualizarFiltro();
                }
            }
        }
        private void Limpiar()
        {
            nuevosTramos.DefaultView.RowFilter = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listaTramos.Clear();
            lblOrigen.Text = "Origen:";
            lblDestino.Text = "Desinto:";
            Precio = 0;
            txtBoxFiltroDestino.Clear();
            txtBoxFiltroOrigen.Clear();
            txtBoxFiltroOrigen.ReadOnly = false;
        }
        private void actualizarFiltro()
        {
            filtro = string.Format("Origen Like '%{0}%'", filtroOrigen);
            filtro += string.Format("And Destino Like '%{0}%'", filtroDestino);
            misTramos.DefaultView.RowFilter = filtro;
            nuevosTramos.DefaultView.RowFilter = filtro;
        }

        private void txtBoxFiltroOrigen_TextChanged(object sender, EventArgs e)
        {
            if (listaTramos.Count == 0 || filtroElProceso)
            {
                filtroOrigen = txtBoxFiltroOrigen.Text;
                actualizarFiltro();
            }
            //else
            //{
            //    MessageBox.Show("No puede cambiarse el Origen si ya se seleccionaron Tramos.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            filtroElProceso = false;
        }

        private void txtBoxFiltroDestino_TextChanged(object sender, EventArgs e)
        {
            filtroDestino = txtBoxFiltroDestino.Text;
            actualizarFiltro();
        }

        private void btnCrearTramo_Click(object sender, EventArgs e)
        {
            tramo = new TramoElegido(0, txtBoxFiltroOrigen.Text, "", 0);
            frmNuevoTramo nuevoTramo = new frmNuevoTramo(ref tramo);
            nuevoTramo.Show();
            this.Enabled = false;
            nuevoTramo.FormClosing += NuevoTramo_FormClosing; ;
        }

        private void NuevoTramo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            if (tramo.origen != "" && tramo.destino != "" && tramo.precio != 0)
            {
                listBox2.Items.Add(tramo.origen + "-" + tramo.destino); //DIZ NUTTZ
                listaTramos.Add(tramo);//Tendria que chequar que no esten vacios los valores.
                filtroElProceso = true;
                txtBoxFiltroOrigen.Text = tramo.destino;
                Precio += tramo.precio;
                lblPrecio.Text = "Precio:" + Precio;
                filtroOrigen = tramo.destino;
                nuevosTramos = abm.mostrarTramosExistentes();
            }
        }
    }
}
