using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_29
{
	public class Jugador
	{
		#region Atributos

		private int _dni;
		private string _nombre;
		private int _partidosJugados;
		private float _promedioGoles;
		private int _totalGoles;

		#endregion

		#region Getters
		public float GetPromedioGoles()
		{
			this._promedioGoles = (this._partidosJugados == 0) ? 0 : (float)this._totalGoles / this._partidosJugados;
			return this._promedioGoles;
		}
		#endregion

		#region Constructor
		private Jugador()
		{
			this._totalGoles = 0;
			this._partidosJugados = 0;
			this._promedioGoles = 0;
		}
		public Jugador(int dni, string nombre) : this()
		{
			this._dni = dni;
			this._nombre = nombre;
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
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Nombre: {0}\r\n", this._nombre);
			datos.AppendFormat("Dni: {0}\r\n", this._dni);
			datos.AppendFormat("Partidos jugados: {0}\r\n", this._partidosJugados);
			datos.AppendFormat("Total de goles: {0}\r\n", this._totalGoles);
			datos.AppendFormat("Promedio de goles: {0}\r\n", this.GetPromedioGoles());
			return datos.ToString();
		}
		#endregion

		
	}
}
