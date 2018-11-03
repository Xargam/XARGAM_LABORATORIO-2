using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class DniInvalidoException : Exception
	{
		#region Atributos
		private string mensajeBase;
		#endregion

		#region Constructor
		public DniInvalidoException()
		{

		}
		public DniInvalidoException(Exception e)
		{
				
		}
		public DniInvalidoException(string mensaje)
		{

		}
		public DniInvalidoException(string mensaje, Exception e)
		{

		}
		#endregion
	}
}
