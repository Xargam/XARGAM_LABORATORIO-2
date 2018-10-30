using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
	public class MotoCross : VehiculoDeCarrera
	{
		#region Atributos
		private short _cilindrada;
		#endregion

		#region Propiedades
		public short Cilindrada
		{
			get
			{
				return this._cilindrada;
			}
			set
			{
				this._cilindrada = value;
			}
		}
		#endregion

		#region Constructor
		public MotoCross(short numero, string escuderia) : base(numero, escuderia)
		{
		}
		public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
		{
			this.Cilindrada = cilindrada;
		}
		#endregion

		#region Operadores
		public static bool operator !=(MotoCross a1, MotoCross a2)
		{
			return !(a1 == a2);
		}
		public static bool operator ==(MotoCross a1, MotoCross a2)
		{
			return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.Cilindrada == a2.Cilindrada;
		}
		#endregion

		#region Metodos
		public new string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.MostrarDatos());
			datos.AppendFormat("Cilindrada: {0}\n", this.Cilindrada);
			return datos.ToString();
		} 
		#endregion
	}
}
