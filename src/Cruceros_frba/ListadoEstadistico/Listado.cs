using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    class Listado
    {
        public DataTable mostrarLosCincoRecorridosConMasPasajesComprados(int anio, int semestre) {
            return Coneccion.ejecutarSP("mostrarLosCincoRecorridosConMasPasajesComprados"
                , "@anio", anio, "@semestre", semestre);
        }

        public DataTable mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje(int anio, int semestre) {
            return Coneccion.ejecutarSP("mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje"
                , "@anio", anio, "@semestre", semestre);
        }
        public DataTable mostrarLosCincoCrucerosConMasDiasFueraDeServicio(int anio, int semestre) {
            return Coneccion.ejecutarSP("mostrarLosCincoCrucerosConMasDiasFueraDeServicio"
                , "@anio", anio, "@semestre", semestre);
        }
    }
}
