
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO{
	public interface ILimpiar
	{
		public void limpiar();
		public string limpiar(string area);
		public string limpiar(double metros);

		/// creo que asi seria
		public string trapear(string area);
		public string sacarbasura(string areas);
		}
	}
}	