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
			Random numAleatorio = new Random();

			Console.Title = "Ejercicio 26";
			Console.WriteLine("El vector inicial:");
			for (int i = 0; i < vector.Length; i++)
			{
				vector[i] = numAleatorio.Next(-1000,1000);
			}
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
			foreach (int item in vector)
			{
				Console.WriteLine(item);
			}
		}


    private static int OrdenarListaPositivos(int entero1, int entero2)
    {
      int retorno = 0;
      if (entero1 > entero2 && entero1 > 0)
      {
        retorno = 1;
      }
      else if (entero2 > entero1 && entero2 > 0)
      {
        retorno = -1;
      }
      return retorno;
    }

    private static int OrdenarListaNegativos(int entero1, int entero2)
    {
      int retorno = 0;
      if (entero1 < entero2 && entero1 < 0)
      {
        retorno = -1;
      }
      else if (entero2 < entero1 && entero2 < 0)
      {
        retorno = 1;
      }
      return retorno;
    }

  }
}
