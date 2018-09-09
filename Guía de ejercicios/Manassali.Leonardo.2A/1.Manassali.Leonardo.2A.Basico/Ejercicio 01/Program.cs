using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.
*/

namespace Ejercicio_01
{
	public class Program
	{
		public static void Main(string[] args)
		{
			float acumulador = 0;
			float maximo = 0;
			float minimo = 0;
			float promedio;
			float numero;

			Console.Title = "Ejercicio 01";
			for( int iteration = 0 ; iteration < 5 ; iteration++ )
			{
				Console.WriteLine("Ingrese un numero:");
				numero = float.Parse( Console.ReadLine() );

				acumulador += numero;
				if( iteration == 0 )
				{
					minimo = maximo = numero;
				}
				else if( numero > maximo )
				{
					maximo = numero;
				}
				else if( numero < minimo )
				{
					minimo = numero;
				}
			}

			promedio = acumulador / 5;
			Console.WriteLine("El promedio es {0} . Valor máximo: {1} , valor mínimo: {2} .", promedio, maximo, minimo);
			Console.ReadLine();
		}
	}
}
