using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace FrbaCrucero.UserLogin
{
    class Administrador
    {
        public static DataTable LoginAdm(string user, string pass)
        {
            LoginControl Controlador = new LoginControl();
            Controlador.username = user;
            Controlador.password = pass;

            return Controlador.Login(Controlador);
        }

    }
}
