using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;
using Archivos;

namespace EntidadesInstanciables
{
	public class Universidad
	{
		#region Atributos
		private List<Alumno> alumnos;
		private List<Jornada> jornada;
		private List<Profesor> profesores;
		#endregion

		#region Propiedades
		/// <summary>
		/// La lista de alumnos solo será seteada si no apunta a null.
		/// </summary>
		public List<Alumno> Alumnos
		{
			get
			{
				return this.alumnos;
			}
			set
			{
				if(!Object.Equals(null,value))
				{
					this.alumnos = value;
				}
			}
		}
		/// <summary>
		/// La lista de profesores solo será seteada si no apunta a null.
		/// </summary>
		public List<Profesor> Instructores
		{
			get
			{
				return this.profesores;
			}
			set
			{
				if (!Object.Equals(null, value))
				{
					this.profesores = value;
				}
			}
		}
		/// <summary>
		/// La lista de jornadas solo será seteada si no apunta a null.
		/// </summary>
		public List<Jornada> Jornadas
		{
			get
			{
				return this.jornada;
			}
			set
			{
				if (!Object.Equals(null, value))
				{
					this.jornada = value;
				}
			}
		}
		#endregion

		#region Indexadores
		/// <summary>
		/// Permite indexar la lista de jornadas, si  se intenta acceder a un índice inválido lanza una excepción acorde.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Jornada this[int i]
		{
			get
			{
				Jornada jornada = null;
				if (i >= 0 && i < this.Jornadas.Count)
				{
					jornada = this.Jornadas[i];
				}
				return jornada;
			}
			set
			{
				if (!object.Equals(value, null))
				{
					if (i >= 0 && i < this.Jornadas.Count)
					{
						this.Jornadas[i] = value;
					}
					else if ( i == this.Jornadas.Count )
					{
						this.Jornadas.Add(value);
					}
				}
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Inicializa un objeto Universidad.
		/// </summary>
		public Universidad()
		{
			this.Instructores = new List<Profesor>();
			this.Alumnos = new List<Alumno>();
			this.Jornadas = new List<Jornada>();
		}
		#endregion

		#region Operadores

		#region Comparacion
		/// <summary>
		/// Una universidad será distinta a un alumno si este NO se encuentra inscripto.
		/// </summary>
		/// <param name="g">Universidad a comparar.</param>
		/// <param name="a">Alumno a comparar.</param>
		/// <returns>Devuelve true si la universidad es distinta al alumno o false en caso contrario.</returns>
		public static bool operator !=(Universidad g, Alumno a)
		{
			return !(g == a);
		}
		/// <summary>
		/// Una universidad será distinta a un profesor si este NO dicta clases en ella.
		/// </summary>
		/// <param name="g">Universidad a comparar.</param>
		/// <param name="i">Profesor a comparar.</param>
		/// <returns>Devuelve true si la universidad es distinta al profesor o false en caso contrario.</returns>
		public static bool operator !=(Universidad g, Profesor i)
		{
			return !(g == i); ;
		}
		/// <summary>
		/// Una universidad será disntinta a una clase si hay un profesor en ella que no dicte la clase.
		/// </summary>
		/// <param name="u">Universidad a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve el primer profesor que no puede dictar la clase o lanza una excepción si todos pueden dictarla.</returns>
		public static Profesor operator !=(Universidad u, EClases clase)
		{
			Profesor profesor = null;
			if (!object.Equals(u,null))
			{
				foreach (Profesor item in u.Instructores)
				{
					if (item != clase)
					{
						profesor = item;
						break;
					}
				}
			}
			if ( object.Equals(profesor,null))
			{
				throw new SinProfesorException();
			}
			return profesor;
		}

		/// <summary>
		/// Una universidad será igual a un alumno si este se encuentra inscripto.
		/// </summary>
		/// <param name="g">Universidad a comparar.</param>
		/// <param name="a">Alumno a comparar.</param>
		/// <returns>Devuelve true si la universidad es igual al alumno o false en caso contrario.</returns>
		public static bool operator ==(Universidad g, Alumno a)
		{
			bool verificacion = false;
			if (!object.Equals(g,null))
			{
				foreach (Alumno item in g.Alumnos)
				{
					if (item == a)
					{
						verificacion = true;
						break;
					}
				}
			}
			return verificacion;
		}
		/// <summary>
		/// Una universidad será igual a un profesor si este dicta clases en ella.
		/// </summary>
		/// <param name="g">Universidad a comprarar.</param>
		/// <param name="i">Profesor a comparar.</param>
		/// <returns>Devuelve true si la universidad es igual al profesor o false en caso contrario.</returns>
		public static bool operator ==(Universidad g, Profesor i)
		{
			bool verificacion = false;
			if (!object.Equals(g, null))
			{
				foreach (Profesor item in g.Instructores)
				{
					if (item == i)
					{
						verificacion = true;
						break;
					}
				}
			}
			return verificacion;
		}
		/// <summary>
		/// Una universidad será igual a una clase si esta tiene un profesor que pueda darla. Retorna el primer profesor capaz de dictarla o lanza una excepción propia en caso de no haber ninguno.
		/// </summary>
		/// <param name="u">Universidad a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve el objeto profesor alamcenado en la universidad que dicta la clase pasada por parámetro.</returns>
		public static Profesor operator ==(Universidad u, EClases clase)
		{
			Profesor profesor = null;
			if (!object.Equals(u,null))
			{
				foreach (Profesor item in u.Instructores)
				{
					if (item == clase)
					{
						profesor = item;
						break;
					}
				}
			}
			if( object.Equals(profesor,null))
			{
				throw new SinProfesorException();
			}
			return profesor;
		}
		#endregion

		#region Aritmeticos
		/// <summary>
		/// Agrega una jornada a la universidad. Esta será de la clase pasada por parámetro y tendrá un profesor de la universidad capaz de dictarla. Todos los alumnos de la universidad que coincidan con la clase agregada a la jornada serán adicionados a la misma. Devuelve la universidad cargada. Puede generar una excepción a falta de un profesor.
		/// </summary>
		/// <param name="g">Universidad en la que agregará una clase.</param>
		/// <param name="clase">Clase a agergar a universidad.</param>
		/// <returns>Devuelve el objeto de tipo universidad.</returns>
		public static Universidad operator +(Universidad g, EClases clase)
		{
			//Si el igual no encuentra profesor lanza excepción y el flujo se va del método.
			Profesor profesor = g == clase;
			Jornada jornada = new Jornada(clase, profesor);
			foreach (Alumno item in g.Alumnos)
			{
				jornada += item;
			}
			g.Jornadas.Add(jornada);
			return g;
		}
		/// <summary>
		/// Agrega un alumno a la lista de la universidad si el alumno no se encuentra en la misma y devuelve la universidad. Si el alumno ya se encuentra lanza una excepción propia.
		/// </summary>
		/// <param name="u">Universidad donde agregar al profesor.</param>
		/// <param name="a">Alumno a agregar.</param>
		/// <returns>Devuelve el objeto de tipo universidad.</returns>
		public static Universidad operator +(Universidad u, Alumno a)
		{
			if (!object.Equals(u, null) && !object.Equals(a, null) )
			{
				if (u == a)
				{
					throw new AlumnoRepetidoException();
				}
				u.Alumnos.Add(a);
			}
			return u;
		}
		/// <summary>
		/// Agrega un profesor a la lista de la universidad si este no está registrado.
		/// </summary>
		/// <param name="u">Universidad donde agregar al profesor.</param>
		/// <param name="i">Profesor a agregar.</param>
		/// <returns>Devuelve el objeto de tipo universidad.</returns>
		public static Universidad operator +(Universidad u, Profesor i)
		{
			if ( !object.Equals(u,null) && !object.Equals(i, null) && u != i)
			{
				u.Instructores.Add(i);
			}
			return u;
		}
		#endregion

		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve una cadena con los datos del objeto Universidad.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Universidad.MostrarDatos(this);
		}
		/// <summary>
		/// Genera una cadena con los datos del objeto universidad.
		/// </summary>
		/// <param name="uni">Universidad de donde obtener datos.</param>
		/// <returns>Devuelve una cadena.</returns>
		private static string MostrarDatos(Universidad uni)
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine("JORNADAS:");
			foreach (Jornada item in uni.Jornadas)
			{
				datos.AppendLine(item.ToString());
			}
			datos.AppendLine("ALUMNOS:");
			foreach (Alumno item in uni.Alumnos)
			{
				datos.AppendLine(item.ToString());
			}
			datos.AppendLine("<------------------------------------------------>\r\n");
			datos.AppendLine("PROFESORES:");
			foreach (Profesor item in uni.Instructores)
			{
				datos.AppendLine(item.ToString());
			}
			datos.AppendLine("<------------------------------------------------>");
			return datos.ToString();
		}
		/// <summary>
		/// Guarda los datos un objeto universidad en un archivo XML junto al .exe de la aplicación mediante serialización. Puede generar una excepción si se produce un error.
		/// </summary>
		/// <param name="uni">Objeto con datos a guardar.</param>
		/// <returns>Devuelve true en caso de éxito.</returns>
		public static bool Guardar(Universidad uni)
		{
			return (object.Equals(uni,null))? false : new Xml<Universidad>().Guardar(".\\Universidad.xml", uni);
		}
		/// <summary>
		/// Lee los datos de un archivo XML previamente generado junto al .exe de la aplicación y los guarda en un objeto universiddad que será devuelto. Puede generar excepciones en caso de error.
		/// </summary>
		/// <param name="uni">Objeto donde se guardarán los datos leidos.</param>
		/// <returns>Devuelve el objeto universidad.</returns>
		public static Universidad Leer(Universidad uni)
		{
			new Xml<Universidad>().Leer(".\\Universidad.xml", out uni);
			return uni;
		}
		#endregion

		#region Enumerados
		public enum EClases
		{
			Programacion,
			Laboratorio,
			Legislacion,
			SPD
		}
		#endregion
	}
}
