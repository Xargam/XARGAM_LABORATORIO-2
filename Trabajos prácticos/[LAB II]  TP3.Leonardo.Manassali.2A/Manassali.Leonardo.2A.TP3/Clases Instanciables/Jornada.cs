using System.Collections.Generic;
using System.Text;

namespace ClasesInstanciables
{
	public class Jornada
	{
		#region Atributos
		private List<Alumno> alumnos;
		private Universidad.EClases clase;
		private Profesor instructor;
		#endregion

		#region Propiedades
		public List<Alumno> Alumnos
		{
			get
			{
				return this.alumnos;
			}
			set
			{
				if( !object.Equals(value,null) )
				{
					this.alumnos = value;
				}
			}
		}
		public Universidad.EClases Clase
		{
			get
			{
				return this.clase;
			}
			set
			{
				this.clase = value;

			}
		}
		public Profesor Instructor
		{
			get
			{
				return this.instructor;
			}
			set
			{
				if( !object.Equals(value,null))
				{
					this.instructor = value;
				}
			}
		}
		#endregion

		#region Constructor
		private Jornada()
		{
			this.alumnos = new List<Alumno>();
		}
		public Jornada(Universidad.EClases clase, Profesor instructor) : this()
		{
			this.clase = clase;
			this.instructor = instructor;
		}
		#endregion

		#region Operadores
		public static bool operator ==(Jornada j , Alumno a)
		{
			return a == j.Clase;
		}
		public static Jornada operator +(Jornada j, Alumno a)
		{
			j.Alumnos.Add(a);
			foreach ( Alumno item in j.Alumnos)
			{
				if (item == a)
				{
					j.Alumnos.Remove(a);
					break;
				}
			}
			return j;
		}
		public static bool operator !=(Jornada j, Alumno a)
		{
			return !(j==a);
		}
		#endregion

		#region Metodos
		public override string ToString()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine("JORNADA:");
			datos.AppendFormat("CLASE DE {0}",this.Clase.ToString());
			datos.AppendLine(this.Instructor.ToString());
			foreach (Alumno item in this.Alumnos)
			{
				datos.AppendLine(item.ToString());
			}
			return datos.ToString();
		}
		public string Leer()
		{
			return "";
		}
		public bool Guardar(Jornada jornada)
		{
			return true;
		}
		#endregion
	}
}
