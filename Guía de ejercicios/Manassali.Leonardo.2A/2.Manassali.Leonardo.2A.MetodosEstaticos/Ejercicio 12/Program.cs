using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor
*/

namespace Ejercicio_12
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int acumulador = 0;
			char respuesta;

			Console.Title = "Ejercicio 12";

			do
			{
				Console.WriteLine("Ingrese un número para sumar:");
				acumulador += int.Parse(Console.ReadLine());
				Console.WriteLine("¿Continuar? (S/N)");
				respuesta = Console.ReadKey(true).KeyChar;
			}
			while ( ValidarRespuesta.ValidarSN(respuesta) );

			Console.WriteLine("La suma de sus números da: {0} .", acumulador);
			Console.ReadLine();
		}
	}
}
