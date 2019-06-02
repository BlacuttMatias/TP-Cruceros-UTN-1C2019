using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Coneccion
    {
        public static string Con = "Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2019;User ID=gdCruceros2019;password=gd2019;Integrated Security=True";

        private static DateTime fechaSistema;

        public static void setFechaSistemaSinHora(DateTime unaFechaSinHoras)
        {
            fechaSistema = unaFechaSinHoras;
        }

        public static DateTime getFechaSistema()
        {
            DateTime horaReal = DateTime.Now;
            return fechaSistema.AddHours(horaReal.Hour).AddMinutes(horaReal.Minute).AddSeconds(horaReal.Second);
        }

        /// <summary>
        /// Ejecuta un stock procedure, no tiene retorno.
        /// (SqlCommandString, "@var1",var1,"@var2",var2,...,"@varN",varN)
        /// SqlCommandString es el nombre de el SP en este caso, por ejemplo "mostrarRoles"
        /// </summary>
        /// <param name="args">(SqlCommandString, @var1,var1,@var2,var2,...,@varN,varN)</param>
        public static void ejecutarSPV(params object[] args)
        {
            SqlConnection coneccion = new SqlConnection(Coneccion.Con);
            SqlCommand cmd = new SqlCommand(args[0].ToString(), coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1] as string, args[i + 2]);
                i++;
            }
            coneccion.Open();
            cmd.ExecuteReader();
        }

        /// <summary>
        /// Ejecuta un stock procedure que devuelve un int.
        /// (SqlCommandString,"@varRetorno", "@var1",var1,"@var2",var2,...,"@varN",varN)
        /// "@varRetorno" puede ser "@resultado" o "@flag" segun lo que vi en las SP
        /// SqlCommandString es el nombre de el SP en este caso, por ejemplo "mostrarRoles"
        /// </summary>
        /// <param name="args">(SqlCommandString,"@varRetorno", "@var1",var1,"@var2",var2,...,"@varN",varN)</param>
        public static int ejecutarSPR(params object[] args)
        {
            int respuesta = 0;
            try
            {
                SqlConnection coneccion = new SqlConnection(Coneccion.Con);
                SqlCommand cmd = new SqlCommand(args[0].ToString(), coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 1; i < args.Length - 2; i++)
                {
                    cmd.Parameters.AddWithValue(args[i + 1] as string, args[i + 2]);
                    i++;
                }
                SqlParameter resultado = new SqlParameter(args[1].ToString(), SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultado);
                coneccion.Open();
                cmd.ExecuteReader();
                respuesta = Convert.ToInt32(resultado.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"FrbaCruceros");
            }
            return respuesta;
        }
        /// <summary>
        /// Ejecuta un stock procedure que devuelve un DataTable.
        /// (SqlCommandString, @var1,var1,@var2,var2,...,@varN,varN)
        /// SqlCommandString es el nombre de el SP en este caso, por ejemplo "mostrarRoles"
        /// </summary>
        /// <param name="args">(SqlCommandString, @var1,var1,@var2,var2,...,@varN,varN)</param>
        public static DataTable ejecutarSP(params object[] args)
        {
            DataTable dtSP = new DataTable();
            SqlConnection coneccion = new SqlConnection();
            coneccion.ConnectionString = Coneccion.Con;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coneccion;
            cmd.CommandText = args[0].ToString();
            cmd.CommandType = CommandType.StoredProcedure;
            FrbaCrucero.AbmRecorrido.Debugger debugger = new FrbaCrucero.AbmRecorrido.Debugger();
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1] as string, args[i + 2]);
                debugger.log("i:"+i+" nombre:"+ args[i + 1].ToString()+" valor:"+ args[i + 2]);
                i++;
            }
            try
            {
                coneccion.Open();
                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(dtSP);
            }
            catch (Exception e)
            {
                debugger.log(e.ToString());
                debugger.Show();
            }
            return dtSP;
        }
        /// <summary>
        /// Ejecuta un SELECT que devuelve un DataTable.
        /// (SqlCommandString, @var1,var1,@var2,var2,...,@varN,varN)
        /// SqlCommandString es el SELECT!!!
        /// ejemplo
        /// string SLCT= SELECT *
        /// SLCT +=" FROM tabla"
        /// SLCT +=" WHERE blah"
        /// SLCT +=" GROUP BY bleh"
        /// SLCT +=" HAVING a=@a"
        /// entonces la llamas asi: DataTable hayTabla=Coneccion.ejecutarSelect(SLCT,"@a",a);
        /// </summary>
        /// <param name="args">(SqlCommandString, @var1,var1,@var2,var2,...,@varN,varN)</param>
        public static DataTable ejecutarSelect(params object[] args)
        {
            DataTable dtSelect = new DataTable();
            SqlConnection coneccion = new SqlConnection(Coneccion.Con);
            SqlCommand cmd = new SqlCommand(args[0].ToString(), coneccion);
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1].ToString(), args[i + 2]);
                i++;
            }
            try
            {
                coneccion.Open();
                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(dtSelect);
            }
            catch (Exception)
            {

                throw;
            }
            return dtSelect;
        }
    }
}
