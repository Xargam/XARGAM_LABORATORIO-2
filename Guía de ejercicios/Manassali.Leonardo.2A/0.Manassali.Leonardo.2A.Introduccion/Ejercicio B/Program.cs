using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Consigna: Pedir el nombre y la edad al usuario y mostrarla por pantalla.

namespace Ejercicio_B
{
	public class Program
	{
		public static void Main(string[] args)
		{
			byte edad = 0;
			string nombre = "";

			Console.Title = "Ejercicio B - Pedir datos";

			Console.WriteLine("Ingrese su nombre:");
			nombre = Console.ReadLine();

			Console.WriteLine("Ingrese su edad:");
			edad = byte.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es {0} y su edad es de {1} años.", nombre, edad);
			Console.ReadLine();
		}
	}
}
