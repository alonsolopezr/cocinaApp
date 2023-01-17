
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO
{
	public class JefeDeOficina : Empleado, IFacturar{ 
    

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

		public double ICalcularSueldo()
		{
			return 0;
		}


	}
}