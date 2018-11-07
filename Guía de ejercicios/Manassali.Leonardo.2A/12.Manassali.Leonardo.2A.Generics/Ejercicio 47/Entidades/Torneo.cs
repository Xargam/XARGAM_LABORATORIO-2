using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
	public class Torneo<T> where T : Equipo
	{
		#region Atributos
		public List<T> equipos;
		public string nombre;
		#endregion

		#region Propiedades
		public string JugarPartido
		{
			get
			{
				string resultado = "No hay suficientes equipos como para organizar un torneo.";
				Random indice = new Random();
				int equipo1;
				int equipo2;
				Thread.Sleep(250);
				if (this.equipos.Count > 1)
				{
					equipo1 = equipo2 = indice.Next(0, this.equipos.Count);
					while (equipo1 == equipo2 )
					{
						equipo2 = indice.Next(0, this.equipos.Count);
					}
					resultado = CalcularPartido(this.equipos[equipo1], this.equipos[equipo2]);
				}
				return resultado;
			}
		}

		#endregion
		#region Constructor
		private Torneo()
		{
			this.equipos = new List<T>();
		}
		public Torneo(string nombre) : this()
		{
			this.nombre = (object.Equals(nombre,null))? "" : nombre;
		}
		#endregion

		#region Operadores
		#region Comparacion
		public static bool operator ==(Torneo<T> torneo , Equipo equipo)
		{
			bool verificacion = false;
			if (!object.Equals(torneo , null ) && !object.Equals(equipo,null))
			{
				foreach (T item in torneo.equipos)
				{
					if (item == equipo)
					{
						verificacion = true;
						break;
					}
				}
			}
			return verificacion;
		}
		public static bool operator !=(Torneo<T> torneo, Equipo equipo)
		{
			return !(torneo == equipo);
		}

		#endregion
		#region Aritmeticos
		public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
		{
			if (!object.Equals(torneo, null) && !object.Equals(equipo, null) && torneo != equipo)
			{
				torneo.equipos.Add((T)equipo);
			}
			return torneo;
		}
		#endregion
		#endregion

		#region Metodos
		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Nombre del torneo: {0}\r\n", this.nombre);
			foreach ( T item in this.equipos)
			{
				datos.AppendLine(item.Ficha());
			}
			return datos.ToString();
		}
		private string CalcularPartido(T equipo1 ,T equipo2 )
		{
			StringBuilder resultado = new StringBuilder();
			Random goles = new Random();
			resultado.AppendFormat("{0} {1} - {2} {3}",equipo1.nombre , goles.Next(0,11) , goles.Next(0, 11), equipo2.nombre);
			return resultado.ToString();
		}
		#endregion
	}
}
