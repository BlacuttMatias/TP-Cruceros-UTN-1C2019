using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    class DatosCliente
    {
        public DataTable obtenerDatosCliente(int dni) {
            return Coneccion.ejecutarSP("traerCliente", "@dni", dni);
        }

        public void actualizarCliente(int codigoCliente, string nombre, string apellido,
            int dni, int telefono, string mail, string direccion, DateTime fechaNacimiento)
        {
            if (mail == null || mail == "")
            {
                Coneccion.ejecutarSPV("actualizarCliente", "@codigoCliente", codigoCliente,
                "@nombre", nombre, "@apellido", apellido, "@dni", dni, "@telefono", telefono,
                "@direccion", direccion, "@fechanacimiento", fechaNacimiento);
            }
            else {
                Coneccion.ejecutarSPV("actualizarCliente", "@codigoCliente", codigoCliente,
                "@nombre", nombre, "@apellido", apellido, "@dni", dni, "@telefono", telefono
                , "@direccion", direccion, "@fechanacimiento", fechaNacimiento, "@mail", mail);
            } 
        }

        public int persistirCliente(string nombre, string apellido,
           int dni, int telefono, string mail, string direccion, DateTime fechaNacimiento)
        {
            if (mail == null || mail == "")
            {
                return Coneccion.ejecutarSPR("ingresarCliente", "@codigoCliente", "@nombre", nombre, "@apellido", apellido
                     , "@dni", dni, "@telefono", telefono, "@direccion", direccion, "@fechanacimiento", fechaNacimiento);
            }
            else {
                return Coneccion.ejecutarSPR("ingresarCliente", "@codigoCliente", "@nombre", nombre, "@apellido", apellido
                    , "@dni", dni, "@telefono", telefono, "@direccion", direccion, "@fechanacimiento", fechaNacimiento
                    , "@mail", mail);
            }
            
        }

    }
}
