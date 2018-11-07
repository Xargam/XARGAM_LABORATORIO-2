using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_49
{
	public class Competencia<T> where T : VehiculoDeCarrera
	{
		#region Atributos
		private short _cantidadCompetidores;
		private short _cantidadVueltas;
		private List<T> _competidores;
		#endregion

		#region Propiedades
		public short CantidadCompetidores
		{
			get => this._cantidadCompetidores;
			set => this._cantidadCompetidores = value;
		}
		public short CantidadVueltas
		{
			get => this._cantidadVueltas;
			set => this._cantidadVueltas = value;
		}
		public T this[int i] => (i >= 0 && i < this._competidores.Count) ? this._competidores[i] : null;
		public List<T> Vehiculos
		{
			get => this._competidores;
		}
		#endregion

		#region Constructor
		private Competencia()
		{
			this._competidores = new List<T>();
		}

		public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
		{
			this.CantidadVueltas = cantidadVueltas;
			this.CantidadCompetidores = cantidadCompetidores;
		}
		#endregion

		#region Operadores
		public static bool operator -(Competencia<T> c, T a)
		{
			bool verificacion = false;
			if (c == a)
			{
				verificacion = true;
				c._competidores.Remove(a);
			}
			return verificacion;
		}
		public static bool operator +(Competencia<T> c, T a)
		{
			bool verify = c != a && c._competidores.Count < c.CantidadCompetidores;
			if (verify)
			{
				a.EnCompetencia = true;
				a.VueltasRestantes = c.CantidadVueltas;
				a.CantidadCombustible = (short)(new Random()).Next(15, 100);
				c._competidores.Add(a);
			}
			return verify;
		}
		public static bool operator ==(Competencia<T> c, T a)
		{
			bool verificacion = false;

			foreach (T a2 in c._competidores)
			{
				if (a2 == a)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Competencia<T> c, T a)
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
			foreach (T v1 in this._competidores)
			{
				datos.AppendLine(v1.MostrarDatos());
			}
			return datos.ToString();
		}
		#endregion

	}
}
