using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 31";
			Negocio negocio1 = new Negocio("Trivago");
			Cliente c1 = new Cliente(1, "Jorge");
			Cliente c2 = new Cliente(1, "Jorge");
			Cliente c3 = new Cliente(1, "Jorge");
			Cliente c4 = new Cliente(1, "Jorge");
			Cliente c5 = new Cliente(170, "Jorge");

			for(int i = 0; i < 3; i++)
			{
				Console.WriteLine(PuestoAtencion.NumeroActual);
			}
			negocio1.Cliente = c1;
			negocio1.Cliente = c2;
			negocio1.Cliente = c3;
			negocio1.Cliente = c4;
			negocio1.Cliente = c5;

			if( ~negocio1 )
			{
				Console.WriteLine("Quedan {0} clintes",negocio1.ClientesPendientes);
			}
			if (~negocio1)
			{
				Console.WriteLine("Quedan {0} clintes", negocio1.ClientesPendientes);
			}
			if (~negocio1)
			{
				Console.WriteLine("Quedan {0} clintes", negocio1.ClientesPendientes);
			}
			if (~negocio1)
			{
				Console.WriteLine("Quedan {0} clintes", negocio1.ClientesPendientes);
			}
			if (~negocio1)
			{
				Console.WriteLine("Quedan {0} clintes", negocio1.ClientesPendientes);
			}
			if (~negocio1)
			{
				Console.WriteLine("Quedan {0} clintes", negocio1.ClientesPendientes);
			}

		}
	}
}
