using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_29
{
	public class Equipo
	{
		#region Atributos
		private short _cantidadDejugadores;
		private List<Jugador> _jugadores;
		private string _nombre;

		#endregion

		#region Constructor
		private Equipo()
		{
			this._jugadores = new List<Jugador>();
		}

		public Equipo(short cantidad, string nombre) : this()
		{
			this._cantidadDejugadores = cantidad;
			this._nombre = nombre;
		}
		#endregion

		#region Operadores
		public static bool operator +(Equipo e, Jugador j)
		{
			bool verify = e._jugadores.Count < e._cantidadDejugadores;
			if ( verify )
			{
				foreach ( Jugador jugador in e._jugadores )
				{
					if ( jugador == j )
					{
						verify = false;
						break;
					}
				}
				if ( verify )
				{
					e._jugadores.Add(j);
				}
			}
			return verify;
		} 
		#endregion


	}
}
