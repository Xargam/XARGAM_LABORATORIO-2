using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
	public interface IArchivo<T>
	{
		#region Metodos
		bool Guardar(string archivo, T datos);
		bool Leer(string archivo, out T datos);
		#endregion
	}
}
