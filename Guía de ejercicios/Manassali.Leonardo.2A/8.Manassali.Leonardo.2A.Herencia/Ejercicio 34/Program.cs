using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 34";
			VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 4, Colores.Blanco);
			Console.WriteLine("VEHICULO: Puertas: {0} Ruedas: {1} Color: {2}",vehiculo.cantidadPuertas, vehiculo.cantidadRuedas, vehiculo.color.ToString());


			Automovil auto = new Automovil(4, 4, Colores.Azul, 5, 2);
			Console.WriteLine("Automovil: Puertas: {0} Ruedas: {1} Color: {2} Marchas {3} Pasajeros: {4}", auto.cantidadPuertas, auto.cantidadRuedas, auto.color.ToString(),auto.cantidadMarchas,auto.cantidadPasajeros);


			Camion camion = new Camion(6, 4, Colores.Azul,5,1000);
			Console.WriteLine("Camion: Puertas: {0} Ruedas: {1} Color: {2} Marchas {3} Carga: {4}", camion.cantidadPuertas, camion.cantidadRuedas, camion.color.ToString(), camion.cantidadMarchas, camion.pesoCarga);


			Moto moto = new Moto(2, 0, Colores.Blanco, 450);
			Console.WriteLine("Moto: Puertas: {0} Ruedas: {1} Color: {2} Cilindrada {3}", moto.cantidadPuertas, moto.cantidadRuedas, moto.color.ToString(), moto.cilindrada);

			Console.ReadLine();
		}
	}
}
