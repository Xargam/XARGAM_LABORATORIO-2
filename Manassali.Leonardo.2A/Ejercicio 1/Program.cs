using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.
*/

namespace Ejercicio1
{
    public class Ejercicio_1
    {
        public static void Main(string[] args)
        {
            int i;
            int number;
            int max = 0;
            int min = 0;
            int accumulator = 0;
            float mean;


            Console.Title = "Ejercicio 01";

            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero {0}:",i+1);
                number = int.Parse(Console.ReadLine());

                accumulator += number;

                if( number > max || i == 0)
                {
                    max = number;
                }
                if( number < min || i == 0)
                {
                    min = number;
                }
            }
            mean = (float)accumulator / i;
            Console.WriteLine("El promedio de los numeros ingresados fue {0:#,#.00}, el valor max {1} y el min {2} . ",mean,max,min);
            Console.ReadLine();
        }
    }
}
