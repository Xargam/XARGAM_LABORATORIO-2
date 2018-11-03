using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class NacionalidadInvalidaException : Exception
	{
		#region Constructor
		public NacionalidadInvalidaException() : this("Se intentó ingresar un DNI para un objeto de tipo Persona fuera del rango de valores admitido.Este intervalo permitido va de 1 a 89999999 inclusive para nacionalidad Argentina y de 90000000 a 99999999 inclusive para nacionalidad extranjera.")
		{
		}
		public NacionalidadInvalidaException(string message) : base(message)
		{
		}
		#endregion
	}
}
