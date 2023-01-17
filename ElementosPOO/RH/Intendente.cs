
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO
{
	public class Intendente : Empleado, ILimpiar{

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

        /// creo que seria asi
        public string trapear(string area)
        {
            Console.WriteLine("Estoy trapeando el area" + area);
            return "area trapeada" + area;
        }
        public string sacarbasura(string area)
        {
            Console.WriteLine("¿Sacando basur al area" + area);
            return "I did it";
        }
        public override double CalcularSueldo1()
        {
            throw new NotImplementedException();
        }


    }
}