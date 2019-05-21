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
                SqlParameter descriptionRol = new SqlParameter();
                descriptionRol.ParameterName = "@rolAgregar";
                descriptionRol.SqlDbType = SqlDbType.VarChar;
                descriptionRol.Size = 255;
                descriptionRol.Value = nombre;
                SqlCmd.Parameters.Add(descriptionRol);
                #endregion

                #region Retorno del Stoc Procedure?
                SqlParameter resultado = new SqlParameter();
                resultado.ParameterName = "@resultado";
                resultado.SqlDbType = SqlDbType.Int;
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

                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@nombreRol";
                rol.SqlDbType = SqlDbType.VarChar;
                rol.Size = 255;
                rol.Value = nombreRol;
                SqlCmd.Parameters.Add(rol);

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

                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@nombreRol";
                rol.SqlDbType = SqlDbType.VarChar;
                rol.Size = 255;
                rol.Value = nombreRol;
                SqlCmd.Parameters.Add(rol);

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

                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@nombrerol";
                rol.SqlDbType = SqlDbType.VarChar;
                rol.Size = 255;
                rol.Value = nombreRol;
                SqlCmd.Parameters.Add(rol);

                SqlParameter funcionalidad = new SqlParameter();
                funcionalidad.ParameterName = "@funcionalidad";
                funcionalidad.SqlDbType = SqlDbType.VarChar;
                funcionalidad.Size = 255;
                funcionalidad.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(funcionalidad);

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

                SqlParameter funcionalidad = new SqlParameter();
                funcionalidad.ParameterName = "@nombreFuncionalidad";
                funcionalidad.SqlDbType = SqlDbType.VarChar;
                funcionalidad.Size = 255;
                funcionalidad.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(funcionalidad);

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@idRol";
                id.SqlDbType = SqlDbType.Int;
                id.Value = idRol;
                SqlCmd.Parameters.Add(id);

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

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@id";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

                SqlParameter nombreRol = new SqlParameter();
                nombreRol.ParameterName = "@nombreRol";
                nombreRol.SqlDbType = SqlDbType.VarChar;
                nombreRol.Size = 255;
                nombreRol.Value = nombre;
                SqlCmd.Parameters.Add(nombreRol);

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

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@idRol";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

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

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@idRol";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

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
