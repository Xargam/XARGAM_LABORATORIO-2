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
	public class Program
	{
		public static void Main(string[] args)
		{
			int numUsuario;
			bool flag;

			Console.Title = "Ejercicio 03";

			Console.WriteLine("Ingrese un número entero mayor a 1 para buscar los numeros primos previos:");
			numUsuario = int.Parse(Console.ReadLine());
			
			if (numUsuario > 1)
			{
				Console.WriteLine("Números primos encontrados:\n");
				for (int posibleNumPrimo = 2 ; posibleNumPrimo <= numUsuario ; posibleNumPrimo++ )
				{
					flag = true;
					for (int divisor = 2; divisor < posibleNumPrimo; divisor++)
					{
						if (posibleNumPrimo % divisor == 0)
						{
							flag = false;
							break;
						}
					}
					if (flag == true)
					{
						Console.WriteLine("{0}", posibleNumPrimo);
					}
				}
			}
			else
			{
				Console.WriteLine("El numero ingresado es menor que 2. No se hallo ningún número primo.");
			}
			Console.ReadLine();
		}
	}
}
