using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
	public class Persona
	{
		#region Atributos
		private long _dni;
		private string _nombre;
		#endregion

		#region Propiedades
		public string Nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				this._nombre = value;
			}
		}
		public long Dni
		{
			get
			{
				return this._dni;
			}
			set
			{
				this._dni = value;
			}
		}
		#endregion

		#region Constructor
		public Persona(string nombre )
		{
			this.Nombre = nombre;
		}
		public Persona(long dni , string nombre) : this(nombre)
		{
			this.Dni = dni;
		}
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Nombre: {0}\nDNI: {1}", this.Nombre, this.Dni);
			return datos.ToString();
		}
		#endregion



	}
}
