using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_47_test
{
	class Program
	{
		//b.Crear un proyecto del tipo Console:
		//i.Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
		//ii.Crear 3 equipos de cada tipo.
		//iii.Agregar los equipos en tantos torneos como se pueda.
		//iv.Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
		//v.Llamar al menos 3 veces a
		static void Main(string[] args)
		{
			Torneo<EquipoFutbol> copaLibertadores = new Torneo<EquipoFutbol>("Conmebol Libertadores");
			Torneo<EquipoBasquet> nba = new Torneo<EquipoBasquet>("NBA Torneo");

			EquipoBasquet equipob1 = new EquipoBasquet("Paolo Roca", new DateTime(1995, 5, 10));
			EquipoBasquet equipob2 = new EquipoBasquet("Milei", new DateTime(2005, 7, 20));
			EquipoBasquet equipob3 = new EquipoBasquet("KPuto", new DateTime(1996, 7, 2));

			EquipoFutbol equipof1 = new EquipoFutbol("Boca", new DateTime(1995, 5, 10));
			EquipoFutbol equipof2 = new EquipoFutbol("River", new DateTime(2005, 7, 20));
			EquipoFutbol equipof3 = new EquipoFutbol("Gimnasia", new DateTime(1996, 7, 2));

			copaLibertadores += equipof1;
			copaLibertadores += equipof1;
			copaLibertadores += equipof1;
			copaLibertadores += equipof3;
			copaLibertadores += equipof2;
			copaLibertadores += equipof3;

			nba += equipob1;
			nba += equipob1;
			nba += equipob2;
			nba += equipob2;
			nba += equipob3;
			nba += equipob3;

			Console.WriteLine(copaLibertadores.Mostrar());
			Console.WriteLine(nba.Mostrar());

			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
			Console.WriteLine(copaLibertadores.JugarPartido);
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
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.WriteLine(nba.JugarPartido);
			Console.ReadKey();
		}
	}
}
