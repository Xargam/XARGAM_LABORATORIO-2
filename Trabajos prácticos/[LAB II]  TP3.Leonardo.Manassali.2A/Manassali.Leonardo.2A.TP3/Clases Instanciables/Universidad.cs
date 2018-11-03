using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;

namespace ClasesInstanciables
{
	public class Universidad
	{
		#region Atributos
		private List<Alumno> alumnos;
		private List<Jornada> jornada;
		private List<Profesor> profesores;
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
				if(!Object.Equals(null,value))
				{
					this.alumnos = value;
				}
			}
		}
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
		public Jornada this[int i]
		{
			get
			{
				Jornada jornada = null;
				if (i >= 0 && i < this.jornada.Count)
				{
					jornada = this.jornada[i];
				}
				return jornada;
			}
			set
			{
				this.jornada.Add(value);
			}
		}
		#endregion

		#region Constructor
		public Universidad()
		{
			this.profesores = new List<Profesor>();
			this.alumnos = new List<Alumno>();
			this.jornada = new List<Jornada>();
		}
		#endregion

		#region Operadores

		#region Comparacion
		public static bool operator !=(Universidad g, Alumno a)
		{
			return !(g == a);
		}
		public static bool operator !=(Universidad g, Profesor i)
		{
			return !(g == i); ;
		}
		public static Profesor operator !=(Universidad u, EClases clase)
		{
			Profesor profesor = null;
			foreach (Profesor item in u.Instructores)
			{
				if (item != clase)
				{
					profesor = item;
					break;
				}
			}
			if( object.Equals(profesor,null))
			{
				throw new SinProfesorException();
			}
			return profesor;
		}


		public static bool operator ==(Universidad g, Alumno a)
		{
			bool verificacion = false;
			foreach (Alumno item in g.Alumnos)
			{
				if (item == a)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator ==(Universidad g, Profesor i)
		{
			bool verificacion = false;
			foreach (Profesor item in g.Instructores)
			{
				if (item == i)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static Profesor operator ==(Universidad u, EClases clase)
		{
			Profesor profesor = null;
			foreach (Profesor item in u.Instructores)
			{
				if (item == clase)
				{
					profesor = item;
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
		public static Universidad operator +(Universidad g, EClases clase)
		{
			Profesor profesor = g == clase;
			Jornada jornada = new Jornada(clase, profesor);

			foreach (Alumno item in g.Alumnos)
			{
				if(item == clase)
				{
					jornada += item;
				}
			}
			g.Jornadas.Add(jornada);
			return g;
		}
		public static Universidad operator +(Universidad u, Alumno a)
		{
			if(u != a)
			{
				u.Alumnos.Add(a);
			}
			else
			{
				throw new AlumnoRepetidoException();
			}
			return u;
		}
		public static Universidad operator +(Universidad u, Profesor i)
		{
			if (u != i)
			{
				u.profesores.Add(i);
			}
			return u;
		}
		#endregion


		#endregion

		#region Metodos
		public override string ToString()
		{
			return Universidad.MostrarDatos(this);
		}
		public bool Guardar(Universidad uni)
		{
			return true;
		}
		private static string MostrarDatos(Universidad uni)
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine("Profesores:");
			foreach (Profesor item in uni.Instructores)
			{
				datos.AppendLine(item.ToString());
			}
			datos.AppendLine("Alumnos:");
			foreach (Alumno item in uni.Alumnos)
			{
				datos.AppendLine(item.ToString());
			}
			datos.AppendLine("Jornadas:");
			foreach (Jornada item in uni.Jornadas)
			{
				datos.AppendLine(item.ToString());
			}
			return datos.ToString();
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
