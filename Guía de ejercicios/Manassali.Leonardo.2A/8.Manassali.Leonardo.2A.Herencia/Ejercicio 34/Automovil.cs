using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Automovil : VehiculoTerrestre
	{
		#region Atributos
		public short cantidadMarchas;
		public int cantidadPasajeros;
		#endregion

		#region Constructor
		public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
		{
			this.cantidadMarchas = cantidadMarchas;
			this.cantidadPasajeros = cantidadPasajeros;
		}
		#endregion



	}
}
