using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 35";
			DirectorTecnico dt1 = new DirectorTecnico("Jose", new DateTime(1996, 2, 2));
			DirectorTecnico dt2 = new DirectorTecnico("Jose", new DateTime(1996, 2, 2));
			if( dt1 == dt2)
			{
				Console.WriteLine("Iguales");
			}
			Jugador j1 = new Jugador(3948954,"Juan",10,5);
			Console.WriteLine(j1.MostrarDatos());
			Console.WriteLine(dt1.MostrarDatos());
			Console.ReadLine();

		}
	}
}
