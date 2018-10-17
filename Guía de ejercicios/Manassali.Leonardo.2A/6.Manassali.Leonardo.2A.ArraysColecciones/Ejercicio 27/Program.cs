using System;
using System.Collections.Generic;

namespace Ejercicio_27
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> listaEnteros = new List<int>();
			Queue<int> colaEnteros = new Queue<int>();
			Stack<int> pilaEnteros = new Stack<int>();
			int[] arrayIntermedio;
			int valor;
			Random random = new Random();

			Console.Title = "Ejercicio 27";
			for (int i = 0; i < 20; i++)
			{
				valor = random.Next(-1000, 1000);
				listaEnteros.Add(valor);
				colaEnteros.Enqueue(valor);
				pilaEnteros.Push(valor);
			}
			Console.WriteLine("La lista tal como fue ingresada:");
			Program.MostrarVector(listaEnteros.ToArray());
			Console.WriteLine("La pila tal como fue ingresada:");
			Program.MostrarVector(pilaEnteros.ToArray());
			Console.WriteLine("La cola tal como fue ingresada:");
			Program.MostrarVector(colaEnteros.ToArray());
			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("La lista en orden: positivos-decreciente");
			listaEnteros.Sort(Program.OrdenarListaPositivos);
			listaEnteros.Reverse();
			Program.MostrarVector(listaEnteros.ToArray());

			Console.WriteLine("La lista en orden: negativos-creciente");
			listaEnteros.Sort(Program.OrdenarListaNegativos);
			Program.MostrarVector(listaEnteros.ToArray());
			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("La pila en orden: positivos-decreciente");

			arrayIntermedio = pilaEnteros.ToArray();
			pilaEnteros.Clear();

			Array.Sort(arrayIntermedio, Program.OrdenarListaPositivos);
			Array.Reverse(arrayIntermedio);

			for(int i = arrayIntermedio.Length -1; i >= 0 ; i-- )
			{
				pilaEnteros.Push(arrayIntermedio[i]);
			}
			Program.MostrarVector(pilaEnteros.ToArray());

			Console.WriteLine("La pila en orden: negativos-creciente");

			arrayIntermedio = pilaEnteros.ToArray();
			pilaEnteros.Clear();

			Array.Sort(arrayIntermedio, Program.OrdenarListaNegativos);
			for (int i = arrayIntermedio.Length - 1; i >= 0; i--)
			{
				pilaEnteros.Push(arrayIntermedio[i]);
			}
			Program.MostrarVector(pilaEnteros.ToArray());
			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("La cola en orden: positivos-decreciente");

			arrayIntermedio = colaEnteros.ToArray();
			colaEnteros.Clear();

			Array.Sort(arrayIntermedio, Program.OrdenarListaPositivos);
			Array.Reverse(arrayIntermedio);

			foreach (int item in arrayIntermedio)
			{
				colaEnteros.Enqueue(item);
			}
			Program.MostrarVector(colaEnteros.ToArray());
			Console.WriteLine("La cola en orden: negativos-creciente");

			arrayIntermedio = colaEnteros.ToArray();
			colaEnteros.Clear();

			Array.Sort(arrayIntermedio, Program.OrdenarListaNegativos);

			foreach (int item in arrayIntermedio)
			{
				colaEnteros.Enqueue(item);
			}
			Program.MostrarVector(colaEnteros.ToArray());
			Console.ReadKey();
			

		}


		private static int OrdenarListaPositivos(int entero1, int entero2)
		{
			int retorno = 0;
			if( entero1 > entero2 && entero1 > 0)
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

		private static void MostrarVector(int[] vector)
		{
			foreach (int item in vector)
			{
				Console.WriteLine(item);
			}
		}
	}
}
