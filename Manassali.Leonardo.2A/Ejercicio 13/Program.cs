using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin;

            Console.WriteLine("Ingrese un numero para transformarlo a binario:");
            double numero = double.Parse(Console.ReadLine());

            bin = Conversor.DecimalBinario(numero);
            Console.WriteLine("El numero {1} en base 2 es : {0} .",bin,numero);

            Console.WriteLine("Ingrese un numero binario para transformarlo a decimal:");
            bin = Console.ReadLine();
            numero = Conversor.BinarioDecimal(bin);
            Console.WriteLine("El numero {0} en base 10 es : {1} .", bin, numero);

            Console.ReadLine();
        }
    }
}
