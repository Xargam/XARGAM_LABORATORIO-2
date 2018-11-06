using System;

namespace Excepciones
{
	public class ArchivosException : Exception
	{
		#region Constructor
		/// <summary>
		/// Genera la excepción con un mensaje por defecto y una innerException.
		/// </summary>
		/// <param name="innerException"></param>
		public ArchivosException(Exception innerException) : base("Se produjo un error durante la manipulación de archivos.",innerException)
		{
		}
		#endregion
	}
}
