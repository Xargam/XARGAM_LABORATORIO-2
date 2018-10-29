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
			Fahrenheit grados1 = 70;
			Kelvin grados2 = -550;
			Celsius grados3 = 100;

			Console.Title = "Ejercicio 21";
			Console.WriteLine( (grados1 + grados2).GetGrados() );
			Console.ReadLine();
		}
	}
}
