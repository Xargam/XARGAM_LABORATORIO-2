using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
5. Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista(1 a
49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
*/

//Formula para sumar numeros consecutivos desde el 1:   M.(M+1)/2 Donde M es el ultimo numero de la sucesion de sumas.
//Formula para sumar rango numerico de manera consecutiva:   (nf-ni+1)*(nf+ni)/2  Donde nf es numero final y numero inicial.


namespace Ejercicio_05
{
    public class Ejercicio5
    {
        public static void Main(string[] args)
        {
            bool flag = false;
            int number;
            int sumatoria = 2;
            Int64 accumulatorPre = 1;
            Int64 accumulatorPost = 0;

            Console.Title = "Ejercicio 05";

            do
            {
                Console.WriteLine("Ingrese un numero maximo para hallar centros numéricos:");
                number = int.Parse(Console.ReadLine());
                if( number < 2 )
                {
                    Console.WriteLine("Error: El numero a ingresar debe ser mayor a 1\n");
                }
            }
            while (number < 2);
                            
            for (int centro = 2; centro <= number && sumatoria < number ; centro++)
            {
                while (accumulatorPost < accumulatorPre && sumatoria < number)
                {
                    sumatoria++;
                    accumulatorPost += sumatoria;
                }
                if (accumulatorPost == accumulatorPre)
                {
                    Console.WriteLine("Rango: 1 a {1} , Centro numérico: {0}.", centro, sumatoria);
                    flag = true;
                }
                accumulatorPre += centro;
                accumulatorPost -= centro + 1;
            }
            if(  flag == false )
            {
                Console.WriteLine("No se han encontrado centros numericos en el rango que estableció.");
            }
            Console.ReadLine();
        }
    }
}
