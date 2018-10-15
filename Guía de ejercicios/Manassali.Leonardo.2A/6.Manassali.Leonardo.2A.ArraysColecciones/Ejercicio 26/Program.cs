using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente.
*/

namespace Ejercicio_26
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] vector = new int[20];
			int[] positivos = new int[20];
			int[] negativos = new int[20];
			int aux;
			Random numAleatorio = new Random();

			Console.Title = "Ejercicio 26";
			Console.WriteLine("El vector:");
			for (int i = 0,j = 0,k = 0; i < 20; i++)
			{
				vector[i] = numAleatorio.Next(-1000,1000);
				if( vector[i] > 0)
				{
					positivos[j++] = vector[i];
				}
				else
				{
					negativos[k++] = vector[i];
				}
				Console.WriteLine(vector[i]);
			}
			Console.WriteLine("Ordenamiento decreciente:");
			for (int i = 0; i < positivos.Length-1 ; i++)
			{
				for(int j = i+1; j < positivos.Length; j++ )
				{
					if( positivos[i] < positivos[j] )
					{
						aux = positivos[i];
						positivos[i] = positivos[j];
						positivos[j] = aux;
					}
				}
				Console.WriteLine(positivos[i]);
			}
			Console.WriteLine("Ordenamiento creciente:");
			for (int i = 0; i < negativos.Length-1; i++)
			{
				for (int j = i + 1; j < negativos.Length; j++)
				{
					if (negativos[i] > negativos[j])
					{
						aux = negativos[i];
						negativos[i] = negativos[j];
						negativos[j] = aux;
					}
				}
				Console.WriteLine(negativos[i]);
			}
			Console.ReadLine();
		}
	}
}
