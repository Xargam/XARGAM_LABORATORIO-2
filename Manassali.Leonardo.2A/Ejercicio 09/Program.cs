using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
9. Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas
*/

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int asteriscos = 1;

            Console.Title = "Ejercicio 09";
            do
            {
                Console.WriteLine("Ingrese altura de la pirámide a generar:");
                altura = int.Parse(Console.ReadLine());
                if( altura < 1 || altura > 41)
                {
                    Console.WriteLine("La altura de la pirámide debe estar entre 1 y 41.\n");
                }
            }
            while(altura < 1 || altura > 41);

            Console.Write("\n\n");
            for(int i = 0; i < altura ; i++ )
            {
                for(int j = 1; j <= asteriscos; j++)
                {
                    Console.Write("*");
                }
                asteriscos += 2;
                Console.WriteLine();
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
