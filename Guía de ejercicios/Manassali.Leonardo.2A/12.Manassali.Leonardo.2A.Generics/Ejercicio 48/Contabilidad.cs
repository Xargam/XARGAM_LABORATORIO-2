using System;
using System.Collections.Generic;

namespace Ejercicio_48
{
	public class Contabilidad<T,U> 
	where T : Documento
	where U : Documento , new()
	{
		#region Atributos
		private List<T> _egresos;
		private List<U> _ingresos;
		#endregion

		#region Constructor
		public Contabilidad()
		{
			this._egresos = new List<T>();
			this._ingresos = new List<U>();
		}
		#endregion

		#region Operadores
		public static Contabilidad<T,U> operator +( Contabilidad<T,U> c , T egreso)
		{
			if (!object.Equals(null, c) && !object.Equals(null, egreso) && !c._egresos.Contains(egreso))
			{
				c._egresos.Add(egreso);
			}
			return c;
			
		}
		public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
		{
			if ( !object.Equals(null,c) && !object.Equals(null, ingreso) && !c._ingresos.Contains(ingreso))
			{
				c._ingresos.Add(ingreso);
			}
			return c;
		}
		#endregion
	}
}
