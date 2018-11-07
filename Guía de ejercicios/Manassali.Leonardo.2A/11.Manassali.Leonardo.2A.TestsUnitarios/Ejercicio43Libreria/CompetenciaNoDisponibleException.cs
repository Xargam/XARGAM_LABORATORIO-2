using System;
using System.Text;

namespace Ejercicio43Libreria
{
	public class CompetenciaNoDisponibleException : Exception
	{
		#region Atributos
		private string _nombreClase;
		private string _nombreMetodo;
		#endregion

		#region Propiedades
		public string NombreClase => this._nombreClase;
		public string NombreMetodo => this._nombreMetodo;
		#endregion

		#region Constructor
		public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
		{
		}
		public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
		{
			this._nombreMetodo = metodo;
			this._nombreClase = clase;
		}
		#endregion

		#region Metodos
		public override string ToString()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Excepción en el método {0} de la clase {1}:\r\n", this.NombreMetodo, this.NombreClase);
			datos.AppendLine(this.Message);
			datos.AppendLine("Inner Excepction:");
			if ( !Object.Equals(this.InnerException, null) )
			{
				datos.AppendLine(this.InnerException.ToString());
			}
			return datos.ToString();
		}
		#endregion
	}
}
