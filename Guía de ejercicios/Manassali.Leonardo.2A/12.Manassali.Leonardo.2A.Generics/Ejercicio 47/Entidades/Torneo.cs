using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
	public class Torneo<T> where T : Equipo
	{
		#region Atributos
		private List<T> _equipo;
		private string _nombre;
		#endregion

		#region Propiedades
		public string JugarPartido
		{
			get
			{
				Random indice = new Random();
				string resultado = "";
				int equipo1;
				int equipo2;
				if ( this._equipo.Count >= 2 )
				{
					equipo1 = equipo2 = indice.Next(0, this._equipo.Count);
					Thread.Sleep(50);
					while ( equipo1 == equipo2 )
					{
						equipo2 = indice.Next(0, this._equipo.Count);
					}
					resultado = this.CalcularPartido(this._equipo[equipo1], this._equipo[equipo2]);
				}
				return resultado;
			}
		}
		#endregion

		#region Constructor
		private Torneo()
		{
			this._equipo = new List<T>();
		}
		public Torneo(string nombre) : this()
		{
			this._nombre = nombre;
		}
		#endregion

		#region Operadores
		#region Comparacion
		public static bool operator ==(Torneo<T> torneo, T e)
		{
			bool verificacion = false;
			foreach ( T item in torneo._equipo )
			{
				if ( item == e )
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Torneo<T> torneo, T e)
		{
			return !(torneo == e);
		}
		#endregion
		#region Aritmeticos
		public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
		{
			if ( torneo != equipo )
			{
				torneo._equipo.Add(equipo);
			}
			return torneo;
		}
		#endregion
		#endregion

		#region Metodos
		private string CalcularPartido(T equipo1 , T equipo2)
		{
			Thread.Sleep(50);
			Random goles = new Random();
			return String.Format("{0} {1} - {2} {3}", equipo1.Nombre, goles.Next(0, 11), goles.Next(0, 11), equipo2.Nombre);
		}
		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Torneo: {0}\r\n", this._nombre);
			foreach ( T item in this._equipo )
			{
				datos.AppendLine(item.Ficha());
			}
			return datos.ToString();
		}
		#endregion
	}
}
