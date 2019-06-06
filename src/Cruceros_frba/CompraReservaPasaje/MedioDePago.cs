using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class MedioDePago
    {
        private int numeroTarjeta;
        private int codigoTipoMedioDePago;
        private int codigoCantidadDeCuotas;

        public void setNumeroTarjeta(int unNumeroDeTarjeta) {
            this.numeroTarjeta = unNumeroDeTarjeta;
        }
        public int getNumeroDeTarjeta() {
            return this.numeroTarjeta;
        }

        public void setCodigoTipoMedioDePago(int unCodigoTipoDeMedioDePago)
        {
            this.codigoTipoMedioDePago = unCodigoTipoDeMedioDePago;
        }
        public int getCodigoTipoMedioDePago()
        {
            return this.codigoTipoMedioDePago;
        }

        public void setCodigoCantidadDeCuotas(int unaCodigoCantidadDeCuotas)
        {
            this.codigoCantidadDeCuotas = unaCodigoCantidadDeCuotas;
        }
        public int getCodigoCantidadDeCuotas()
        {
            return this.codigoCantidadDeCuotas;
        }

        
    }
}
