using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class AlumnoRepetidoException : Exception
	{
		#region Constructor
		public AlumnoRepetidoException() : base("Alumno NO agregado, ya se encuentra en la lista.")
		{
		}
		#endregion
	}
}
