using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
9. Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas
*/

namespace Ejercicio_09
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int altura;

			Console.Title = "Ejercicio 09";
			// Pido altura y valido. Mayor a 41 la estetica se pierde.
			do
			{
				Console.WriteLine("Ingrese altura de la pirámide a generar:");
				altura = int.Parse(Console.ReadLine());
				if (altura < 1 || altura > 41)
				{
					Console.WriteLine("La altura de la pirámide debe estar entre 1 y 41.\n");
				}
			}
			while (altura < 1 || altura > 41);

			//Genero la pirámide.
			Console.Write("\n\n");
			for (int linea = 0 , asteriscos = 1 ; linea < altura; linea++ , asteriscos += 2 )
			{
				for( int iteracion = 0; iteracion < asteriscos; iteracion++ )
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
