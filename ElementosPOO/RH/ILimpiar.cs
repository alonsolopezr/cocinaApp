
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO{
	public interface ILimpiar
	{
		public void Limpiar();
		public string Limpiar(string area);
		public string Limpiar(double metros);
		//actualizaciones de Lilian

		/// creo que asi seria
		public string Trapear(string area);
		public string Sacarbasura(string area);
		}
	}
	