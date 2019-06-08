using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.PagoReserva
{
    class DatosPagoReserva
    {
        public int obtenerPasajeDeUnaReserva(int codigoReserva) {
            return Coneccion.ejecutarFunction("pasajedeUnaReserva(@codigoReserva)"
                , "@codigoReserva", codigoReserva);
        }
    }
}
