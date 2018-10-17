using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
26. Crear una aplicación de consola que cargue 20 números enteros (vector y vector) distintos de cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los vector ordenados en forma decreciente.
c. Por último, mostrar los vector ordenados en forma creciente.
*/

namespace Ejercicio_26
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] vector = new int[20];
			int aux;
			Random numAleatorio = new Random();

			Console.Title = "Ejercicio 26";
			Console.WriteLine("El vector inicial:");
			for (int i = 0; i < vector.Length; i++)
			{
				vector[i] = numAleatorio.Next(-1000,1000);
			}
			Program.MostrarVector(vector);

			Console.WriteLine("Ordenamiento decreciente de los positivos:");
			for (int i = 0; i < vector.Length-1 ; i++)
			{
				for(int j = i+1; j < vector.Length; j++ )
				{
					if( vector[i] < vector[j] && vector[j] > 0)
					{
						aux = vector[i];
						vector[i] = vector[j];
						vector[j] = aux;
					}
				}
			}
			Program.MostrarVector(vector);

			Console.WriteLine("Ordenamiento creciente de los negativos:");
			for (int i = 0; i < vector.Length-1; i++)
			{
				for (int j = i + 1; j < vector.Length; j++)
				{
					if (vector[i] > vector[j] && vector[j] < 0)
					{
						aux = vector[i];
						vector[i] = vector[j];
						vector[j] = aux;
					}
				}
				
			}
			Program.MostrarVector(vector);
			Console.ReadLine();

		}

		private static void MostrarVector(int[] vector)
		{
			foreach (int item in vector)
			{
				Console.WriteLine(item);
			}
		}
	}
}
