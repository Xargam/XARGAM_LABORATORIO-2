using System;
using System.Collections.Generic;
using System.Text;

namespace Carrera
{
	public class Competencia
	{
		#region Atributos
		private short cantidadCompetidores;
		private short cantidadVueltas;
		private List<AutoF1> Competidores; 
		#endregion

		private Competencia()
		{
			this.Competidores = new List<AutoF1>();
		}

		public Competencia(short cantidadVueltas , short cantidadCompetidores ) : this()
		{
			this.cantidadVueltas = cantidadVueltas;
			this.cantidadCompetidores = cantidadCompetidores;
		  
		}

		public string MostrarDatos()
		{
			string datos = "";

			datos += "Cantidad MAX de competidores: " + this.cantidadCompetidores + "\nCantidad de vueltas: " + this.cantidadVueltas + "\nCompetidores:\n\n";
		    foreach(AutoF1 auto in this.Competidores )
			{
				datos += auto.MostrarDatos();
			}
			return datos;
		}

		public static bool operator -(Competencia c, AutoF1 a)
		{
			bool verificacion = false;
			if (c == a )
			{
				verificacion = true;
				c.Competidores.RemoveAt(c.IndexOf(a));
			}
			return verificacion;
		}
		public static bool operator +(Competencia c, AutoF1 a)
		{
			bool verify = false;

			if( c != a && c.Competidores.Count < c.cantidadCompetidores )
			{
				verify = true;
				a.SetEnCompetencia(true);
				a.SetVueltasRestantes(c.cantidadVueltas);
				a.SetCantidadCombustible((short)new Random().Next(15, 100));
				c.Competidores.Add(a);
			}
			return verify;
		}
		public static bool operator ==(Competencia c, AutoF1 a)
		{
			bool verificacion = false;
			foreach( AutoF1 a2 in c.Competidores)
			{
				if(a2 == a)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}

		private int IndexOf(AutoF1 a)
		{
			int indice = -1;
			for (int i = 0; i < this.Competidores.Count ; i++)
			{
				if ( this.Competidores[i] == a)
				{
					indice = i;
					break;
				}
			}
			return indice;
		}

		public static bool operator !=(Competencia c, AutoF1 a)
		{
			return !(c == a) ;
		}
	}
}
