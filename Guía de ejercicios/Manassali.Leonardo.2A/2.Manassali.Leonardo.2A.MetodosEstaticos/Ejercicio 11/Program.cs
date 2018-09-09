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
b.min y max: rango en el cual deberá estar la variable valor.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.
*/

namespace Ejercicio_11
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int acumulador = 0;
			int minimo = 0;
			int maximo = 0;
			int number;
			float promedio;

			Console.Title = "Ejercicio 11"; 

			for( int iteracion = 0; iteracion < 10; iteracion++ )
			{
				do
				{
					Console.WriteLine("Ingrese un número (-100 a 100):");
					number = int.Parse(Console.ReadLine());
					if(!Validacion.Validar(number, -100, 100) )
					{
						Console.WriteLine("ERROR: Fuera de rango.\n");
					}
				}
				while (!Validacion.Validar(number, -100, 100));

				acumulador += number; 
				if( iteracion == 0)
				{
					maximo = minimo = number;
				}
				else if( number > maximo )
				{
					maximo = number;
				}
				else if(number < minimo )
				{
					minimo = number;
				}
			}
			promedio = (float)(acumulador / 10.0);
			Console.WriteLine("Valor máximo: {0} . Valor mínimo: {1} . Promedio {2} .", maximo , minimo , promedio);
			Console.ReadLine();
			
		}
	}
}
