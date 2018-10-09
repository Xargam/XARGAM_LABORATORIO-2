using System;
using System.Collections.Generic;
using System.Text;

namespace Deportes
{
	public class Jugador
	{
		#region Atributos

		private int dni;
		private string nombre;
		private int partidosJugados;
		private float promedioGoles;
		private int totalGoles; 

		#endregion

		public float GetPromedioGoles()
		{
			this.promedioGoles = (this.partidosJugados == 0) ? 0 : this.totalGoles / this.partidosJugados;
			return this.promedioGoles;
		}

		private Jugador()
		{
			this.totalGoles = 0;
			this.partidosJugados = 0;
			this.promedioGoles = 0;
		}

		public Jugador(int dni , string nombre ) : this()
		{
			this.nombre = nombre;
			this.dni = dni;
		}

		public Jugador(int dni , string nombre, int totalGoles, int totalPartidos ) : this(dni,nombre)
		{
			this.totalGoles = totalGoles;
			this.partidosJugados = totalPartidos;
		}

		public string MostrarDatos()
		{
			return "Nombre: " + this.nombre + "\nDNI: " + this.dni + "\nPartidos jugados: " + this.partidosJugados + "\nGoles totales: " + this.totalGoles + "\nPromedio de goles: " + this.promedioGoles + "\n";
		}

		public static bool operator !=(Jugador j1 , Jugador j2)
		{
			return !(j1 == j2);
		}
		public static bool operator ==(Jugador j1 , Jugador j2 )
		{
			return (j1.dni == j2.dni);
		}
	}
}
