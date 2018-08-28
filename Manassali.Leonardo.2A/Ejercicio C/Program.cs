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
namespace EjercicioC
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;

            Console.WriteLine("Ingrese un numero para obtener primos:");
            numero = int.Parse(Console.ReadLine());

            for(int num = 2; num <= numero; num++ )
            {
                flag = true;
                for(int divisor = 2; divisor < num; divisor++)
                {
                    if( num % divisor == 0 )
                    {
                        flag = false;
                        break;
                    }
                }
                if( flag == true)
                {
                    Console.WriteLine("{0}", num);
                }
            }
            Console.ReadLine();

        }
    }
}
