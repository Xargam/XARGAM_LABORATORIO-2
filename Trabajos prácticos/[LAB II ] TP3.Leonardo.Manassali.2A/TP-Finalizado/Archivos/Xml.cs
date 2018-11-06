using Excepciones;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
	public class Xml<T> : IArchivo<T>
	{
		#region MetodosIArchivo
		/// <summary>
		/// Guarda cualquier tipo de dato de un archivo XML específico mediante serialización UTF-8 ENCODING.
		/// </summary>
		/// <param name="archivo">Ruta del archivo.</param>
		/// <param name="datos">Datos a serializar en XML.</param>
		/// <returns>Devuelve true si los datos se guardaron exitosamente, en caso contrario se produce una excepción.</returns>
		public bool Guardar(string archivo, T datos)
		{
			try
			{
				XmlTextWriter xmlTextWriter = new XmlTextWriter(archivo, Encoding.UTF8);
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(xmlTextWriter, datos);
				xmlTextWriter.Close();
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			return true;
		}
		/// <summary>
		/// Deserializa un archivo XML con cualquier tipo de dato.
		/// </summary>
		/// <param name="archivo">Ruta del archivo.</param>
		/// <param name="datos">Variable receptora de datos.</param>
		/// <returns>Devuelve true si los datos fueron leídos exitosamente, en caso contrario arroja una excepción.</returns>
		public bool Leer(string archivo, out T datos)
		{
			try
			{
				XmlTextReader xmlTextReader = new XmlTextReader(archivo);
				XmlSerializer deserializer = new XmlSerializer(typeof(T));
				datos = (T)deserializer.Deserialize(xmlTextReader);
				xmlTextReader.Close();
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
