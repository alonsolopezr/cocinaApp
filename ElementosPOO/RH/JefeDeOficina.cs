
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO
{
	public class JefeDeOficina : Empleado, IFacturar, IcalcularSueldo
	{

		public JefeDeOficina()
		{

		}
        /// <summary>
        /// @param datos 
        /// @return
        /// </summary>
        public string facturar(DatosDeFacturacion datos)
		{
			// TODO implement here
			return "";
		}

		public double IcalcularSueldo()
		{
			return 0;
		}
        public override double CalcularSueldo1()
        {
			int res = 0;
			Console.WriteLine("Se calculó su sueldo con base en faltas, entonces quedó en " + res);
			return res; 
        }
    }
}