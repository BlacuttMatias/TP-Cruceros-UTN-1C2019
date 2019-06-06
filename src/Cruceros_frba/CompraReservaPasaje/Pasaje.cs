using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class Pasaje
    {
        private double precio;
        private int codigoCliente ;
        private int codigoViaje ;
        private int codigoCabina;

        public void setPrecio(double unPrecio) { this.precio = unPrecio; }
        public double getPrecio() { return this.precio; }

        public void setCodigoCliente(int unCodigoCliente) { this.codigoCliente = unCodigoCliente; }
        public int getCodigoCliente() { return this.codigoCliente; }

        public void setCodigoViaje(int unCodigoViaje) { this.codigoViaje = unCodigoViaje; }
        public int getCodigoViaje() { return this.codigoViaje; }

        public void setCodigoCabina(int unCodigoCabina) { this.codigoCabina = unCodigoCabina; }
        public int getCodigoCabina() { return this.codigoCabina; }
    }
}
