using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.UserLogin
{
    class Login
    {
        public static DataTable loguearUsuario(string username, string contrasenia)
        {
            return Coneccion.ejecutarSP("adminLogin", "@username", username, "@password",
                contrasenia, "@fechaSistema", Coneccion.getFechaSistema());
        }
    }
}
