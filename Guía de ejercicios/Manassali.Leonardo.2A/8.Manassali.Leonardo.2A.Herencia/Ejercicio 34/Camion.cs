using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Camion : VehiculoTerrestre
	{
		#region Atributos
		public short cantidadMarchas;
		public int pesoCarga;
		#endregion

		#region Constructor
		public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
		{
			this.cantidadMarchas = cantidadMarchas;
			this.pesoCarga = pesoCarga;
		}
		#endregion
	}
}
