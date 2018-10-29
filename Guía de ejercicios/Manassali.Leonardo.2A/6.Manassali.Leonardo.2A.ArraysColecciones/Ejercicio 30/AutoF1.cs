using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_30
{
	public class AutoF1
	{
		#region Atributos
		private short _cantidadCombustible;
		private bool _enCompetencia;
		private string _escuderia;
		private short _numero;
		private short _vueltasRestantes;
		#endregion

		#region Setters
		public void SetCantidadCombustible(short cantidadCombustible)
		{
			this._cantidadCombustible = cantidadCombustible;
		}
		public void SetVueltasRestantes(short vueltasRestantes)
		{
			this._vueltasRestantes = vueltasRestantes;
		}
		public void SetEnCompetencia(bool enCompetencia)
		{
			this._enCompetencia = enCompetencia;
		}
		#endregion

		#region Getters
		public short GetCantidadCombustible()
		{
			return this._cantidadCombustible;
		}
		public short GetVueltasRestantes()
		{
			return this._vueltasRestantes;
		}
		public bool GetEnCompetencia()
		{
			return this._enCompetencia;
		}
		#endregion

		#region Constructor
		public AutoF1(short numero, string escuderia)
		{
			this._cantidadCombustible = 0;
			this._vueltasRestantes = 0;
			this._enCompetencia = false;
			this._numero = numero;
			this._escuderia = escuderia;
		}
		#endregion

		#region Operadores
		public static bool operator !=(AutoF1 a1, AutoF1 a2)
		{
			return !(a1 == a2);
		}
		public static bool operator ==(AutoF1 a1, AutoF1 a2)
		{
			return a1._numero == a2._numero && a1._escuderia == a2._escuderia;
		}
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Numero: {0}\r\n", this._numero);
			datos.AppendFormat("Escuderia: {0}\r\n", this._escuderia);
			datos.AppendFormat("En competencia: {0}\r\n", (this.GetEnCompetencia())?"Si":"No");
			datos.AppendFormat("Vueltas restantes: {0}\r\n", this.GetVueltasRestantes());
			datos.AppendFormat("Cantidad de combustible: {0}\r\n", this.GetCantidadCombustible());
			return datos.ToString();
		} 
		#endregion
	}

}
