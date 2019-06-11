using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;



namespace FrbaCrucero.CompraReservaPasaje
{
    class GestionCompra
    {
        #region Buscar Viaje

        public DataTable buscarViajes(DateTime fechaPartida, String puertoOrigen, String puertoDestino){
         
             string SP = "mostrarViajesParaComprar";
             object[] ARGUMENT = {SP};
            return Coneccion.ejecutarSP(ARGUMENT, "@fechaInicio", fechaPartida, "@ciudadPuertoOrigen", puertoDestino, "@ciudadPuertoDestino", puertoDestino);

        }
        #endregion

        #region Buscar Viajes y Cabinas

        public DataTable filtrarViaje (DateTime fechaPartida, String puertoOrigen, String puertoDestino){
            
            return Coneccion.ejecutarSP("mostrarViajesParaComprar", "@fechaInicio", fechaPartida, "@ciudadPuertoOrigen", puertoOrigen, "@ciudadPuertoDestino", puertoDestino);
            
        }

        #endregion

        #region LLenar Grid Viajes 

        public DataTable llenarGrid()
        {

            String SLCT = "SELECT viaj_codigo AS Codigo," +
                 "PO.puer_ciudad as Origen," + 
                 "PD.puer_ciudad as Destino," +
                "viaj_fecha_inicio AS 'Fecha Inicio'," +
                "viaj_fecha_finalizacion_estimada AS 'Fecha Finalizacion'," +
                " cruc_cantidad_cabinas-(SELECT Count(pasa_viaje) FROM FIDEOS_CON_TUCO.Pasaje WHERE pasa_viaje=viaj_codigo) as 'Cabinas Disponibles'";
            SLCT += "FROM FIDEOS_CON_TUCO.Viaje " +
                    "JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = viaj_crucero)" +
                    "JOIN FIDEOS_CON_TUCO.Recorrido on (viaj_recorrido=reco_id)" +
                    "JOIN FIDEOS_CON_TUCO.Puerto as PO on (reco_puerto_origen=PO.puer_codigo)" +
                    "JOIN FIDEOS_CON_TUCO.Puerto as PD on (reco_puerto_destino=PD.puer_codigo)" +

                    "WHERE cruc_cantidad_cabinas > ( SELECT Count(pasa_viaje) FROM FIDEOS_CON_TUCO.Pasaje WHERE pasa_viaje=viaj_codigo)";

            DataTable dt = Coneccion.ejecutarSelect(SLCT);
            return dt;
        }

        #endregion

        #region Llenar Grid Cabinas

        public DataTable llenarGridCabinas(int codigoViaje)
        {
            return Coneccion.ejecutarSP("mostrarCabinasDisponiblesDeUnViaje", "@codigoViaje", codigoViaje);
        }
        #endregion

        public DataTable mostrarTodosLosViajesDisponibles() {
            return Coneccion.ejecutarSP("mostrarTodosLosViajesParaComprar", "@fechaSistema", Coneccion.getFechaSistema());
        }

    }
}
