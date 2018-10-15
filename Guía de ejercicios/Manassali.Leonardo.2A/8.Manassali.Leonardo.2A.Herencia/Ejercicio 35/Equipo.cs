using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
	public class Equipo
	{
		#region Atributos

		private short _cantidadDeJugadores;
		private List<Jugador> _jugadores;
		private string _nombre; 

		#endregion

		private Equipo()
		{
			this._jugadores = new List<Jugador>();
		}

		public Equipo(short cantidad, string nombre) : this()
		{
			this._cantidadDeJugadores = cantidad;
			this._nombre = nombre;
		}
		

		public static bool operator +(Equipo e , Jugador j)
		{
			bool verify = e._jugadores.Count < e._cantidadDeJugadores;
			if( verify )
			{
				foreach(Jugador jugador in e._jugadores )
				{
					if( jugador == j )
					{
						verify = false;
						break;
					}
				}
				if (verify)
				{
					e._jugadores.Add(j);
				}
			}
			return verify;
		}


	}
}
