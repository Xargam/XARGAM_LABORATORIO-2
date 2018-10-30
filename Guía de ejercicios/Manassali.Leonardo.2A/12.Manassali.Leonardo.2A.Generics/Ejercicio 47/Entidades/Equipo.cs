using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public abstract class Equipo
	{
		#region Atributos
		private string _nombre;
		private DateTime _fechaCreacion;
		#endregion

		#region Propiedades
		public string Nombre
		{
			get
			{
				return this._nombre;
			}
		}
		public DateTime FechaCreacion
		{
			get
			{
				return this._fechaCreacion;
			}
		}
		#endregion

		#region Constructor
		public Equipo(string nombre , DateTime fechaCreacion)
		{
			this._nombre = nombre;
			this._fechaCreacion = fechaCreacion;
		}
		#endregion
		#region Operadores
		public static bool operator ==(Equipo e1, Equipo e2)
		{
			return e1.FechaCreacion == e2.FechaCreacion && e1.Nombre == e2.Nombre;
		}
		public static bool operator !=(Equipo e1, Equipo e2)
		{
			return !(e1 == e2);
		}
		#endregion

		#region Metodos
		public virtual string Ficha()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("{0} fundado el {1}", this.Nombre, this.FechaCreacion.ToString("dd/MM/yyyy"));
			return datos.ToString();
		}
		#endregion
	}
}
