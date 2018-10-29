using System;

/*
5. Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista(1 a
49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
*/

namespace Ejercicio_05
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Int64 accumulatorPre = 1; //Acumula sumas desde 1 hasta el posible centro numérico - 1.
			Int64 accumulatorPost = 0; //Acumula sumas desde el posible centro numérico + 1 en adelante.
			bool flag = false; // Bandera que establece si se encontró algún centro numérico.
			int number; //Número que el usuario ingresa.
			int rango = 2; //Rango hasta el que se busca un centro numérico.

			Console.Title = "Ejercicio 05";

			Console.WriteLine("Ingrese un numero maximo para hallar centros numéricos:");
			number = int.Parse(Console.ReadLine());
			Console.WriteLine("Centros numéricos hallados:\n");

			for (int posibleCentro = 2; posibleCentro <= number ; posibleCentro++)
			{
				while (accumulatorPre > accumulatorPost )
				{
					rango++; //Subo el rango de búsqueda mientras haya posibilidad de centro numérico.
					accumulatorPost += rango; //Voy realizando sumas consecutivas.
				}
				//Si los acumuladores son iguales se encontró un centro.
				if (accumulatorPost == accumulatorPre)
				{
					Console.WriteLine("Rango: 1 a {0} , Centro numérico: {1}.",rango,posibleCentro);
					flag = true;
				}
				//se buscará un posible centro incrementado en uno.
				accumulatorPre += posibleCentro; 
				accumulatorPost -= posibleCentro + 1; 
			}
			if (flag == false)
			{
				Console.WriteLine("No se han encontrado centros numericos en el rango que estableció.");
			}
			Console.ReadLine();
		}
	}
}
