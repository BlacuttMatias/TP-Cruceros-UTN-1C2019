using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class Debugger : Form
    {
        bool la_cague = false;
        DataTable dtStockProcedure1 = new DataTable();
        DataTable dtStockProcedure2 = new DataTable();
        DataTable dtQuerry1 = new DataTable();
        DataTable dtQuerry2 = new DataTable();
        public Debugger()
        {
            InitializeComponent();
        }
        public void Agregar(string origen,string destino, Decimal precio, int idRecorrido)
        {
           
            //txtDebugger.Text += Environment.NewLine + "EXEC agregarTramoAUnRecorrido " + origen + " ," + destino + " ," + precio + ", " + idRecorrido;
            #region tabSelect1
            string selectIdOrigen = string.Format("SELECT puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = '{0}'",origen);
            string selectIdDestino = string.Format("SELECT puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = '{0}'",destino);
            dtStockProcedure1 = QQ(selectIdOrigen);
            dataGridOrigen.DataSource = dtStockProcedure1;
            int codigoPuertoOrigen=-1;
            DataGridViewRow Fila = this.dataGridOrigen.Rows[0];
            codigoPuertoOrigen = Convert.ToInt32(Fila.Cells["puer_codigo"].Value.ToString());


            
            dtStockProcedure2 = QQ(selectIdDestino);
            dataGridDestino.DataSource = dtStockProcedure2;
            int codigoPuertoDestino=-1;
            Fila = this.dataGridDestino.Rows[0];
            codigoPuertoDestino = Convert.ToInt32(Fila.Cells["puer_codigo"].Value.ToString());

            #endregion

            #region tabSelect2
            
            string selectExiste = string.Format("SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = {0} AND tram_puerto_destino = {1}", codigoPuertoOrigen, codigoPuertoDestino);
            dtQuerry1 = QQ(selectExiste);
            dataGridExisteTramo.DataSource = dtQuerry1;

            string insertTramo = "INSERT INTO [FIDEOS_CON_TUCO].[Tramo] ([tram_puerto_origen], [tram_puerto_destino], [tram_precio]) VALUES (@tram_puerto_origen, @tram_puerto_destino, @tram_precio)";
            III(insertTramo, codigoPuertoOrigen, codigoPuertoDestino,precio);


            string selectCodigoTramo = string.Format("SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = {0} AND tram_puerto_destino = {1}", codigoPuertoOrigen, codigoPuertoDestino);
            
            dtQuerry2 = QQ(selectCodigoTramo);
            dataGridCodigoTramo.DataSource = dtQuerry2;
            if(dataGridCodigoTramo.Rows.Count>0)
            {
                Fila = this.dataGridCodigoTramo.Rows[0];
                int codigotram_codigo = -1;
                if (Fila.Cells["tram_codigo"].Value != null)
                    codigotram_codigo = Convert.ToInt32(Fila.Cells["tram_codigo"].Value.ToString());
                else
                    log("Null Row");
                string insertTramoXReco = "INSERT INTO FIDEOS_CON_TUCO.Tramos_por_recorrido (tram_por_reco_tramo, tram_por_reco_recorrido) VALUES (@tram_por_reco_tramo, @tram_por_reco_recorrido)";
                II(insertTramoXReco, codigotram_codigo, idRecorrido);
            }
            #endregion

            #region tabSelect3
            //"INSERT INTO FIDEOS_CON_TUCO.Tramos_por_recorrido(tram_por_reco_tramo, tram_por_reco_recorrido) VALUES(@codigoTramo, @idRecorrido)"
            #endregion
            string selectExtra = string.Format("SELECT * FROM FIDEOS_CON_TUCO.Tramos_por_recorrido");
            DataTable dtExtra = new DataTable();
            dtExtra = QQ(selectExtra);
            dataGridExtra.DataSource = dtExtra;
        }
        public void log(string log)
        {
            txtDebugger.Text += Environment.NewLine + log;
        }
        public DataTable QQ(string queryString)
        {
            DataTable DtResultado = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, Coneccion.Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            try
            {
                dataAdapter.Fill(DtResultado);
                log(queryString);
            }
            catch (Exception)
            {
                la_cague = true;
                log("ERROR EN:" + queryString);
            }
            return DtResultado;
        }
        public void III(string queryString,int a,int b,Decimal c)
        {
            try
            {
                //tram_puerto_origen, tram_puerto_destino, tram_precio
                SqlConnection coneccion = new SqlConnection(Coneccion.Con);
                SqlCommand cmd = new SqlCommand(queryString, coneccion);
                cmd.Parameters.AddWithValue("@tram_puerto_origen", a);
                cmd.Parameters.AddWithValue("@tram_puerto_destino", b);
                cmd.Parameters.AddWithValue("@tram_precio", c);
                coneccion.Open();
                cmd.ExecuteReader();
            }
            catch (Exception)
            {
                log("Error III " +a+";"+b+";"+c);
            }
            txtDebugger.Text += Environment.NewLine + queryString;
        }
        public void II(string queryString, int a, int b)
        {
            try
            {
                //@tram_por_reco_tramo, @tram_por_reco_recorrido
                SqlConnection coneccion = new SqlConnection(Coneccion.Con);
                SqlCommand cmd = new SqlCommand(queryString, coneccion);
                cmd.Parameters.AddWithValue("@tram_por_reco_tramo", a);
                cmd.Parameters.AddWithValue("@tram_por_reco_recorrido", b);
                coneccion.Open();
                cmd.ExecuteReader();
            }
            catch (Exception)
            {
                log("Error II " +a+";"+b);
            }
            txtDebugger.Text += Environment.NewLine + queryString;
        }
        public static object InvokeMethod(Delegate QQ1, params object[] args)
        {
            return QQ1.DynamicInvoke(args);
        }
        public void QSP1(params object[] args)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Coneccion.Con;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = args[0].ToString();
            SqlCmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < args.Length-2; i++)
            {
                SqlCmd.Parameters.AddWithValue(args[i+1].ToString(), args[i+2]);
            }
            SqlCon.Open();
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(dtStockProcedure1);
            dataGridOrigen.DataSource = dtStockProcedure1;
        }
        public void QSP2(params object[] args)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Coneccion.Con;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = args[0].ToString();
            SqlCmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < args.Length - 2; i++)
            {
                SqlCmd.Parameters.AddWithValue(args[i + 1].ToString(), args[i + 2]);
            }
            SqlCon.Open();
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(dtStockProcedure2);
            dataGridDestino.DataSource = dtStockProcedure2;
        }
        //"SELECT puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @puer_ciudad"
        public void QQ1(params object[] args)
        {
            SqlConnection coneccion = new SqlConnection(Coneccion.Con);
            SqlCommand cmd = new SqlCommand(args[0].ToString(), coneccion);
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1].ToString(), args[i + 2]);
            }
            coneccion.Open();
            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(dtQuerry1);
            dataGridExisteTramo.DataSource = dtQuerry1;
        }
        public void QQ2(params object[] args)
        {
            SqlConnection coneccion = new SqlConnection(Coneccion.Con);
            SqlCommand cmd = new SqlCommand(args[0].ToString(), coneccion);
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1].ToString(), args[i + 2]);
            }
            coneccion.Open();
            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(dtQuerry2);
            dataGridExisteTramo.DataSource = dtQuerry2;
        }
    }
}
