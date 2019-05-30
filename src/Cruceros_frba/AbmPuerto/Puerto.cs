using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    class Puerto
    {
        #region Constructor
        public Puerto()
        {
        }
        #endregion

        #region crearPuerto
        public int crearPuerto(string ciudad,string _descripcion)
        {
            return Coneccion.ejecutarSPR("agregarPuerto", "@resultado", "@ciudad", ciudad, "@descripcion",_descripcion);
        }
        #endregion

        #region deshabilitarPuerto
        public void deshabilitarPuerto(int codigo)
        {
            Coneccion.ejecutarSPV("deshabilitarPuerto", "@codigoPuerto", codigo);
        }
        #endregion

        #region habilitarPuerto
        public void habilitarPuerto(int codigo)
        {
            Coneccion.ejecutarSPV("habilitarPuerto", "@codigoPuerto", codigo);
        }
        #endregion

        #region modificarPuerto
        public void modificarPuerto(int codigo, string ciudad,string descripcion)
        {
            Coneccion.ejecutarSPV("modificarPuerto", "@codigoPuerto", codigo, "@ciudad", ciudad, "@descripcion", descripcion);
        }
        #endregion

        #region mostrarPuertos
        public DataTable mostrarPuertos()
        {
            return Coneccion.ejecutarSP("mostrarPuertos");
        }
        #endregion

        #region mostrarPuertosHabilitados
        public DataTable mostrarPuertosHabilitados()
        {
            return Coneccion.ejecutarSP("mostrarPuertosHabilitados");
        }
        #endregion

        #region mostrarPuertosDeshabilitados
        public DataTable mostrarPuertosDeshabilitados()
        {
            return Coneccion.ejecutarSP("mostrarPuertosDeshabilitados");
        }
        #endregion
    }
}
