using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.GeneracionViaje
{
    class DatosViaje
    {
        public DataTable mostrarRecorridosDisponibles() {
            return Coneccion.ejecutarSP("mostrarPuertosDeUnRecorrido");
        }

        public DataTable mostrarCrucerosDisponiblesEnEsasFechas(DateTime fechaInicio, DateTime fechaFin) {
            return Coneccion.ejecutarSP("mostrarCrucerosParaUnViaje", "@fechaInicio", fechaInicio
                , "@fechaFin", fechaFin);
        }
    }
}
