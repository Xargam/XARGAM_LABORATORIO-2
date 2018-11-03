using System;

namespace Excepciones
{
	public class ArchivosException : Exception
	{
		#region Constructor
		public ArchivosException(Exception innerException) : base("Se produjo un error durante la manipulación de archivos.",innerException)
		{
		}
		#endregion
	}
}
