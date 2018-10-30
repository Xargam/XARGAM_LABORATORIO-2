using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class EquipoBasquet : Equipo
	{
		#region Atributos
		private string _punteriaEnLineaDeTriple;
		#endregion

		#region Cosntructor
		public EquipoBasquet(string nombre, DateTime fechaCreacion , string punteriaEnLineaDeTriple) : base(nombre,fechaCreacion)
		{
			this._punteriaEnLineaDeTriple = punteriaEnLineaDeTriple;
		}
		#endregion

		#region Metodos
		public override string Ficha()
		{
			return string.Format("{0}\nPunteria en linea de triple: {1}",base.Ficha(),this._punteriaEnLineaDeTriple);
		}
		#endregion
	}
}
