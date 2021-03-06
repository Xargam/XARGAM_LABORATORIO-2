using System;

//26. Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de
//cero de forma aleatoria utilizando la clase Random.
//a.Mostrar el vector tal como fue ingresado
//b.Luego mostrar los positivos ordenados en forma decreciente.
//c.Por último, mostrar los negativos ordenados en forma creciente.

namespace Ejercicio_26
{
	public class Program
	{
		private static void Main(string[] args)
		{
			int[] vector = new int[20];
			int valor;
			Random numAleatorio = new Random();

			Console.Title = "Ejercicio 26";
			for (int i = 0; i < vector.Length; i++)
			{
				valor = numAleatorio.Next(-1000, 1001);
				vector[i] = (valor == 0) ? 1 : valor;
			}
			Console.WriteLine("El vector inicial:");
			Program.MostrarVector(vector);

			Console.WriteLine("Ordenamiento decreciente de los positivos:");
			Array.Sort(vector, Program.OrdenarListaPositivos);
			Array.Reverse(vector);
			Program.MostrarVector(vector);

			Console.WriteLine("Ordenamiento creciente de los negativos:");
			Array.Sort(vector, Program.OrdenarListaNegativos);
			Program.MostrarVector(vector);
			Console.ReadLine();

		}

		private static void MostrarVector(int[] vector)
		{
			foreach ( int item in vector )
			{
				Console.WriteLine(item);
			}
		}


		private static int OrdenarListaPositivos(int entero1, int entero2)
		{
			int retorno = 0;
			if ( entero1 > entero2 && entero1 > 0 )
			{
				retorno = 1;
			}
			else if ( entero2 > entero1 && entero2 > 0 )
			{
				retorno = -1;
			}
			return retorno;
		}

		private static int OrdenarListaNegativos(int entero1, int entero2)
		{
			int retorno = 0;
			if ( entero1 < entero2 && entero1 < 0 )
			{
				retorno = -1;
			}
			else if ( entero2 < entero1 && entero2 < 0 )
			{
				retorno = 1;
			}
			return retorno;
		}

	}
}
