using System;

namespace Archivos
{
	public class Texto
	{
		#region Metodos
		public bool Guardar(string archivo , string datos)
		{
			return true;
		}
		public bool Leer(string archivo,out string datos)
		{
			datos = "";
			return true;
		}
		#endregion
	}
}
