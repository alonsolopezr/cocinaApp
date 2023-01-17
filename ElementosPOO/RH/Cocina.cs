
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO{
	public class Cocina : Empleado {

		public Cocina() 
        {

		}
        /// <summary>
        /// @return
        /// </summary>
        public bool limpiar() {
			// TODO implement here
			return false;
		}
        public string limpiar(double limpieza)
			//Se agregó la función de limpiar la cocina, por el cocinero
        {
            Console.WriteLine($"El cocinero limpiará{limpieza} toda la cocina");
            return "Se limpió la cocina";
			Console.WriteLine("");
        }
        public override double CalcularSueldo1()
        {
            double res = 0;
            return res; 
        }
    }
}