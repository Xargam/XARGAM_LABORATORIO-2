using System;

namespace CentralitaHerencia
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Mi central
			Centralita c = new Centralita("Fede Center");
			// Mis 4 llamadas
			Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
			Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
			Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
			Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
			// Las llamadas se irán registrando en la Centralita.
			// La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
			c += l1;
			Console.WriteLine(c.ToString());
			c += l2;
			c.OrdenarLlamadas();
			Console.WriteLine(c.ToString());
			c += l3;
			c.OrdenarLlamadas();
			Console.WriteLine(c.ToString());
			c += l4;
			c.OrdenarLlamadas();
			Console.WriteLine(c.ToString());
			Console.ReadKey();
		}
	}
}
