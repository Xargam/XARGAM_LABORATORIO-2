using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a.valor: dato a validar
b.min y max: rango en el cual deberá estar la variable valor
*/

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for( int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el número {0} (Entre -100 y 100):",i+1);
                numero = int.Parse(Console.ReadLine());

                if( Validacion.Validar(numero, -100, 100) == true)
                {
                    Console.WriteLine("El número {0} es correcto.",numero);
                }
                else
                {
                    Console.WriteLine("El número {0} está fuera de rango.",numero);
                }
            }
        }
    }
}
