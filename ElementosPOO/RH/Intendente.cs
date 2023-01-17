
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementosPOO
{
	public class Intendente : Empleado, ILimpiar {

        string miNombre = "xxx.";

        public Intendente() {
            Console.WriteLine("Se creó un intendente con nombre " + this.miNombre);
        }
          

        public void Limpiar(){

            Console.WriteLine("Limpiando....");
        }
        public string Limpiar(double metros)
        {
            Console.WriteLine("Limpiando  " + metros + " metros...");
            return "Se limpió";
        }
        public string Limpiar(string area)
        {
            Console.WriteLine("Limpiando area " + area);
            return "Se limpió";
        }

        public string Trapear(string area)
        {
            string res = "";
            Console.WriteLine("Vamos a trapear... como Renegado lo indica");
            for (int a = 0; a <= 25; a++)
                Console.WriteLine("Trapeandich ich dich  ... ando... Vor Mir " + a + " min.");

            return res;
        }

        public string Sacarbasura(string area)
        {
            string res = "";
            Console.WriteLine("Sacando la basura de todas las areas");
            if (area == "1")
            {
                Console.WriteLine("Bien hecho, sigue trabajando");
            }
            else
                Console.WriteLine("estas perdiendo tiempo, apurale");
            return res;
        }



    }
}