
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO{
	public class Cajero : Empleado, IFacturar, ILimpiar {

		string elNombre = "Angel....";
		public Cajero() {
			Console.WriteLine(	"Se creó un cajero con nombre "+this.elNombre);
		}

        public string facturar(DatosDeFacturacion datos)
        {
            string folio = "dsfdaf";
            //-----
            return folio;
        }

        public void limpiar()
        {
            Console.WriteLine("Limpiando....");
        }
        public string limpiar(double metros)
        {
            Console.WriteLine("Limpiando  " + metros + " metros...");
            return "Se limpió";
        }
        public string limpiar(string area)
        {
            Console.WriteLine( "Limpiando area "+area);
            return "Se limpió";
        }

      
    }
}