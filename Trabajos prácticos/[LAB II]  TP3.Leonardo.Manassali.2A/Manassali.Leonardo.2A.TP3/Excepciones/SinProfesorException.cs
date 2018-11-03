using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
	public class SinProfesorException : Exception
	{
		#region Constructor
		public SinProfesorException() : base("No hay un profesor que dicte la clase.")
		{
		}
		#endregion
	}
}
