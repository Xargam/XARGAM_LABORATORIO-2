using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

namespace Ejercicio_02
{
    public class Ejercicio2
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Title = "Ejercicio 02";

            do
            {
                Console.WriteLine("Ingrese un numero entero mayor a 0:");
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}.", number, Math.Pow(number, 2), Math.Pow(number, 3));
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
            while (number < 1);
            Console.ReadLine();
        }
    }
}
