using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)
*/

namespace Ejercicio_03
{
    public class Ejercicio_3
    {
        public static void Main(string[] args)
        {
            int number;
            bool flag;

            Console.Title = "Ejercicio 03";

            Console.WriteLine("Ingrese un numero entero mayor a 1 para buscar los numeros primos previos:");
            number = int.Parse(Console.ReadLine());

            if( number > 1 )
            {
                for (int num = 2; num <= number; num++)
                {
                    flag = true;
                    for (int divisor = 2; divisor < num; divisor++)
                    {
                        if (num % divisor == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("{0}",num);
                    }
                }
            }
            else
            {
                Console.WriteLine("El numero ingresado es menor a 2 por lo cual no se pudieron encontrar números primos.");
            }
        Console.ReadLine();

        }
    }
}
