using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 39";
			SobreSobreescrito sobre1 = new SobreSobreescrito();
			string hola = "Hola";
			Console.WriteLine(sobre1.ToString());
			Console.WriteLine(sobre1.Equals(hola));
			Console.WriteLine(sobre1.GetHashCode());
			Console.WriteLine(sobre1.MiMetodo());
			Console.WriteLine(sobre1.MiPropiedad);
			Console.ReadKey();
		}
	}
}
