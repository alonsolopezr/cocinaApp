
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
		public double Sueldo;

		

		//
		protected string imprimirDatos() {
			// TODO implement here
			return "";
		
		}

		

	}
}