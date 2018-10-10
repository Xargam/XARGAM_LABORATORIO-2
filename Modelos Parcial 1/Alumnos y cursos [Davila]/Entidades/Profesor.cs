using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Profesor : Persona
  {
		#region Atributos
		private DateTime _fechaIngreso;
		#endregion

		#region Propiedades
		public int Antiguedad
		{
			get
			{
				TimeSpan diasAntiguedad = new TimeSpan();
				diasAntiguedad = DateTime.Now - this._fechaIngreso;
				return diasAntiguedad.Days;
			}
		}
		#endregion

		#region Constructor
		public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
		{
		}

		public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
		{
			this._fechaIngreso = fechaIngreso;
		}
		#endregion

		#region Metodos
		public override string ExponerDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Profesor:\n");
			sb.AppendLine(base.ExponerDatos());
			sb.AppendFormat("Fecha de ingreso: {0:dd/mm/yyyy}\n", this._fechaIngreso);
			return sb.ToString();
		}

		protected override bool ValidarDocumentacion(string doc)
		{
			return (doc.Length == 8);
		} 
		#endregion

	}
}
