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
	public class Program
	{
		public static void Main(string[] args)
		{
			int counter = 0;
			int accumulator;

			Console.Title = "Ejercicio 04";

			Console.WriteLine("Primeros 4 números perfectos:\n");
			for (int posibleNumPerfecto = 2; counter < 4; posibleNumPerfecto++)
			{
				accumulator = 1;
				for (int divisor = 2; divisor < posibleNumPerfecto; divisor++)
				{
					if (posibleNumPerfecto % divisor == 0)
					{
						accumulator += divisor;
					}
				}
				if (posibleNumPerfecto == accumulator)
				{
					Console.WriteLine(posibleNumPerfecto);
					counter++;
				}
			}
			Console.ReadLine();
		}
	}
}
