using System;
using System.IO;
using Excepciones;

namespace Archivos
{
	public class Texto : IArchivo<string>
	{
		#region MetodosIArchivo
		/// <summary>
		/// Guarda una cadena de caracteres de un archivo de texto específico.
		/// </summary>
		/// <param name="archivo">Ruta del archivo.</param>
		/// <param name="datos">Cadena con datos a almacenar.</param>
		/// <returns>Devuelve true si la cadena se guardo exitosamente, en caso contrario se produce una excepción.</returns>
		public bool Guardar(string archivo, string datos)
		{
			try
			{
				using (StreamWriter textArch = new StreamWriter(archivo))
				{
					textArch.WriteLine(datos);
				}
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			return true;
		}
		/// <summary>
		/// Lee datos de un archivo de texto y los almacena en una cadena de caracteres.
		/// </summary>
		/// <param name="archivo">Ruta del archivo.</param>
		/// <param name="datos">Cadena donde se guardarán los datos leídos.</param>
		/// <returns>Devuelve true si el archivo fue leído exitosamente, en caso contrario se produce una excepción.</returns>
		public bool Leer(string archivo, out string datos)
		{
			datos = "";
			try
			{
				using (StreamReader textArch = new StreamReader(archivo))
				{
					datos = textArch.ReadToEnd();
				}
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			return true;
		} 
		#endregion
	}
}
