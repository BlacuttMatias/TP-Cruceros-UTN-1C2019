using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace FrbaCrucero.AbmRol
{
    public class Rol
    {
        #region Constructor
        public Rol()
        {
        }
        #endregion

        #region Crear un Rol
        public int crearRol(String nombre)
        {
            return Coneccion.ejecutarSPR("agregarRol","@flag", "@rolAgregar", nombre);
        }
        #endregion

        #region Obtener las Funcionalidades NO asignadas a un Rol
        public DataTable getFuncionalidades(String nombreRol)
        {
            return Coneccion.ejecutarSP("mostrarFuncionalidadesNoAgregadasARol", "@nombreRol", nombreRol); 
        }
        #endregion

        #region Obtener las Funcionalidades asignadas a un Rol
        public DataTable getFuncionalidadesAsignadas(String nombreRol)
        {
            return Coneccion.ejecutarSP("mostrarFuncionalidadesAgregadasARol", "@nombreRol", nombreRol);
        }
        #endregion

        #region Asignar una Funcionalidad a un Rol
        public void agregarFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            Coneccion.ejecutarSPV("FIDEOS_CON_TUCO.AgregarFuncionalidadARol", "@nombreRol", nombreRol, "@funcionalidad", nombreFuncionalidad);
        }
        #endregion

        #region Quitar una Funcionalidad a un Rol
        public void eliminarFuncionalidadARol(int idRol, String nombreFuncionalidad)
        {
            Coneccion.ejecutarSPV("eliminarFuncionalidadARol", "@nombreFuncionalidad", nombreFuncionalidad, "@codigoRol", idRol);
        }
        #endregion

        #region Mostrar Roles
        public DataTable mostrarRoles()
        {
            return Coneccion.ejecutarSP("MostrarRoles");
        }
        #endregion

        #region Actualizar Nombre de Rol
        public void cambiarNombreRol(int id, String nombre)
        {
            Coneccion.ejecutarSPV("actualizarNombreRol", "@codigo", id, "@nombreRol", nombre);
        }
        #endregion

        #region Habilitar un rol
        public void habilitarRol(int id)
        {
            Coneccion.ejecutarSPV("habilitarRol", "@codigo", id);
        }
        #endregion

        #region Deshabilitar un rol
        public void deshabilitarRol(int id)
        {
            Coneccion.ejecutarSPV("deshabilitarRol", "@codigo", id);
        }
        #endregion

        #region Mostrar los roles habilitados
        public DataTable mostrarRolesHabilitados()
        {
            return Coneccion.ejecutarSP("mostrarRolesHabilitados");
        }
        #endregion


    }
}
