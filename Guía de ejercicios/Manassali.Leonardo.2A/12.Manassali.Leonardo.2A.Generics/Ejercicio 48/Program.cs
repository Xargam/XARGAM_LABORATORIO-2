using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
	class Program
	{
		static void Main(string[] args)
		{
			//Lo testeo por depuracion por que los atributos son todos privados y no hay forma de accederlos.
			Factura f1 = new Factura(100);
			Factura f2 = new Factura(100);
			Factura f3 = new Factura(100);
			Factura f4 = new Factura(100);

			Recibo r1 = new Recibo(500);
			Recibo r2 = new Recibo(500);
			Recibo r3 = new Recibo(500);
			Recibo r4 = new Recibo(500);

			Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

			contabilidad += f1;
			contabilidad += f1;
			contabilidad += f1;
			contabilidad += f2;
			contabilidad += f3;
			contabilidad += f4;
			contabilidad += r1;
			contabilidad += r1;
			contabilidad += r1;
			contabilidad += r2;
			contabilidad += r3;
			contabilidad += r4;

			Console.ReadKey();
		}
	}
}
