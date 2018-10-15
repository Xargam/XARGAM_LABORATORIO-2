using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
	public class VehiculoDeCarrera
	{
		#region Atributos
		private short _cantidadCombustible;
		private bool _enCompetencia;
		private string _escuderia;
		private short _numero;
		private short _vueltasRestantes;
		#endregion

		#region Propiedades
		public short CantidadCombustible
		{
			get
			{
				return this._cantidadCombustible;
			}
			set
			{
				this._cantidadCombustible = value;
			}
		}
		public bool EnCompetencia 
		{
			get
			{
				return this._enCompetencia;
			}
			set
			{
				this._enCompetencia = value;
			}
		}
		public string Escuderia
		{
			get
			{
				return this._escuderia;
			}
			set
			{
				this._escuderia = value;
			}
		}
		public short Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		public short VueltasRestantes
		{
			get
			{
				return this._vueltasRestantes;
			}
			set
			{
				this._vueltasRestantes = value;
			}
		}
		#endregion

		#region Constructor
		public VehiculoDeCarrera(short numero, string escuderia)
		{
			this.Numero = numero;
			this.Escuderia = escuderia;
			this.EnCompetencia = false;
			this.VueltasRestantes = 0;
			this.CantidadCombustible = 0;
		}
		#endregion

		#region Operadores
		public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
		{
			return !(v1 == v2);
		}
		public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
		{
			return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia;
		}
		#endregion

		#region Metodos
		public string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Numero: {0}\n", this.Numero);
			datos.AppendFormat("En competencia: {0}\n", ((this.EnCompetencia)?"si" :"no") );
			datos.AppendFormat("Escuderia: {0}\n", this.Escuderia);
			datos.AppendFormat("Vueltas restantes: {0}\n", this.VueltasRestantes);
			datos.AppendFormat("Combustible: {0}", this.CantidadCombustible);
			return datos.ToString();
		}
		#endregion


	}
}
