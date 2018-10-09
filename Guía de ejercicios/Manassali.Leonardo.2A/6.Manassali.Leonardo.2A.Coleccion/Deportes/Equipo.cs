using System;
using System.Collections.Generic;
using System.Text;

namespace Deportes
{
	public class Equipo
	{
		#region Atributos

		private short cantidadDeJugadores;
		private List<Jugador> jugadores;
		private string nombre; 

		#endregion

		private Equipo()
		{
			this.jugadores = new List<Jugador>();
		}

		public Equipo(short cantidad, string nombre) : this()
		{
			this.cantidadDeJugadores = cantidad;
			this.nombre = nombre;
		}
		

		public static bool operator +(Equipo e , Jugador j)
		{
			bool verify = false;
			if( e.jugadores.Count < e.cantidadDeJugadores )
			{
				verify = true;
				foreach(Jugador jugador in e.jugadores )
				{
					if( jugador == j )
					{
						verify = false;
						break;
					}
				}
			}
			if (verify)
			{
				e.jugadores.Add(j);
			}
			return verify;
		}


	}
}
