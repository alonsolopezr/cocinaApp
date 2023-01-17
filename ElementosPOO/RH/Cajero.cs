
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ElementosPOO{
	public class Cajero : Empleado, IFacturar, ILimpiar, ICalcularSueldo {

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

        public void Limpiar()
        {
            Console.WriteLine("Limpiando....");
        }
        public string Limpiar(double metros)
        {
            Console.WriteLine("Limpiando  " + metros + " metros...");
            return "Se limpió";
        }
        public string Limpiar(string area)
        {
            Console.WriteLine( "Limpiando area "+area);
            return "Se limpió";
        }

        //todo: Terminar de implemenntar los métodos
        public string Trapear(string area)
        {
            string res = "";
            Console.WriteLine("Vamos a trapear... como Renegado lo indica");
            for(int a=0; a<=25;a++)
                Console.WriteLine("Trapeandich ich dich  ... ando... Vor Mir "+a+" min.");

            return res;
        }

        public string Sacarbasura(string area)
         {
            string res = "";
            Console.WriteLine("Sacando la basura de todas las areas");
            if (area == "1") {
                Console.WriteLine("Bien hecho, sigue trabajando");
            }else
                Console.WriteLine("estas perdiendo tiempo, apurale");
            return res;
            }
        

        public double CalcularSueldo()
        {
            Sueldo = ((salarioDiario * horasTrabajadas) + pagoHoraExtra);
            Console.WriteLine("El sueldo es" + Sueldo);
            return Sueldo;
        }
    }
    }
