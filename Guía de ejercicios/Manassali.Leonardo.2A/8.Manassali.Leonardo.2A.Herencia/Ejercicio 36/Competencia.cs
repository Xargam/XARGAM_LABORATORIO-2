using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_36
{
	public class Competencia
	{
		#region Atributos
		private short _cantidadCompetidores;
		private short _cantidadVueltas;
		private List<VehiculoDeCarrera> _competidores;
		private TipoCompetencia _tipo;
		#endregion

		#region Propiedades
		public short CantidadCompetidores
		{
			get
			{
				return this._cantidadCompetidores;
			}
			set
			{
				this._cantidadCompetidores = value;
			}
		}
		public short CantidadVueltas
		{
			get
			{
				return this._cantidadVueltas;
			}
			set
			{
				this._cantidadVueltas = value;
			}
		}
		public VehiculoDeCarrera this[int i]
		{
			get
			{
				return (i >= 0 && i < this._competidores.Count) ? this._competidores[i] : null;
			}
		}
		public TipoCompetencia Tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				this._tipo = value;
			}
		}

		#endregion

		#region Constructor
		private Competencia()
		{
			this._competidores = new List<VehiculoDeCarrera>();
		}

		public Competencia(short cantidadVueltas, short cantidadCompetidores , TipoCompetencia tipo) : this()
		{
			this.CantidadVueltas = cantidadVueltas;
			this.CantidadCompetidores = cantidadCompetidores;
			this.Tipo = tipo;
		}
		#endregion

		#region Operadores
		public static bool operator -(Competencia c, VehiculoDeCarrera a)
		{
			bool verificacion = false;
			if (c == a)
			{
				verificacion = true;
				c._competidores.Remove(a);
			}
			return verificacion;
		}
		public static bool operator +(Competencia c, VehiculoDeCarrera a)
		{
			bool verify = c != a && c._competidores.Count < c.CantidadCompetidores;
			if (verify && ((c.Tipo == TipoCompetencia.F1) ? a is AutoF1 : a is MotoCross) )
			{
				a.EnCompetencia = true;
				a.VueltasRestantes = c.CantidadVueltas;
				a.CantidadCombustible = (short)(new Random()).Next(15, 100);
				c._competidores.Add(a);
			}
			return verify;
		}
		public static bool operator ==(Competencia c, VehiculoDeCarrera a)
		{
			bool verificacion = false;

			foreach (VehiculoDeCarrera a2 in c._competidores)
			{
				if ( a2 is MotoCross && a is MotoCross  )  
				{
					if( (MotoCross)a2 == (MotoCross)a  )
					{
						verificacion = true;
						break;
					}
				}
				else if( a2 is AutoF1 && a is AutoF1 )
				{
					if ((AutoF1)a2 == (AutoF1)a)
					{
						verificacion = true;
						break;
					}
				}
			}
			return verificacion;
		}
		public static bool operator !=(Competencia c, VehiculoDeCarrera a)
		{
			return !(c == a);
		}
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Cantidad MAX de competidores: {0}\n", this.CantidadCompetidores);
			datos.AppendFormat("Cantidad de vueltas: {0}\n", this.CantidadVueltas);
			datos.AppendLine("Competidores:\n");
			foreach (VehiculoDeCarrera v1 in this._competidores)
			{
				if( v1 is MotoCross )
				{
					datos.AppendLine( ((MotoCross)v1).MostrarDatos() );
				}
				else if( v1 is AutoF1)
				{
					datos.AppendLine(((AutoF1)v1).MostrarDatos());
				}
			}
			return datos.ToString();
		} 
		#endregion

		#region Enumerados
		public enum TipoCompetencia
		{
			F1,
			MotoCross
		}
		#endregion
	}
}
