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
        //Variable usada para recibir la respuesta del Stored Procedured de crearPuerto, funciona como variable de salida
        private int respuesta;

        //Getter y setter de la variable
        public int getRespuesta() { return respuesta; }
        public void setRespuesta(int numero) { this.respuesta = numero; }

        #region Constructor
        public Puerto()
        {
        }
        #endregion

        #region crearPuerto
        public int crearPuerto(string ciudad,string _descripcion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "agregarPuerto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                #region puer_ciudad
                SqlParameter puer_ciudad = new SqlParameter("@ciudad", SqlDbType.VarChar);
                puer_ciudad.Size = 255;
                puer_ciudad.Value = ciudad;
                SqlCmd.Parameters.Add(puer_ciudad);
                #endregion


                #region Retorno del Stoc Procedure?
                SqlParameter resultado = new SqlParameter("@resultado", SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(resultado);
                #endregion

                #region puer_descripcion
                SqlParameter puer_descripcion = new SqlParameter("@descripcion", SqlDbType.VarChar);
                puer_descripcion.Size = 255;
                puer_descripcion.Value = _descripcion;
                SqlCmd.Parameters.Add(puer_descripcion);
                #endregion
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                respuesta = Convert.ToInt32(resultado.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
        #endregion

        #region deshabilitarPuerto
        public void deshabilitarPuerto(int codigo)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "deshabilitarPuerto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter puer_codigo = new SqlParameter("@codigoPuerto", SqlDbType.Int);
                puer_codigo.Value = codigo;
                SqlCmd.Parameters.Add(puer_codigo);

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

        #region habilitarPuerto
        public void habilitarPuerto(int codigo)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "habilitarPuerto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter puer_codigo = new SqlParameter("@codigoPuerto", SqlDbType.Int);
                puer_codigo.Value = codigo;
                SqlCmd.Parameters.Add(puer_codigo);

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

        #region modificarPuerto
        public void modificarPuerto(int codigo, string ciudad,string descripcion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "modificarPuerto";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter puer_codigo = new SqlParameter("@codigoPuerto", SqlDbType.Int);
                puer_codigo.Value = codigo;
                SqlCmd.Parameters.Add(puer_codigo);            

                SqlParameter puer_ciudad = new SqlParameter("@ciudad", SqlDbType.VarChar);
                puer_ciudad.Size = 255;
                puer_ciudad.Value = ciudad;
                SqlCmd.Parameters.Add(puer_ciudad);

                SqlParameter puer_descripcion = new SqlParameter("@descripcion", SqlDbType.VarChar);
                puer_descripcion.Size = 255;
                puer_descripcion.Value = descripcion;
                SqlCmd.Parameters.Add(puer_descripcion);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        #endregion

        #region mostrarPuertos
        public DataTable mostrarPuertos()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarPuertos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion

        #region mostrarPuertosHabilitados
        public DataTable mostrarPuertosHabilitados()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarPuertosHabilitados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion

        #region mostrarPuertosDeshabilitados
        public DataTable mostrarPuertosDeshabilitados()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarPuertosDeshabilitados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
