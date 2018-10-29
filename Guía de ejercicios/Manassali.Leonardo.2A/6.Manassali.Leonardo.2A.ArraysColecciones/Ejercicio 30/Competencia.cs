using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_30
{
	public class Competencia
	{
		#region Atributos
		private short _cantidadCompetidores;
		private short _cantidadVueltas;
		private List<AutoF1> _competidores;
		#endregion

		#region Constructor
		private Competencia()
		{
			this._competidores = new List<AutoF1>();
		}
		public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
		{
			this._cantidadVueltas = cantidadVueltas;
			this._cantidadCompetidores = cantidadCompetidores;
		}
		#endregion

		#region Operadores
		#region Aritmericos
		public static bool operator +(Competencia c, AutoF1 a)
		{
			bool verify = c != a && c._competidores.Count < c._cantidadCompetidores;
			if ( verify )
			{
				a.SetEnCompetencia(true);
				a.SetVueltasRestantes(c._cantidadVueltas);
				a.SetCantidadCombustible((short)new Random().Next(15, 101));
				c._competidores.Add(a);
			}
			return verify;
		}
		public static bool operator -(Competencia c, AutoF1 a)
		{
			bool verificacion = c == a;
			if ( verificacion )
			{
				c._competidores.RemoveAt(c.GetAutoIndex(a));
			}
			return verificacion;
		} 
		#endregion
		#region Comparacion
		public static bool operator ==(Competencia c, AutoF1 a1)
		{
			bool verificacion = false;
			foreach ( AutoF1 a2 in c._competidores )
			{
				if ( a2 == a1 )
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Competencia c, AutoF1 a)
		{
			return !(c == a);
		}
		#endregion
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine("---Competencia---");
			datos.AppendFormat("Cantidad de competidores: {0}\r\n",this._cantidadCompetidores);
			datos.AppendFormat("Cantidad de vueltas: {0}\r\n",this._cantidadVueltas);
			foreach ( AutoF1 auto in this._competidores )
			{
				datos.AppendLine(auto.MostrarDatos());
			}
			return datos.ToString();
		}
		#endregion

		#region Metodos Imprescindibles
		private int GetAutoIndex(AutoF1 a2)
		{
			int indice = -1;
			int contador = -1;
			foreach ( AutoF1 a1 in this._competidores )
			{
				contador++;
				if ( a2 == a1 )
				{
					indice = contador;
					break;
				}
			}
			return indice;
		}
		#endregion
	}
}
