
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO
{
	public class Intendente : Empleado, ILimpiar {

		public Intendente() {
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
            Console.WriteLine("Limpiando area " + area);
            return "Se limpió";
        }

    }
}