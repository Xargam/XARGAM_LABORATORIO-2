using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_36
{
	public class AutoF1 : VehiculoDeCarrera
	{
		#region Atributos
		private short _caballosDeFuerza;
		#endregion

		#region Propiedades
		public short CaballosDeFuerza
		{
			get
			{
				return this._caballosDeFuerza;
			}
			set
			{
				this._caballosDeFuerza = value;
			}
		}
		#endregion

		#region Constructor
		public AutoF1(short numero, string escuderia) : base(numero, escuderia)
		{
		}
		public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
		{
			this.CaballosDeFuerza = caballosDeFuerza;
		}
		#endregion

		#region Operadores
		public static bool operator !=(AutoF1 a1, AutoF1 a2)
		{
			return !(a1 == a2);
		}
		public static bool operator ==(AutoF1 a1, AutoF1 a2)
		{
			return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
		}
		#endregion

		#region Metodos
		public new string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.MostrarDatos());
			datos.AppendFormat("Caballos de fuerza: {0}\n", this.CaballosDeFuerza);
			return datos.ToString();
		} 
		#endregion
	}

}
