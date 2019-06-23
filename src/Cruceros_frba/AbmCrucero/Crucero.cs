using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmCrucero
{
    public class Crucero
    {
        public int crearCrucero(string codigoCrucero, string marcaCrucero, string modeloCrucero, int cantidadCabinas, DateTime fecha)
        {//[dbo].[agregarCrucero] @cruceroCodigo varchar(255),@cruceroMarca varchar(255), @cruceroModelo varchar(255),@cantidadCabinas int,@fecha DateTime, @resultado int 
            return Coneccion.ejecutarSPR("agregarCrucero", "@resultado", "@cruceroCodigo", codigoCrucero, "@cruceroMarca", marcaCrucero, "@cruceroModelo", modeloCrucero, "@cantidadCabinas", cantidadCabinas, "@fecha", fecha);
        }

        public DataTable mostrarTipoBaja()
        {
            return Coneccion.ejecutarSP("mostrarTipoBaja");
        }

        public void agregarCabinaAUnCrucero(string cabiCrucero, int cabiNumero, int cabiPiso, string cabiTipo)
        {//agregarCabinaAUnCrucero @cabiCrucero varchar(255),@cabiNumero int,@cabiPiso int, @cabiTipo varchar(255)
            Coneccion.ejecutarSPV("agregarCabinaAUnCrucero", "@cabiCrucero", cabiCrucero, "@cabiNumero", cabiNumero, "@cabiPiso", cabiPiso, "cabiTipo", cabiTipo);
        }

        internal DataTable mostrarViajesDeCrucero(string codigo)
        {
            return Coneccion.ejecutarSP("mostrarViajesDeUnCrucero", "@crucero_a_dar_de_baja", codigo);
        }

        internal DataTable mostrarBajas()
        {
            return Coneccion.ejecutarSP("mostrarBajas");
        }

        public DataTable mostrarCrucerosSinBajaPermanenteHastaElMomento() {
            return Coneccion.ejecutarSP("mostrarCrucerosSinBajaPermanente", "@fechaSistema", Coneccion.getFechaSistema());
        }

        public DataTable mostrarCruceros()
        {
            return Coneccion.ejecutarSP("mostrarCruceros", "@fechaSistema", Coneccion.getFechaSistema());
        }
        public DataTable mostrarMarcas()
        {
            return Coneccion.ejecutarSP("mostrarMarcas");
        }
        public DataTable mostrarModelos()
        {
            return Coneccion.ejecutarSP("mostrarModelos");
        }
        public DataTable mostrarTipoCabina()
        {
            return Coneccion.ejecutarSP("mostrarTipoCabinas");
        }

        public DataTable mostrarCabinasDeUnCrucero(string codigoCrucero)
        {
            return Coneccion.ejecutarSP("mostrarCabinasDeUnCrucero", "@cruceroCodigo", codigoCrucero);
        }

        public void modificarCrucero(string codigo, string text1, string text2)
        {
            Coneccion.ejecutarSPV("modificarCrucero", "@cruceroCodigo", codigo, "@cruceroMarca", text1, "@cruceroModelo", text2);
        }
        public void bajaCrucero(string codigo, DateTime baja, DateTime alta, string tipoBaja)
        {//[bajaCrucero] @codigo varchar(255), @tipoBaja varchar(255), @fechaSistema datetime, @fechaAlta datetime
            Coneccion.ejecutarSPV("bajaCrucero", "@codigo", codigo, "@tipoBaja", tipoBaja, "@fechaSistema", baja, "@fechaAlta", alta);
        }

        internal DataTable mostrarViajesDeCruceroEntre(string codigo, DateTime baja, DateTime alta)
        {
            return Coneccion.ejecutarSP("mostrarViajesDeUnCruceroEntre", "@crucero_a_dar_de_baja", codigo, "@inicio", baja, "@fin", alta);
        }

        public DataTable mostrarViajesDeUnCrucero(string codigoCrucero, DateTime fechaBajaPermanente) {
            return Coneccion.ejecutarSP("mostrarViajesDeUnCrucero", "@codigoCrucero", codigoCrucero, "@fechaBajaPermanente", fechaBajaPermanente);
        }

        internal void cancelarViajesBajaPermanente(string codigoCrucero, DateTime fechaBaja)
        {
            Coneccion.ejecutarSPV("cancelacionViajesParaBajaPermanente",
                "@codigoCrucero", codigoCrucero,
                "@fechaSistema", Coneccion.getFechaSistema(),
                "@fechaBaja", fechaBaja);
        }
        internal void cancelarViajesBajaTemporal(string codigoCrucero, DateTime fechaBaja, DateTime fechaAlta)
        {
            Coneccion.ejecutarSPV("cancelacionViajesParaBajaTemporal",
                "@codigoCrucero", codigoCrucero,
                "@fechaSistema", Coneccion.getFechaSistema(),
                "@fechaBaja", fechaBaja,
                "@fechaAlta", fechaAlta);
        }

        internal void corrimientoDiasViaje(string crucero_codigo, int corrimiento, DateTime fechaInicioBajaTemporal)
        {
            Coneccion.ejecutarSPV("corrimientoDiasViaje",
                   "@crucero_codigo", crucero_codigo,
                   "@corrimiento", corrimiento,
                   "@fechaInicioBajaTemporal", fechaInicioBajaTemporal);
        }

        internal int crearCruceroIgualAlAnterior(string codigoCruceroAnterior, string codigoNuevoCrucero, DateTime fechaAltaCruceroNuevo)
        {
            return Coneccion.ejecutarSPR("crearCruceroIgualAlAnterior", 
                "@resultado",
                "@codigoCruceroAnterior", codigoCruceroAnterior,
                "@codigoNuevoCrucero", codigoNuevoCrucero,
                "@fechaAltaCruceroNuevo", fechaAltaCruceroNuevo);
        }

        internal DataTable cruceroParaReemplazarAOtro(string codigoCruceroAReemplazar, DateTime fechaBajaPermanente)
        {
            return Coneccion.ejecutarSP("cruceroParaReemplazarAOtro", "@codigoCruceroAReemplazar", codigoCruceroAReemplazar,
                "@fechaBajaPermanente", fechaBajaPermanente);
        }

        internal void actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente(
            string cruceroReemplazado,
            string cruceroNuevo,
            DateTime fechaBaja)
        {
            Coneccion.ejecutarSPV("actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente",
                "@codigoCruceroReemplazado", cruceroReemplazado,
                "@codigoCruceroQueLoReemplazo", cruceroNuevo,
                "@fechaBajaPermanenteDeCruceroReemplazado", fechaBaja);
        }

    }
    public class nodoCabina
    {
        public int piso { get; set; }
        public List<int> cabinas { get; set; }
        public nodoCabina()
        {
            cabinas = new List<int>();
        }
    }

}
