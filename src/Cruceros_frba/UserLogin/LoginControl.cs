using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Windows.Forms;


namespace FrbaCrucero.UserLogin
{
    class LoginControl
    {
        private string usua_username;
        private string usua_password;
        private int usua_codigo;
        private int usua_intentosFallidos;
        private bool usua_estaHabilitado;

        public string username
        {
            get { return usua_username; }
            set { usua_username = value; }
        }

        public string password
        {
            get { return usua_password; }
            set { usua_password = value; }
        }

        public int intentosFallidos
        {
            get { return usua_intentosFallidos; }
            set { usua_intentosFallidos = value; }
        }

        public LoginControl()
        {

        }

        public LoginControl(string Username, string Password, int Codigo, int IntentosFallidos, bool Habilitado)
        {
            this.usua_username = Username;
            this.usua_password = Password;
            this.usua_codigo = Codigo;
            this.usua_intentosFallidos = IntentosFallidos;
            this.usua_estaHabilitado = Habilitado;

        }

        public DataTable Login(LoginControl User)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {   //Primero me fijo si tiene intentos disponibles
               /* using (SqlCon) 
                {
                    SqlCon.ConnectionString = Coneccion.Con;
                    SqlCon.Open();

                    SqlCommand cmd = new SqlCommand("Select usua_intentos_fallidos From FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username", SqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (int.Parse(dr.Read().ToString()) == 3)
                    {
                        MessageBox.Show("Este Usuario esta Inhabilitado", "ERROR", MessageBoxButtons.OK);
                        dr.Close();
                        DtResultado = null;
                        return DtResultado;
                    }

                    dr.Close();
                }*/
                SqlCon.ConnectionString = Coneccion.Con;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "adminLogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroUsiario = new SqlParameter("@username", SqlDbType.VarChar);
                ParametroUsiario.Size = 255;
                ParametroUsiario.Value = User.username;
                SqlCmd.Parameters.Add(ParametroUsiario);

                SqlParameter ParametroPass = new SqlParameter("@password", SqlDbType.VarChar);
                ParametroPass.Size = 255;
                ParametroPass.Value = User.password;
                SqlCmd.Parameters.Add(ParametroPass);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show("error" + ex);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return DtResultado;
        }
    }
}