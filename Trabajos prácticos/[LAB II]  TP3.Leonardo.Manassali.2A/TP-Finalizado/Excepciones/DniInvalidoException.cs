using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class DniInvalidoException : Exception
	{
		#region Atributos
		private const string mensajeBase = "El formato del DNI no es correcto. Este debe ser numérico y tener de 1 a 8 caracteres inclusive para documentos argentinos u 8 caracteres para documentos extranjeros.";
		#endregion

		#region Constructor
		/// <summary>
		/// Genera la excepción con un mensaje por defecto.
		/// </summary>
		public DniInvalidoException() : this( mensajeBase )
		{
		}
		/// <summary>
		/// Genera la excepción con un mensaje por defecto por defecto y una innerException.
		/// </summary>
		/// <param name="e">InnerException.</param>
		public DniInvalidoException(Exception e) : this( mensajeBase,e) 
		{
		}
		/// <summary>
		/// Genera la excepción con un mensaje personalizado.
		/// </summary>
		/// <param name="message">Mensaje personalizado a registrar en la excepción.</param>
		public DniInvalidoException(string message) : this(message,null)
		{
		}
		/// <summary>
		/// Genera la excepción con un mensaje personalizado y una innerException.
		/// </summary>
		/// <param name="message">Mensaje personalizado a registrar en la excepción.</param>
		/// <param name="e">InnerException.</param>
		public DniInvalidoException(string message, Exception e) : base(message,e)
		{
		}
		#endregion
	}
}
