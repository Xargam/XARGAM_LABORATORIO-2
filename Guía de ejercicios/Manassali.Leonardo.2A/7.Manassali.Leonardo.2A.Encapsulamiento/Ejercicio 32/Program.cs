using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportes;

namespace Ejercicio_32
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 32";
			Jugador j1 = new Jugador(39489767, "Leo", 10, 5);
			Jugador j2 = new Jugador(39489767, "Leo", 100, 5);
			Jugador j3 = new Jugador(3949767, "Leo", 5, 5);
			Jugador j4 = new Jugador(389767, "Leo", 5, 5);
			Jugador j5 = new Jugador(89767, "Leo", 5,1);
			Jugador j6 = new Jugador(3767, "Leo");
			Equipo e1 = new Equipo(4, "Hoteleros");
			if(e1 + j1);
			if(e1 + j2);
			if(e1 + j3);
			if(e1 + j4);
			if(e1 + j5);
			if(e1 + j6);
			
			Console.WriteLine(j2.MostrarDatos());
			Console.WriteLine(j3.MostrarDatos());
			Console.WriteLine(j4.MostrarDatos());
			Console.WriteLine(j5.MostrarDatos());
			Console.WriteLine(j6.MostrarDatos());
			Console.ReadLine();

		}
	}
}
