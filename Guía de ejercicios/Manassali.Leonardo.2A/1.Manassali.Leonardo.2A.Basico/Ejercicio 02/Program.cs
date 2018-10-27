using System;

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

			Console.WriteLine("Ingrese un número:");
			number = float.Parse(Console.ReadLine());

			if ( number < 1 )
			{
				Console.WriteLine("ERROR. ¡Reingresar número!\n");
			}
			else
			{
				Console.Write("El cuadrado de {0} es {1:#,#.00} ", number, Math.Pow(number, 2));
				Console.Write("y el cubo es {0:#,#.00} .", Math.Pow(number, 3));
			}

			Console.ReadLine();
		}
	}
}
