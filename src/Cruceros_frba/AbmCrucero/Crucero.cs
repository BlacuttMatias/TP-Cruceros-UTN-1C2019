using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmCrucero
{
    class Crucero
    {
        public int crearCrucero(string codigoCrucero,string marcaCrucero,string modeloCrucero,int cantidadCabinas,DateTime fecha)
        {//[dbo].[agregarCrucero] @cruceroCodigo varchar(255),@cruceroMarca varchar(255), @cruceroModelo varchar(255),@cantidadCabinas int,@fecha DateTime, @resultado int 
            return Coneccion.ejecutarSPR("agregarCrucero","@resultado", "@cruceroCodigo", codigoCrucero, "@cruceroMarca", marcaCrucero, "@cruceroModelo", modeloCrucero, "@cantidadCabinas", cantidadCabinas, "@fecha", fecha);
        }

        public DataTable mostrarTipoBaja()
        {
            return Coneccion.ejecutarSP("mostrarTipoBaja");
        }

        public void agregarCabinaAUnCrucero(string cabiCrucero, int cabiNumero, int cabiPiso, string cabiTipo)
        {//agregarCabinaAUnCrucero @cabiCrucero varchar(255),@cabiNumero int,@cabiPiso int, @cabiTipo varchar(255)
            Coneccion.ejecutarSP("agregarCabinaAUnCrucero", "@cabiCrucero", cabiCrucero, "@cabiNumero", cabiNumero, "@cabiPiso", cabiPiso, "cabiTipo", cabiTipo);
        }

        internal DataTable mostrarBajas()
        {
            return Coneccion.ejecutarSP("mostrarBajas");
        }

        public DataTable mostrarCruceros()
        {
            return Coneccion.ejecutarSP("mostrarCruceros");
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
            return Coneccion.ejecutarSP("mostrarCabinasDeUnCrucero","@cruceroCodigo",codigoCrucero);
        }

        public void modificarCrucero(string codigo, string text1, string text2)
        {
            Coneccion.ejecutarSPR("modificarCrucero","@cruceroCodigo", codigo, "@cruceroMarca", text1, "@cruceroModelo", text2);
        }
        public void bajaCrucero(string codigo, DateTime baja, DateTime alta, string tipoBaja)
        {//[bajaCrucero] @codigo varchar(255), @tipoBaja varchar(255), @fechaSistema datetime, @fechaAlta datetime
            Coneccion.ejecutarSP("bajaCrucero", "@codigo", codigo, "@tipoBaja",tipoBaja, "@fechaSistema",baja, "@fechaAlta",alta);
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
