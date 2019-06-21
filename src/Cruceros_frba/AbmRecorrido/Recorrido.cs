using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public class TramoElegido
    {
        public int codigoTramo { get; set; }
        public Decimal precio { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public TramoElegido(int _codigoTramo, string _origen, string _destino, Decimal _precio)
        {
            codigoTramo = _codigoTramo;
            precio = _precio;
            origen = _origen;
            destino = _destino;
        }
    }
    static class Tramo
    {
        public static string tabla = "[GD1C2019].[FIDEOS_CON_TUCO].[Tramo]";
        public static string codigo = "tram_codigo";
        public static string origen = "tram_puerto_origen";
        public static string destino = "tram_puerto_destino";
        public static string precio = "tram_precio";
    }
    class Puerto
    {
        public static string tabla = "[GD1C2019].[FIDEOS_CON_TUCO].[Puerto]";
        public static string codigo = "puer_codigo";
        public static string descripcion = "puer_descripcion";
        public static string ciudad = "puer_ciudad";
        public static string habilitado = "puer_esta_habilitado";
    }
    class Recorrido
    {
        //Variable usada para recibir la respuesta del Stored Procedured de crearPuerto, funciona como variable de salida
        private int respuesta;

        //Getter y setter de la variable
        public int getRespuesta() { return respuesta; }
        public void setRespuesta(int numero) { this.respuesta = numero; }

        #region Constructor
        public Recorrido()
        {
        }
        #endregion

        #region crearRecorrido
        public int crearRecorrido(string ciudadPuertoOrigen, string ciudadPuertoDestino, Decimal precio)
        {
            string SPR = "agregarRecorrido";
            object[] ARGUMENT = { SPR,"@resultado", "@ciudadPuertoOrigen", ciudadPuertoOrigen, "@ciudadPuertoDestino", ciudadPuertoDestino, "@precio", precio};
            respuesta=Coneccion.ejecutarSPR(ARGUMENT);
            return respuesta;
        }
        #endregion

        #region deshabilitarRecorrido
        public void deshabilitarRecorrido(int idRecorrido)
        {
            Coneccion.ejecutarSPV("deshabilitarRecorrido", "@idRecorrido", idRecorrido);
        }
        #endregion

        #region habilitarRecorrido
        public int habilitarRecorrido(int idRecorrido)
        {
            return Coneccion.ejecutarSPR("habilitarRecorrido","@resultado", "@idRecorrido", idRecorrido);
        }
        #endregion

        #region modificarRecorrido

        public void modificarRecorrido(int idRecorrido, string ciudadPuertoOrigen, string ciudadPuertoDestino, decimal precio)
        {
            Coneccion.ejecutarSPV("modificarRecorrido", "@idRecorrido", idRecorrido, "@ciudadPuertoOrigen", ciudadPuertoOrigen, "@ciudadPuertoDestino", ciudadPuertoDestino, "@precio", precio);
        }
        #endregion

        #region mostrarRecorrido
        public DataTable mostrarRecorrido()
        {
            DataTable dt = new DataTable();
            string SP = "mostrarRecorridos";
            object[] ARGUMENT = { SP};
            return Coneccion.ejecutarSP(ARGUMENT);
        }
        #endregion

        #region mostrarRecorridosHabilitados
        public DataTable mostrarRecorridosHabilitados()
        {
            DataTable dt = new DataTable();
            string SP = "mostrarRecorridosHabilitados";
            object[] ARGUMENT = {SP};
            return Coneccion.ejecutarSP(ARGUMENT);
        }
        #endregion

        #region mostrarRecorridosDeshabilitados
        public DataTable mostrarRecorridosDeshabilitados()
        {
            DataTable dt = new DataTable();
            string SP = "mostrarRecorridosDeshabilitados";
            object[] ARGUMENT = { SP };
            return Coneccion.ejecutarSP(ARGUMENT);
        }
        #endregion

        #region agregarTramoAUnRecorrido
        public void agregarTramoAUnRecorrido(string ciudadPuertoOrigen,string ciudadPuertoDestino,Decimal precio, int idRecorrido)
        {
            string SP = "agregarTramoAUnRecorrido";
            object[] ARGUMENT = { SP, "@ciudadPuertoOrigen", ciudadPuertoOrigen, "@ciudadPuertoDestino", ciudadPuertoDestino, "@precio", precio, "@idRecorrido", idRecorrido };
            Coneccion.ejecutarSP(ARGUMENT);
        }
        #endregion

        #region eliminarTramoDeUnRecorrido
        public void eliminarTramoDeUnRecorrido(string ciudadPuertoOrigen, string ciudadPuertoDestino, int idRecorrido)
        {
            string SP = "eliminarTramoDeUnRecorrido";
            object[] ARGUMENT = { SP,"@ciudadPuertoOrigen",ciudadPuertoOrigen,"@ciudadPuertoDestino",ciudadPuertoDestino, "@idRecorrido", idRecorrido };
            Coneccion.ejecutarSP(ARGUMENT);
        }
        #endregion

        #region mostrarTramosExistentes
        public DataTable mostrarTramosExistentes()
        {
            string SLCT = "SELECT tram_codigo as Codigo, P1.puer_ciudad as Origen, P2.puer_ciudad as Destino, tram_precio as Precio";
            SLCT += " FROM " + Tramo.tabla + " join " + Puerto.tabla + " as P1 on (" + Tramo.origen + " = P1." + Puerto.codigo + ")";
            SLCT += " join " + Puerto.tabla + " as P2" + " on(" + Tramo.destino + " = P2." + Puerto.codigo + ")";
            object[] ARGUMENT = {  SLCT };
            DataTable dt;
            dt = Coneccion.ejecutarSelect(ARGUMENT);
            return dt;
        }
        #endregion
        
        #region mostrarTramosDeUnRecorrido
        public DataTable mostrarTramosDeUnRecorrido(int idRecorrido)
        {
            return Coneccion.ejecutarSP("mostrarTramosDeUnRecorrido", "@idRecorrido", idRecorrido);
        }
        #endregion
        public void agregarTramo(string puertoOrigen, string puertoDestino, decimal precio) {
            Coneccion.ejecutarSPV("agregarTramo", "@ciudadPuertoOrigen", puertoOrigen
                , "@ciudadPuertoDestino", puertoDestino, "@precio", precio);
        }

    }
}
