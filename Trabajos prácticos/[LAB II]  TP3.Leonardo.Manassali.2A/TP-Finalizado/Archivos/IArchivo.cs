using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
	public interface IArchivo<T>
	{
		#region Metodos
		/// <summary>
		/// Guarda cualquier tipo de dato en un archivo especificado.
		/// </summary>
		/// <param name="archivo">Ruta del archivo.</param>
		/// <param name="datos">Dato genérico que se guardará en el archivo.</param>
		/// <returns>Devuelve true si se realizó el guardado correctamente.</returns>
		bool Guardar(string archivo, T datos);
		/// <summary>
		/// Lee cualquier tipo de dato que esté en un determinado archivo.
		/// </summary>
		/// <param name="archivo">Ruta del archivo de donde se leerán datos genéricos.</param>
		/// <param name="datos">Parámetro de salida para almacenar datos leídos.</param>
		/// <returns>Devuelve true si la lectura del archivo fue exitosa.</returns>
		bool Leer(string archivo, out T datos);
		#endregion
	}
}
