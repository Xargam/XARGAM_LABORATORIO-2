using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class SinProfesorException : Exception
	{
		#region Constructor
		/// <summary>
		/// Genera la excepción con un mensaje por defecto.
		/// </summary>
		public SinProfesorException() : base("No hay profesor para la clase.")
		{
		}
		#endregion
	}
}
