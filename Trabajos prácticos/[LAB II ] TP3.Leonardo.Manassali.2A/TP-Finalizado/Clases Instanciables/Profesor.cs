using System;
using System.Collections.Generic;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
	public sealed class Profesor : Universitario
	{
		#region Atributos
		private Queue<Universidad.EClases> clasesDelDia;
		private static Random random;
		#endregion

		#region Constructor
		public Profesor()
		{
		}
		/// <summary>
		/// Inicializa atributo estático random.
		/// </summary>
		static Profesor()
		{
			Profesor.random = new Random();
		}
		/// <summary>
		/// Inicializa todos los campos de un objeto Profesor y genera dos clases al azar para el profesor.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Profesor(int id, string nombre , string apellido , string dni , ENacionalidad nacionalidad) : base(id,nombre,apellido,dni,nacionalidad) 
		{
			this.clasesDelDia = new Queue<Universidad.EClases>();
			this.RandomClases();
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Un profesor será igual a una clase si dicta la misma.
		/// </summary>
		/// <param name="i">Profesor a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve true si el profesor es igual a la clase o false en caso contrario.</returns>
		public static bool operator ==(Profesor i , Universidad.EClases clase)
		{
			bool verificacion = false;
			if (!object.Equals(i,null))
			{
				foreach (Universidad.EClases item in i.clasesDelDia)
				{
					if (item == clase)
					{
						verificacion = true;
						break;
					}
				}
			}
			return verificacion;
		}
		/// <summary>
		/// Un profesor será distinto de una clase si NO dicta la misma.
		/// </summary>
		/// <param name="i">Profesor a comparar.</param>
		/// <param name="clase">Clase a comparar.</param>
		/// <returns>Devuelve true si el profesor no da la clase o false en caso contrario.</returns>
		public static bool operator !=(Profesor i, Universidad.EClases clase)
		{
			return !(i == clase);
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve una cadena con los datos del objeto Profesor.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}
		/// <summary>
		/// Genera una cadena con los datos del objeto y la clase base y la devuelve.
		/// </summary>
		/// <returns></returns>
		protected override string MostrarDatos()
		{
			return base.MostrarDatos() + this.ParticiparEnClase();
		}
		/// <summary>
		/// Devuelve una cadena con los datos del atributo clasesDelDia del objeto profesor.
		/// </summary>
		/// <returns></returns>
		protected override string ParticiparEnClase()
		{
			string datos = "\r\nCLASES DEL DÍA:\r\n";
			foreach (Universidad.EClases item in this.clasesDelDia)
			{
				datos += item.ToString() + "\r\n";
 			}
			return datos;
		}
		/// <summary>
		/// Inicializa la cola del objeto profesor con dos Clases al azar.
		/// </summary>
		private void RandomClases()
		{
			this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
			this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
		}
		#endregion
	}
}
