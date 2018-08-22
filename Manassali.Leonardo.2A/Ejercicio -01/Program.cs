using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2. Siendo la 
 * definición de número primo “un número natural mayor que 1 que tiene únicamente dos divisores distintos: 
 * él mismo y el 1.”:
A. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 * 
 * */
namespace Ejercicio__01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int flag;
            Console.WriteLine("Ingrese un numero para obtener primos:");
            numero = int.Parse(Console.ReadLine());
            for(int i = 2; i <= numero; i++ )
            {
                flag = 1;
                for(int j = 2; j < i; j++)
                {
                    if( i % j == 0 )
                    {
                        flag = 0;
                        break;
                    }
                }
                if( flag == 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}
