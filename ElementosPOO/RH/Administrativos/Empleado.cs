
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO{
	public abstract class Empleado {

		public Empleado() {
		}

		protected string nombre;

		protected string apellidoPat;

		protected string apellidoMat;

		protected string rfc;

		protected string numEmpleado;

		/// /////
		/// creo que ya la regue =D pero quiero estos para calcular el Sueldo y que
		/// estos atributos/metodos se pueda agregar a todas las subclases de empleado*/ 
		
		protected double salarioDiario;
		protected double pagoHoraExtra;
		protected int horasTrabajadas;
		public double calcularSueldo;

		

		//
		protected string imprimirDatos() {
			// TODO implement here
			return "";
		
		}

		/// esto lo ha sugerido visual asi que no tengo ni idea de que se trata =D
		public abstract double calcularSueldo1();



		
			//return ((salarioDiario * horasTrabajadas) + pagoHoraExtra);
		

	}
}