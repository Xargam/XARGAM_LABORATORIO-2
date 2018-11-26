using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public abstract class Mascota
	{
		#region Atributos
		private string _nombre;
		private string _raza;
		#endregion

		#region Propiedades
		public string Nombre
		{
			get
			{
				return this._nombre;
			}
		}

		public string Raza
		{
			get
			{
				return this._raza;
			}
		}
		#endregion

		public Mascota(string nombre, string raza)
		{
			this._nombre = nombre;
			this._raza = raza;
		}
		#region Metodos

		protected virtual string DatosCompletos()
		{
			return string.Format("Nombre: {0} {1} ", this.Nombre,this.Raza);
		}

		protected abstract string Ficha();
		#endregion
	}
}
