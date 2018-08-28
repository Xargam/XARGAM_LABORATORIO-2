using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

/*
12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.
*/

namespace Ejercicio_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char respuesta;

            int numero1;
            int numero2;

            do
            {
                Console.WriteLine("Ingrese el número 1:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 2:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2} .",numero1 , numero2 , numero2+numero1);
                Console.WriteLine("Continuar? S/N");
                respuesta = Console.ReadKey(false).KeyChar;
                Console.Write("\n");
            }
            while ( ValidarRespuesta.ValidarSiNo(respuesta));
            Console.ReadLine();
        }
    }
}
