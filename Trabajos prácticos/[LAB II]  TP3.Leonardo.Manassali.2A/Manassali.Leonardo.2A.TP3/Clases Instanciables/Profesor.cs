using System;
using System.Collections.Generic;
using EntidadesAbstractas;
using ClasesInstanciables;

namespace ClasesInstanciables
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
		static Profesor()
		{
			Profesor.random = new Random();
		}
		public Profesor(int id, string nombre , string apellido , string dni , ENacionalidad nacionalidad) : base(id,nombre,apellido,dni,nacionalidad) 
		{
			this.clasesDelDia = new Queue<Universidad.EClases>();
			this._randomClases();
		}
		#endregion

		#region Operadores
		public static bool operator ==(Profesor i , Universidad.EClases clase)
		{
			bool verificacion = false;
			foreach (Universidad.EClases item in i.clasesDelDia)
			{
				if(item == clase)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Profesor i, Universidad.EClases clase)
		{
			return !(i == clase);
		}
		#endregion

		#region Metodos
		public override string ToString()
		{
			return this.MostrarDatos();
		}
		protected override string MostrarDatos()
		{
			return base.MostrarDatos() + this.ParticiparEnClase();
		}
		protected override string ParticiparEnClase()
		{
			string datos = "CLASES DEL DÍA\r\n";
			foreach (Universidad.EClases item in this.clasesDelDia)
			{
				datos = item.ToString() + '\n';
 			}
			return datos;
		}
		private void _randomClases()
		{
			this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 3));
			this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 3));
		}
		#endregion
	}
}
