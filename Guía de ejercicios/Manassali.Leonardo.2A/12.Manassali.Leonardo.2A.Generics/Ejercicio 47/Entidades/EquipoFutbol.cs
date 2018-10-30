using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class EquipoFutbol : Equipo
	{
		#region Atributos
		private string _nombreArquero;
		#endregion

		#region Cosntructor
		public EquipoFutbol(string nombre, DateTime fechaCreacion, string nombreArquero) : base(nombre, fechaCreacion)
		{
			this._nombreArquero = nombreArquero;
		}
		#endregion

		#region Metodos
		public override string Ficha()
		{
			return string.Format("{0}\nNombre arquero: {1}", base.Ficha(), this._nombreArquero);
		}
		#endregion
	}
}
