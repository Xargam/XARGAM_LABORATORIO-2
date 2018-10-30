using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

//b.Crear un proyecto del tipo Console:
//i.Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
//ii.Crear 3 equipos de cada tipo.
//iii.Agregar los equipos en tantos torneos como se pueda.
//iv.Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
//v.Llamar al menos 3 veces a la propiedad
namespace TestEntidades
{
	class Program
	{
		static void Main(string[] args)
		{
			EquipoBasquet b1 = new EquipoBasquet("Argentinos",new DateTime(1996,7,2),"100");
			EquipoBasquet b2 = new EquipoBasquet("Brasileños",new DateTime(1996,8,2),"75");
			EquipoBasquet b3 = new EquipoBasquet("Uruguayos",new DateTime(1996,9,2),"50");

			EquipoFutbol f1 = new EquipoFutbol("River", new DateTime(1996, 7, 2), "Armani");
			EquipoFutbol f2 = new EquipoFutbol("Boca", new DateTime(1996, 8, 2), "Orion");
			EquipoFutbol f3 = new EquipoFutbol("Banco Central", new DateTime(1996, 9, 2), "Kputo");

			Torneo<EquipoFutbol> libertadores = new Torneo<EquipoFutbol>("Copa Libertadores de America");
			Torneo<EquipoBasquet> nba = new Torneo<EquipoBasquet>("Copa NBA USA");
			libertadores += f1;
			libertadores += f2;
			libertadores += f3;

			nba += b1;
			nba += b2;
			nba += b3;

			Console.WriteLine(libertadores.Mostrar());
			Console.WriteLine(nba.Mostrar());
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(libertadores.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);

			Console.ReadKey();

		}
	}
}
