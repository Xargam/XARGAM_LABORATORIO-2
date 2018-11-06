using System.Collections.Generic;
using System.Text;
using Archivos;
using System;
using Excepciones;

namespace EntidadesInstanciables
{
	public class Jornada
	{
		#region Atributos
		private List<Alumno> alumnos;
		private Universidad.EClases clase;
		private Profesor instructor;
		#endregion

		#region Propiedades
		/// <summary>
		/// Solo se setearán listas que no contengan referencias nulas.
		/// </summary>
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
		/// <summary>
		/// El instructor solo será seteado si no contiene una referencia nula.
		/// </summary>
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
		/// <summary>
		/// Inicializa el atributo lista de alumnos.
		/// </summary>
		private Jornada()
		{
			this.Alumnos = new List<Alumno>();
		}
		/// <summary>
		/// Inicializa un objeto jornada.
		/// </summary>
		/// <param name="clase"></param>
		/// <param name="instructor"></param>
		public Jornada(Universidad.EClases clase, Profesor instructor) : this()
		{
			this.Clase = clase;
			this.Instructor = instructor;
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Una jornada será igual a un alumno si el alumno toma la clase registrada en la jornada.
		/// </summary>
		/// <param name="j">Jornada a comparar.</param>
		/// <param name="a">Alumno a comparar.</param>
		/// <returns>Devuelve true si la jornada es igual a la clase o false en caso contrario.</returns>
		public static bool operator ==(Jornada j , Alumno a)
		{
			return !object.Equals(j,null) && a == j.Clase;
		}
		/// <summary>
		/// Una jornada será distinta a un alumno si el alumno NO toma la clase registrada en la jornada.
		/// </summary>
		/// <param name="j">Jornada a comparar.</param>
		/// <param name="a">Alumno a comparar.</param>
		/// <returns>Devuelve true si la jornada es distinta a la clase o false en caso contrario.</returns>
		public static bool operator !=(Jornada j, Alumno a)
		{
			return !(j == a);
		}
		/// <summary>
		/// Agrega un alumno a la jornada solo si este puede cursarla y ya no se encuentra en la misma.
		/// </summary>
		/// <param name="j">Jornada donde se agregará el alumno.</param>
		/// <param name="a">alumno a agregar a la jornada.</param>
		/// <returns>Devuelve la jornada con el alumno cargado si fue posible.</returns>
		/// <summary>
		/// Una jornada será disntina a un alumno si el alumno NO puede tomar la clase registrada en la jornada.
		/// </summary>
		/// <param name="j">Jornada a comparar.</param>
		/// <param name="a">Alumno a comparar.</param>
		/// <returns>Devuelve true si la jornada es distinta al alumno o false en caso ocntrario.</returns>
		public static Jornada operator +(Jornada j, Alumno a)
		{
			//Si la jornada o el alumno son null no es consideran iguales.
			if(j == a ) 
			{
				foreach (Alumno item in j.Alumnos)
				{
					if ( item == a )
					{
						throw new AlumnoRepetidoException();
					}
				}
				j.Alumnos.Add(a);
			}
			return j;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve una cadena con los datos del objeto Jornada.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("CLASE DE {0} POR ",this.Clase.ToString());
			datos.AppendLine( (object.Equals(this.Instructor,null))? "" : this.Instructor.ToString() );
			datos.AppendLine("ALUMNOS:");
			foreach (Alumno item in this.Alumnos)
			{
				datos.AppendLine(item.ToString()) ;
			}
			datos.AppendLine("<------------------------------------------------>");
			return datos.ToString();
		}
		/// <summary>
		/// Lee los datos de un archivo de texto previamente generado junto al .exe de la aplicación y devuelve una cadena con su con su contenido, en caso de error genera una excepción.
		/// </summary>
		/// <returns></returns>
		public static string Leer()
		{
			new Texto().Leer(".\\Jornada.txt", out string datos);
			return datos;
		}
		/// <summary>
		/// Guarda los datos de un objeto de tipo Jornada en un archivo de texto que será generado junto al .exe de la aplicación y devuelve true en caso de éxito o false en caso contrario. Genera una excepción si se produce algún error durante la manipulación de archivos.
		/// </summary>
		/// <param name="jornada"></param>
		/// <returns></returns>
		public static bool Guardar(Jornada jornada)
		{
			return (object.Equals(jornada,null))? false : new Texto().Guardar(".\\Jornada.txt", jornada.ToString());
		}
		#endregion
	}
}
