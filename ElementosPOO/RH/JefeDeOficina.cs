
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
        public override double calcularSueldo1()
        {
            throw new NotImplementedException();
        }
    }
}