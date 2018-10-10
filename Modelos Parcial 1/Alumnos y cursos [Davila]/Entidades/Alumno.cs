using System.Text.RegularExpressions;
using System.Text;

namespace Entidades
{
	public class Alumno : Persona
	{
		#region Atributos
		private short _anio;
		private Divisiones _division;
		#endregion

		#region Propiedades
		public string AnioDivision => string.Format("{0}º{1}", this._anio, this._division);
		#endregion

		#region Constructor
		public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
		{
			this._division = division;
			this._anio = anio;
		}
		#endregion

		#region Metodos

		public override string ExponerDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Alummno:\n");
			sb.AppendLine(base.ExponerDatos());
			sb.AppendFormat("Division: {0}\n", this.AnioDivision);
			return sb.ToString();
		}

		protected override bool ValidarDocumentacion(string doc)
		{
			return (doc.Length == 9 && Regex.IsMatch(doc, "[0-9]{2}-[0-9]{4}-[0-9]{1}") );
		}
		#endregion
	}
}
