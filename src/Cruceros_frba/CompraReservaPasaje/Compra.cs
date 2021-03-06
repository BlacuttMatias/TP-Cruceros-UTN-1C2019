﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class Compra
    {
        private int codigoCliente;
        private MedioDePago medioDePago;
        private List<Pasaje> pasajes = new List<Pasaje>();
        private bool esUnaCompraDeUnaReserva = false;

        public Compra() { }

        public Compra(bool esCompraDeUnaReserva)
        {
            this.esUnaCompraDeUnaReserva = esCompraDeUnaReserva;
        }

        public void setEsUnaCompraDeUnaReserva(bool esUnaCompraDeReserva) { this.esUnaCompraDeUnaReserva = esUnaCompraDeReserva; }
        public bool getEsUnaCompraDeUnaReserva() { return this.esUnaCompraDeUnaReserva; }

        public void setCodigoCliente(int unCodigoCliente) { this.codigoCliente = unCodigoCliente; }
        public int getCodigoCliente() { return this.codigoCliente; }

        public void setMedioDePago(MedioDePago unMedioDePago) { this.medioDePago = unMedioDePago; }
        public MedioDePago getMedioDePago() { return this.medioDePago; }

        public List<Pasaje> getPasajes() { return this.pasajes; }

        public void agregarPasaje(Pasaje unPasaje){
            this.pasajes.Add(unPasaje);
        }
    }
}
