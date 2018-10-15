using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
	public class SobreSobreescrito : Sobreescrito
	{
		#region Propiedades
		public override string MiPropiedad
		{
			get
			{
				return base._miAtributo;
			}
		}
		#endregion

		#region Metodos
		public override string MiMetodo()
		{
			return this.MiPropiedad;
		}
		#endregion
	}
}
