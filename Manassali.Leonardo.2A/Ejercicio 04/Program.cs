
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
*/

namespace Ejercicio_04
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int accumulator;

            Console.Title = "Ejercicio 04";

            Console.WriteLine("Números perfectos:");
            for(int num = 1; counter < 4; num++)
            {
                accumulator = 0;
                for(int divisor = 1; divisor < num; divisor++)
                {
                    if( num % divisor == 0)
                    {
                        accumulator += divisor;
                    }
                }
                if( num == accumulator )
                {
                    Console.WriteLine(num);
                    counter++;
                }
            }
            Console.ReadLine();
        }
    }
}
