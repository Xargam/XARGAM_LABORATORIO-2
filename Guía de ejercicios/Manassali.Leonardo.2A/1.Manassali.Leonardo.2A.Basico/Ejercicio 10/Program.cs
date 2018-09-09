using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:
								   *
								  ***
								 *****
							    *******
						       *********
Nota: Utilizar estructuras repetitivas y selectivas
*/

namespace Ejercicio_10
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int altura;

			Console.Title = "Ejercicio 10";
			// Pido altura y valido. Mayor a 41 la estetica se pierde.
			do
			{
				Console.WriteLine("Ingrese altura de la pirámide a generar:");
				altura = int.Parse(Console.ReadLine());
				if (altura < 1 || altura > 40)
				{
					Console.WriteLine("La altura de la pirámide debe estar entre 1 y 40.\n");
				}
			}
			while (altura < 1 || altura > 40);

			//Genero la pirámide.
			Console.Write("\n\n");
			for (int linea = 0, espacios = 39 , asteriscos = 1 ; linea < altura ; linea++ , espacios--,asteriscos+=2)
			{
				for (int iteracion = 0; iteracion < espacios; iteracion++)
				{
					Console.Write(' ');
				}
				for(int iteracion = 0; iteracion < asteriscos; iteracion++ )
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
