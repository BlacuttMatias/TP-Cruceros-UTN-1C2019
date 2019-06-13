using CapaDatos;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.FormsPrincipales;
using FrbaCrucero.PagoReserva;
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
            //levanto los datos iniciales del archivo de configuracion
            Coneccion.setFechaSistemaSinHora(DateTime.Parse(ConfigurationSettings.AppSettings["fechaApp"]));
            Coneccion.Con = ConfigurationSettings.AppSettings["coneccion"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbmCrucero.frmABMCruceroMain());
        }
    }
}
