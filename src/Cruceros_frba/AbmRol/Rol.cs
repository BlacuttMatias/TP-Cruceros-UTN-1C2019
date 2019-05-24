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
        //Variable usada para recibir la respuesta del Stored Procedured de crearRol, funciona como variable de salida
        private int respuesta;

        //Getter y setter de la variable
        public int getRespuesta() { return respuesta; }
        public void setRespuesta(int numero) { this.respuesta = numero; }

        #region Constructor
        public Rol()
        {
        }
        #endregion

        #region Crear un Rol
        public int crearRol(String nombre)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "agregarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                #region rol_descripcion
                SqlParameter rol_descripcion = new SqlParameter("@rolAgregar", SqlDbType.VarChar);
                rol_descripcion.Size = 255;
                rol_descripcion.Value = nombre;
                SqlCmd.Parameters.Add(rol_descripcion);
                #endregion

                #region Retorno del Stoc Procedure?
                SqlParameter resultado = new SqlParameter("@flag", SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(resultado);
                #endregion

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                respuesta = Convert.ToInt32(resultado.Value);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
        #endregion

        #region Obtener las Funcionalidades NO asignadas a un Rol
        public DataTable getFuncionalidades(String nombreRol)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarFuncionalidadesNoAgregadasARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rol_descripcion = new SqlParameter("@nombreRol", SqlDbType.VarChar);
                rol_descripcion.Size = 255;
                rol_descripcion.Value = nombreRol;
                SqlCmd.Parameters.Add(rol_descripcion);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion

        #region Obtener las Funcionalidades asignadas a un Rol
        public DataTable getFuncionalidadesAsignadas(String nombreRol)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarFuncionalidadesAgregadasARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter rol_descripcion = new SqlParameter("@nombreRol", SqlDbType.VarChar);
                rol_descripcion.Size = 255;
                rol_descripcion.Value = nombreRol;
                SqlCmd.Parameters.Add(rol_descripcion);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion

        #region Asignar una Funcionalidad a un Rol
        public void agregarFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "FIDEOS_CON_TUCO.AgregarFuncionalidadARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rol_descripcion = new SqlParameter("@nombreRol", SqlDbType.VarChar);
                rol_descripcion.Size = 255;
                rol_descripcion.Value = nombreRol;
                SqlCmd.Parameters.Add(rol_descripcion);

                SqlParameter func_descripcion = new SqlParameter("@funcionalidad", SqlDbType.VarChar);
                func_descripcion.Size = 255;
                func_descripcion.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(func_descripcion);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region Quitar una Funcionalidad a un Rol
        public void eliminarFuncionalidadARol(int idRol, String nombreFuncionalidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminarFuncionalidadARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter func_descripcion = new SqlParameter("@nombreFuncionalidad", SqlDbType.VarChar);
                func_descripcion.Size = 255;
                func_descripcion.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(func_descripcion);

                SqlParameter rol_codigo = new SqlParameter("@codigoRol", SqlDbType.Int);
                rol_codigo.Value = idRol;
                SqlCmd.Parameters.Add(rol_codigo);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region Mostrar Roles
        public DataTable mostrarRoles()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRoles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion

        #region Actualizar Nombre de Rol
        public void cambiarNombreRol(int id, String nombre)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarNombreRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter rol_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                rol_codigo.Value = id;
                SqlCmd.Parameters.Add(rol_codigo);

                SqlParameter rol_descripcion = new SqlParameter("@nombreRol", SqlDbType.VarChar);
                rol_descripcion.Size = 255;
                rol_descripcion.Value = nombre;
                SqlCmd.Parameters.Add(rol_descripcion);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region Habilitar un rol
        public void habilitarRol(int id)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "habilitarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter rol_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                rol_codigo.Value = id;
                SqlCmd.Parameters.Add(rol_codigo);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region Deshabilitar un rol
        public void deshabilitarRol(int id)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "deshabilitarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rol_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                rol_codigo.Value = id;
                SqlCmd.Parameters.Add(rol_codigo);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region Mostrar los roles habilitados
        public DataTable mostrarRolesHabilitados()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarRolesHabilitados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion


    }
}
