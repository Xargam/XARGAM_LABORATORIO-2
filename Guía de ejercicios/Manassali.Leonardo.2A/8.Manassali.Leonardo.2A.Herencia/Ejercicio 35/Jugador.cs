using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
	public class Jugador : Persona
	{
		#region Atributos
		private int _partidosJugados;
		private int _totalGoles;
		#endregion

		#region Propiedades
		public int TotalGoles
		{
			set
			{
				this._totalGoles = value;
			}
			get
			{
				return this._totalGoles;
			}
		}
		public int PartidosJugados
		{
			set
			{
				this._partidosJugados = value;
			}
			get
			{
				return this._partidosJugados;
			}
		}
		public float PromedioDeGoles
		{
			get
			{
				return (this._partidosJugados != 0) ? this._totalGoles / this._partidosJugados : 0 ;
			}
		}


		#endregion

		#region Constructor
		public Jugador(int dni, string nombre) : base(dni, nombre)
		{
		}

		public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
		{
			this._totalGoles = totalGoles;
			this._partidosJugados = totalPartidos;
		}
		#endregion

		#region Operadores
		public static bool operator !=(Jugador j1, Jugador j2)
		{
			return !(j1 == j2);
		}
		public static bool operator ==(Jugador j1, Jugador j2)
		{
			return j1.Dni == j2.Dni;
		}
		#endregion

		#region Metodos
		public new string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.MostrarDatos()); 
			datos.AppendFormat("Goles totales: {0}\n", this.TotalGoles);
			datos.AppendFormat("Partidos jugados: {0}\n", this.PartidosJugados);
			datos.AppendFormat("Promedio de goles: {0:0.00}\n", this.PromedioDeGoles);
			return datos.ToString();
		}
		#endregion

		
	}
}
