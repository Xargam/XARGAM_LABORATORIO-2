using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class Curso
	{
		#region Atributos
		private List<Alumno> _alumnos;
		private short _anio;
		private Divisiones _division;
		private Profesor _profesor;
		#endregion

		#region Propiedades
		public string AnioDivision => string.Format("{0}º{1}", this._anio, this._division);
		#endregion

		#region Constructor
		private Curso()
		{
			this._alumnos = new List<Alumno>();
		}

		public Curso(short anio, Divisiones division, Profesor profesor) : this()
		{
			this._anio = anio;
			this._division = division;
			this._profesor = profesor;
		}
		#endregion

		#region Operadores
		#region Conversion

		public static explicit operator string(Curso c)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Curso: {0}\n", c.AnioDivision);
			sb.AppendFormat("{0}\n",c._profesor.ExponerDatos());
			foreach (Alumno a in c._alumnos)
			{
				sb.AppendFormat("{0}\n", a.ExponerDatos());
			}
			return sb.ToString();
		}

		#endregion
		#region Comparacion
		public static bool operator ==(Curso c, Alumno a)
		{
			return c.AnioDivision == a.AnioDivision;
		}

		public static bool operator !=(Curso c, Alumno a)
		{
			return !(c == a);
		}

		#endregion

		#region Aritmetica
		public static Curso operator +(Curso c, Alumno a)
		{
			if (c == a)
			{
				c._alumnos.Add(a);
			}
			return c;
		}
		#endregion
		#endregion
	}
}
