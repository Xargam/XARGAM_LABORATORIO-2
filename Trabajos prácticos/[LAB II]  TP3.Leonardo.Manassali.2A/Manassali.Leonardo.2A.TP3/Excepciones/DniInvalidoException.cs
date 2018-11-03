using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class DniInvalidoException : Exception
	{
		#region Atributos
		private static string mensajeBase = "El formato del DNI no es correcto. Este debe ser numérico y tener de 1 a 8 caracteres inclusive para documentos argentinos u 8 caracteres para documentos extranjeros.";
		#endregion

		#region Constructor
		public DniInvalidoException() : this( DniInvalidoException.mensajeBase )
		{
		}
		public DniInvalidoException(Exception e) : this( DniInvalidoException.mensajeBase,e) 
		{
		}
		public DniInvalidoException(string message) : this(message,null)
		{
		}
		public DniInvalidoException(string message, Exception e) : base(message,e)
		{
		}
		#endregion
	}
}
