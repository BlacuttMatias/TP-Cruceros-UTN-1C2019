using CapaDatos;
using FrbaCrucero.FormsPrincipales;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Coneccion.setFechaSistemaSinHora(DateTime.Parse(ConfigurationSettings.AppSettings["fechaApp"]));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipalAdmin());
        }
    }
}
