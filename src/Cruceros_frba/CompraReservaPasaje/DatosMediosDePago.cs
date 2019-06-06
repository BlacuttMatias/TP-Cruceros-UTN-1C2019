﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    class DatosMediosDePago
    {
        public DataTable obtenerEmpresasTarjetas()
        {
            return Coneccion.ejecutarSP("mostrarEmpresasDeTarjetas");
        }

        public DataTable obtenerCantidadDeCuotasDeUnaEmpresa(int codigoEmpresa)
        {
            return Coneccion.ejecutarSP("mostrarCuotasDeUnaEmpresa", "@codigoEmpresa", codigoEmpresa);
        }

        public DataTable obtenerTiposMediosDePago()
        {
            return Coneccion.ejecutarSP("mostrarTiposDeMediosDePago");
        }

        public void persistirTarjeta(int numeroTarjeta, int codigoVerificador, string tipoDeTarjeta, int codigoEmpresa) {
            Coneccion.ejecutarSPV("ingresarTarjeta", "@numeroTarjeta", numeroTarjeta, "@codigoVerificador"
                , codigoVerificador, "@tipoTarjeta", tipoDeTarjeta, "@codigoEmpresa", codigoEmpresa);
        }

        public int persistirMedioDePago(int codigoTipoDeMedioDePago, int numeroTarjeta, int cantidadDeCuotas) {
            return Coneccion.ejecutarSPR("ingresarMedioDePagoConTarjeta", "@codigoMedioDePago"
                , "@tipoMedioDePago", codigoTipoDeMedioDePago, "@numeroTarjeta", numeroTarjeta
                , "@cantidadDeCuotas", cantidadDeCuotas);
        }

        public int persistirPasaje(int codigoCliente, int codigoViaje, int codigoCabina) {
            return Coneccion.ejecutarSPR("@codigoPasaje", "@codigoCliente", codigoCliente
                , "@codigoViaje", codigoViaje, "@codigoCabina", codigoCabina);
        }

        public int persistirCompra(int codigoCliente, int codigoMedioDePago) {
            return Coneccion.ejecutarSPR("@codigoCompra", "@codigoCliente", codigoCliente
                , "@fechaSistema", Coneccion.getFechaSistema(), "@codigoMedioDePago", codigoMedioDePago);
        }

        public void agregarPasajeAUnaCompra(int codigoPasaje, int codigoCompra) {
            Coneccion.ejecutarSPV("agregarPasajeAUnaCompra", "@codigoPasaje", codigoPasaje
                , "@codigoCompra", codigoCompra);
        }

    }
}
