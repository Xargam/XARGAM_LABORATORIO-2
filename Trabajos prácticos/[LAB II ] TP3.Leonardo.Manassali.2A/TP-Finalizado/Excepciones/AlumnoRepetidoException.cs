using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class AlumnoRepetidoException : Exception
	{
		/// <summary>
		/// Genera la excepción con un mensaje por defecto.
		/// </summary>
		#region Constructor
		public AlumnoRepetidoException() : base("Alumno repetido.")
		{
		}
		#endregion
	}
}
