using System;

namespace Entidades
{
	public abstract class Equipo
	{
		#region Atributos
		public string nombre;
		public DateTime fechaDeCreacion;
		#endregion

		#region Constructor
		public Equipo(string nombre , DateTime fechaDeCreacion)
		{
			this.nombre = nombre;
			this.fechaDeCreacion = fechaDeCreacion;
		}
		#endregion

		#region Operadores
		public static bool operator ==(Equipo e1 , Equipo e2)
		{
			return !object.Equals(e1,null) && !object.Equals(e2, null) && e1.nombre == e2.nombre && e1.fechaDeCreacion == e2.fechaDeCreacion;
		}
		public static bool operator !=(Equipo e1, Equipo e2)
		{
			return !(e1 == e2);
		}
		#endregion

		#region Metodos
		public string Ficha()
		{
			return this.nombre + " fundado el " + this.fechaDeCreacion.ToString("dd/MM/yyyy");
		}
		#endregion
	}
}
