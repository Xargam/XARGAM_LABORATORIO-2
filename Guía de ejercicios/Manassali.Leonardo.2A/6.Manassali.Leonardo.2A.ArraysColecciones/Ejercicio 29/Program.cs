using System;

namespace Ejercicio_29
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Equipo equipo = new Equipo(2, "Hoteles");
			Jugador jugador1 = new Jugador(39489767, "Leo", 50, 10);
			Jugador jugador2 = new Jugador(39489768, "Leo2");
			Jugador jugador3 = new Jugador(39489769, "Leo3");
			Jugador jugador4 = new Jugador(39489710, "Leo4");
			Jugador jugador5 = new Jugador(39489711, "Leo5");
			jugador1.GetPromedioGoles();
			if ( equipo + jugador1 )
			{
				Console.WriteLine("Jugador agregado.");
				Console.WriteLine("Su promedio de goles es: {0}.",jugador1.GetPromedioGoles());
			}
			if ( !(equipo + jugador1) )
			{
				Console.WriteLine("No se pudo agregar el jugador.");
			}
			if ( equipo + jugador2 )
			{
				Console.WriteLine("Jugador agregado.");
			}
			if ( !(equipo + jugador3) )
			{
				Console.WriteLine("No se pudo agregar el jugador.");
			}
			Console.WriteLine(jugador1.MostrarDatos());
			Console.WriteLine(jugador2.MostrarDatos());
			Console.WriteLine(jugador3.MostrarDatos());
			Console.ReadLine();
		}
	}
}
