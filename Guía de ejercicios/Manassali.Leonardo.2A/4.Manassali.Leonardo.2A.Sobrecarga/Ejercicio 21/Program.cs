using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grados;

namespace Ejercicio_21
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 21";
			Fahrenheit grados = 70;
			Kelvin grados2 = -550;
			Celsius grados3 = 100;
			grados += grados + grados3;

			Console.WriteLine(grados);
			Console.ReadLine();
		}
	}
}
