using System;

namespace ElementosPOO // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Negocio POO");
            Console.WriteLine(  "Crear instancia de cajero");
            Cajero miCajeroFav = new Cajero();

            Intendente intendente = new Intendente();
            intendente.limpiar(34.34);
            



            Console.WriteLine(  "Presiona cualquier tecla para terminar...");
            Console.ReadKey();

        }
    }
}