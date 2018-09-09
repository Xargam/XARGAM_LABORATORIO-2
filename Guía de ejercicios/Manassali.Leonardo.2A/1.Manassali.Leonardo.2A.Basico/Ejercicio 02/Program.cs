using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

namespace Ejercicio_02
{
	public class Program
	{
		public static void Main(string[] args)
		{
			float number;

			Console.Title = "Ejercicio 02";

			do
			{
				Console.WriteLine("Ingrese un número:");
				number = float.Parse(Console.ReadLine());

				if( number < 1 )
				{
					Console.WriteLine("ERROR. ¡Reingresar número!\n");
				}
			}
			while (number < 1);

			Console.WriteLine("El cuadrado de {0} es {1:#,#.00} y el cubo es {2:#,#.00} .", number, Math.Pow(number, 2), Math.Pow(number, 3));
			Console.ReadLine();
		}
	}
}
