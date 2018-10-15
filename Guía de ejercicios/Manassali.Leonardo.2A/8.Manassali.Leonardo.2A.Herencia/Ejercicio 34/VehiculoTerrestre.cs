using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class VehiculoTerrestre
	{
		#region Atributos
		public short cantidadRuedas;
		public short cantidadPuertas;
		public Colores color;
		#endregion

		#region Constructor
		public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas , Colores color)
		{
			this.cantidadRuedas = cantidadRuedas;
			this.cantidadPuertas = cantidadPuertas;
			this.color = color;
		}
		#endregion
	}

}
