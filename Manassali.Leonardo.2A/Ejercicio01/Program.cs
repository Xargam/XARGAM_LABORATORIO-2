using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main( string[] args )
        {
            string nombre;
            int edad;
            int salida;

            Console.Title = "Ejercicio01";
            Console.WriteLine("Ingrese nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad:");

            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Su nombre es {0} y su edad {1}.",nombre,edad);
        }
    }
}
