using System;
using System.Collections.Generic;
using System.Text;

namespace Deportes
{
	public class Jugador
	{
		#region Atributos

		private int _dni;
		private string _nombre;
		private int _partidosJugados;
		private int _totalGoles;

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
		public int Dni
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
		public int TotalGoles
		{
			get
			{
				return this._totalGoles;
			}
		}
		public int PartidosJugados
		{
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
		private Jugador()
		{
			this._totalGoles = 0;
			this._partidosJugados = 0;
		}

		public Jugador(int dni, string nombre) : this()
		{
			this.Nombre = nombre;
			this.Dni = dni;
		}

		public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
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
			return (j1._dni == j2._dni);
		}
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Nombre: {0}\nDNI: {1}\nPartidos jugados: {2}\n", this.Nombre, this.Dni, this.PartidosJugados);
			sb.AppendFormat("Goles totales: {0}\nPromedio de goles: {1}\n", this.TotalGoles, this.PromedioDeGoles);
			return sb.ToString();
		}
		#endregion

		
	}
}
