using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportes;

namespace Ejercicio_29
{
	public class Program
	{
		static void Main(string[] args)
		{
			Equipo equipo = new Equipo(10, "Hoteles");
			Jugador jugador1 = new Jugador(39489767, "Leo",50,10);
			Jugador jugador2 = new Jugador(39489768, "Leo2");
			Jugador jugador3 = new Jugador(39489769, "Leo3");
			Jugador jugador4 = new Jugador(39489710, "Leo4");
			Jugador jugador5 = new Jugador(39489711, "Leo5");
			jugador1.GetPromedioGoles();
			Console.WriteLine(jugador1.MostrarDatos());
			
			Console.ReadLine();
		}
	}
}
