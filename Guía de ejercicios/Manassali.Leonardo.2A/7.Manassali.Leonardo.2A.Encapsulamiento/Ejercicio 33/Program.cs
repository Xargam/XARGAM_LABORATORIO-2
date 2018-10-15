using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 33";
			Libro l = new Libro();
			l[2] = "Hotel";
			l[1] = "Hotel2";
			l[2] = "Hotel3";
			Console.WriteLine(l[0]);
			Console.WriteLine(l[1]);
			Console.WriteLine(l[500]);
			Console.WriteLine(l[2]);

			Console.ReadLine();
		}
	}
}
