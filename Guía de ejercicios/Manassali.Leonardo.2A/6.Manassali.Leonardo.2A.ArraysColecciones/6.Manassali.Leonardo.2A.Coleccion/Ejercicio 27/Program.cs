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
/*
27. Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas.
*/
namespace Ejercicio_27
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> lista = new List<int>();  
			Queue<int> cola = new Queue<int>();  
			Stack<int> pila = new Stack<int>();

			Random numAleatorio = new Random();
			for (int i = 0; i < 20; i++)
			{
				lista.Add(numAleatorio.Next(-1000 , 1000) );
				Console.WriteLine(lista[i]);
			}
			for (int i = 0; i < lista.Count; i++)
			{
				
			}
			Console.Title = "Ejercicio 27";
			Console.ReadLine();
		}
	}
}
