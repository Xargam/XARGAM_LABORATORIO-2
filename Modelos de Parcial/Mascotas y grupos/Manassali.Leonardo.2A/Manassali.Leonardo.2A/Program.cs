using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Manassali.Leonardo._2A
{
	public class Program
	{
		static void Main(string[] args)
		{
			Grupo grupo = new Grupo("Hoteleros");
			Perro m1 = new Perro("Moro", "Pitbull", 0,false);
			Perro m2 = new Perro("Moro", "Pitbull", 0 ,false);
			Perro m3 = new Perro("Ramon", "Salchicha", 3,true);
			Gato m4 = new Gato("Jose", "Angora");
			Gato m5 = new Gato("Hernan", "Cruza");
			Gato m6 = new Gato("Fer", "Siames");
			grupo += m1;
			grupo += m2;
			grupo += m2;
			grupo += m3;
			grupo += m4;
			grupo += m5;
			grupo += m6;
			grupo -= m6;
			Console.WriteLine((string)grupo);
			Console.ReadLine();
		
		}
	}
}
