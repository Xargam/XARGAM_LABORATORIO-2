using System;
using System.Collections.Generic;
using System.Text;
using EntidadesAbstractas;

namespace EntidadesInstanciables
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
		/// <summary>
		/// Inicializa los campos del objeto Alumno dejando el estadoCuenta en su valor por defecto "AlDia" .
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="claseQueToma"></param>
		public Alumno(int id , string nombre , string apellido , string dni , ENacionalidad nacionalidad , Universidad.EClases claseQueToma) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma,EEstadoCuenta.AlDia)
		{
		}
		/// <summary>
		/// Inicializa todos los campos del objeto Alumno.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="claseQueToma"></param>
		/// <param name="estadoCuenta"></param>
		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : base(id,nombre,apellido,dni,nacionalidad)
		{
			this.claseQueToma = claseQueToma;
			this.estadoCuenta = estadoCuenta;
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Un alumno será distinto a una clase si NO participa de la misma.
		/// </summary>
		/// <param name="a">Alumno a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve true si el alumno es distinto a la clase o false en caso contrario.</returns>
		public static bool operator !=(Alumno a, Universidad.EClases clase)
		{
			//Si el alumno es nulo no participa de la clase.
			return (object.Equals(a,null))? true : a.claseQueToma != clase;
		}
		/// <summary>
		/// Un alumno será igual a una clase si participa de la misma y su estado de cuenta no es deudor.
		/// </summary>
		/// <param name="a">Alumno a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve true si el alumno es igual a la clase o false en caso contrario.</returns>
		public static bool operator ==(Alumno a, Universidad.EClases clase)
		{
			return !object.Equals(a, null) && a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve una cadena que contiene los datos del objeto Alumno.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}
		/// <summary>
		/// Metodo encargado de generar una cadena de caracteres con los datos del alumno y clase base.
		/// </summary>
		/// <returns></returns>
		protected override string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.MostrarDatos());
			datos.AppendFormat("ESTADO DE CUENTA: {0}\r\n", this.estadoCuenta.ToString());
			datos.AppendLine(this.ParticiparEnClase());
			return datos.ToString();
		}
		/// <summary>
		/// Devuelve una cadena de caracteres conteniendo el dato del atributo claseQueToma del objeto alumno.
		/// </summary>
		/// <returns></returns>
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
