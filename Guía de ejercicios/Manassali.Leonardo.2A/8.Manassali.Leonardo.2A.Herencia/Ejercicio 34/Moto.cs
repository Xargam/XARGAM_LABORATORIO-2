using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Moto : VehiculoTerrestre
	{
		#region Atributos
		public short cilindrada;
		#endregion

		#region Constructor
		public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas,cantidadPuertas,color)
		{
			this.cilindrada = cilindrada;
		}
		#endregion


	}
}
