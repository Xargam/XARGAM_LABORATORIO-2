using System;
using System.Collections.Generic;
using System.Text;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
	public sealed class Alumno : Universitario
	{
		#region Atributos
		private Universidad.EClases claseQueToma;
		private EEstadoCuenta estadoCuenta;
		#endregion

		#region Constructor
		public Alumno()
		{

		}
		public Alumno(int id , string nombre , string apellido , string dni , ENacionalidad nacionalidad , Universidad.EClases claseQueToma) : base(id,nombre,apellido,dni,nacionalidad)
		{
			this.claseQueToma = claseQueToma;
		}
		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
		{
			this.estadoCuenta = estadoCuenta;
		}
		#endregion

		#region Operadores
		public static bool operator !=(Alumno a, Universidad.EClases clase)
		{
			return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
		}
		public static bool operator ==(Alumno a, Universidad.EClases clase)
		{
			return a.claseQueToma != clase;
		}
		#endregion

		#region Metodos
		public override string ToString()
		{
			return this.MostrarDatos();
		}
		protected override string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.MostrarDatos());
			datos.AppendLine(this.ParticiparEnClase());
			datos.AppendFormat("Estado de su cuenta: {0}", this.estadoCuenta.ToString());
			return datos.ToString();
		}
		protected override string ParticiparEnClase()
		{
			return string.Format("TOMA CLASE DE {0}",this.claseQueToma.ToString());
		}
		#endregion

		#region Enumerados
		public enum EEstadoCuenta
		{
			AlDia,
			Deudor,
			Becado
		}
		#endregion
	}
}
