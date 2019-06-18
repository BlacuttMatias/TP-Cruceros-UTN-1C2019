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
    public partial class frmAltaRecorrido : Form
    {
        Decimal precio;
        DataTable dt = new DataTable();
        string filtroOrigen = "";
        string filtroDestino = "";
        string filtro = "";
        bool filtroElProceso = false;
        
        
        List<TramoElegido> listaTramos = new List<TramoElegido>();
        TramoElegido tramo;
        public frmAltaRecorrido()
        {
            InitializeComponent();
            #region Eventos
            Load += new EventHandler(frmAltaRecorrido_Load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            txtBoxFiltroDestino.TextChanged += new EventHandler(txtBoxFiltroDestino_TextChanged);
            txtBoxFiltroOrigen.TextChanged += new EventHandler(txtBoxFiltro_TextChanged);
            #endregion
        }
        private void frmAltaRecorrido_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Recorrido abm = new Recorrido();
            dt = abm.mostrarTramosExistentes();
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows.Count == 0)
            {
                this.Close();
            }
            precio = 0;
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
                
                listBox1.Items.Add(Row.Cells["Origen"].Value.ToString()+
                                    " - "+Row.Cells["Destino"].Value.ToString());
                if(listaTramos.Count != 0)
                {
                    TramoElegido a = listaTramos.ElementAt(0);
                    TramoElegido b = listaTramos.ElementAt(listaTramos.Count-1);
                    lblOrigen.Text = "Origen:" + a.origen;
                    lblDestino.Text = "Desinto:" + b.destino;
                    filtroElProceso = true;
                    txtBoxFiltroOrigen.Text = b.destino;
                    txtBoxFiltroOrigen.ReadOnly = true;
                    filtroOrigen = b.destino;
                    filtroDestino = txtBoxFiltroDestino.Text;
                    filtro = string.Format("{0} Like '%{1}%'", "Origen", filtroOrigen);
                    filtro += string.Format("And {0} Like '%{1}%'", "Destino", filtroDestino);
                    dt.DefaultView.RowFilter = filtro;
                    precio += b.precio;
                    lblPrecio.Text = "Precio:"+precio;
                }

            }
        }
        private void Limpiar()
        {
            dt.DefaultView.RowFilter = "";
            listBox1.Items.Clear();
            listaTramos.Clear();
            lblOrigen.Text = "Origen:";
            lblDestino.Text = "Desinto:";
            precio = 0;
            txtBoxFiltroDestino.Clear();
            txtBoxFiltroOrigen.Clear();
            txtBoxFiltroOrigen.ReadOnly = false;
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listaTramos.Count-1 >= 0)
            {
                precio = precio - listaTramos.ElementAt(listaTramos.Count - 1).precio;
                lblPrecio.Text= "Precio:" + precio;
                listaTramos.RemoveAt(listaTramos.Count - 1);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                if (listaTramos.Count == 0)
                {
                    Limpiar();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Recorrido abm = new Recorrido();
            int idRecorrido = -1;
            idRecorrido = abm.crearRecorrido(listaTramos.ElementAt(0).origen, listaTramos.ElementAt(listaTramos.Count-1).destino, precio);
            Debugger debugger = new Debugger();
            debugger.log("idRecorrido:" + idRecorrido+" Origen:" + listaTramos.ElementAt(0).origen + " Destino:"+ listaTramos.ElementAt(listaTramos.Count - 1).destino+" Precio:"+precio);
            //debugger.Show();
            if (idRecorrido != 0)
            {
                MessageBox.Show("Su recorrido se ha generado con éxito", "FrbaCruceros", MessageBoxButtons.OK);
                foreach (TramoElegido t in listaTramos)
                {
                    abm.agregarTramoAUnRecorrido(t.origen, t.destino, t.precio, idRecorrido);
                    debugger.log("Origen:" + t.origen + " Destino:" + t.destino + " Precio:" + t.precio + " idRecorrido:" + idRecorrido);
                }
            }
            else if (idRecorrido == 0)
            {
                MessageBox.Show("No se inserto el Recorrido, porque ya existe uno con ese origen, destino y precio", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                //debugger.QSP1("FIDEOS_CON_TUCO.mostrarRecorridos");
                //debugger.QSP2("FIDEOS_CON_TUCO.mostrarTramosDeUnRecorrido", "@idRecorrido", idRecorrido);
                //debugger.QQ1("SELECT P1.puer_ciudad, P2.puer_ciudad FROM [FIDEOS_CON_TUCO].[Tramo] join [FIDEOS_CON_TUCO].[Puerto] as P1 on([tram_puerto_origen] = P1.[puer_codigo]) join [FIDEOS_CON_TUCO].[Puerto] as P2 on([tram_puerto_origen] = P2.[puer_codigo])");
            }

        }

        private void btnCrearTramo_Click(object sender, EventArgs e)
        {
            tramo = new TramoElegido(0, txtBoxFiltroOrigen.Text, "", 0);
            frmNuevoTramo nuevoTramo = new frmNuevoTramo(ref tramo);
            nuevoTramo.Show();
            this.Enabled = false;
            nuevoTramo.FormClosing += NuevoTramo_FormClosing;
        }

        private void NuevoTramo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            if(tramo.origen !="" && tramo.destino != "" && tramo.precio != 0)
            {
                Recorrido abm = new Recorrido();
                dt = abm.mostrarTramosExistentes();
                dataGridView1.DataSource = dt;
                listBox1.Items.Add(tramo.origen + "-" + tramo.destino); //DIZ NUTTZ
                listaTramos.Add(tramo);//Tendria que chequar que no esten vacios los valores.
                filtroElProceso = true;
                txtBoxFiltroOrigen.Text = tramo.destino;
                precio += tramo.precio;
                lblPrecio.Text = "Precio:" + precio;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (listaTramos.Count == 0 || filtroElProceso)
            {
                filtroOrigen = txtBoxFiltroOrigen.Text;
                filtro = string.Format("{0} Like '%{1}%'", "Origen", filtroOrigen);
                filtro += string.Format("And {0} Like '%{1}%'", "Destino", filtroDestino);
                dt.DefaultView.RowFilter = filtro;
            }
            else
            {
                MessageBox.Show("No puede cambiarse el Origen si ya se seleccionaron Tramos.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            filtroElProceso = false;
        }

        private void txtBoxFiltroDestino_TextChanged(object sender, EventArgs e)
        {
            filtroDestino = txtBoxFiltroDestino.Text;
            filtro = string.Format("{0} Like '%{1}%'", "Origen", filtroOrigen);
            filtro += string.Format("And {0} Like '%{1}%'", "Destino", filtroDestino);
            dt.DefaultView.RowFilter = filtro;
        }
        
    }
}
