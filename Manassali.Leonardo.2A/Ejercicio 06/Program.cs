using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
6. Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.Title = "Ejercicio 06";

            do
            {
                Console.WriteLine("Ingrese un año para determinar si es bisiesto:");
                año = int.Parse(Console.ReadLine());
                if (año < 1)
                {
                    Console.WriteLine("ERROR: El año a verificar debe ser mayor a 0.");
                }
            }
            while (año < 1);
            

            if( año % 4 == 0 && año % 100 != 0 || año % 400 == 0 )
            {
                Console.WriteLine("El año {0} es bisiesto.",año);
            }
            else
            {
                Console.WriteLine("El año {0} NO es bisiesto.", año);
            }
            Console.ReadLine();
        }

    }
}
