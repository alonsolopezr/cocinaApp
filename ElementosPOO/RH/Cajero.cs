
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace ElementosPOO{
	public class Cajero : Empleado, IFacturar, ILimpiar{

		string elNombre = "Angel....";
		public Cajero() {
			Console.WriteLine(	"Se creó un cajero con nombre "+this.elNombre);
        }

        public string facturar(DatosDeFacturacion datos)
        {
            string folio = "dsfdaf";
            //-----
            return folio;
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
            Console.WriteLine( "Limpiando area "+area);
            return "Se limpió";
        }

        //todo: Terminar de implemenntar los métodos
        public string trapear(string area)
        {
            string res = "";
            Console.WriteLine("Vamos a trapear... como Renegado lo indica");
            for(int a=0; a<=25;a++)
                Console.WriteLine("Trapeandich ich dich  ... ando... Vor Mir "+a+" min.");

            return res;
        }
        public string sacarbasura(string areas)
        {
            string res = "";
            Console.WriteLine("Se esta sacando la basura como Nava indica");
            return res; 
        }

        public override double calcularSueldo1()
        {
            throw new NotImplementedException();
        }
    }
}