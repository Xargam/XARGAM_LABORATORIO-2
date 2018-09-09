using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

namespace Ejercicio_14
{
	public class Program
	{
		public static void Main(string[] args)
		{
			double lado;
			double baseT;
			double altura;
			double radio;

			Console.Title = "Ejercicio 14";

			Console.WriteLine("Ingrese la medida de un lado de cuadrado:");
			lado = double.Parse(Console.ReadLine());
			Console.WriteLine("El area de su cuadrado es de {0} cm.", CalculoDeArea.CalcularCuadrado(lado));

			Console.WriteLine("Ingrese la base de su triángulo:");
			baseT = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la altura de su triángulo:");
			altura = double.Parse(Console.ReadLine());
			Console.WriteLine("El area de su triángulo es de {0} cm.", CalculoDeArea.CalcularTriangulo(baseT,altura));

			Console.WriteLine("Ingrese el radio de su círculo:");
			radio = double.Parse(Console.ReadLine());
			Console.WriteLine("El area de su círculo es de {0} cm.", CalculoDeArea.CalcularCirculo(radio));
			Console.ReadLine();
		}
	}
}
