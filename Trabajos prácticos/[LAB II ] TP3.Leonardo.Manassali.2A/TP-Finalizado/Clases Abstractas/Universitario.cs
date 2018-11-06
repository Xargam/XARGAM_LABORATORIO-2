using System.Text;

namespace EntidadesAbstractas
{
	public abstract class Universitario : Persona
	{
		#region Atributos
		private int legajo;
		#endregion

		#region Constructores
		public Universitario()
		{
		}
		/// <summary>
		/// Inicializa un objeto Universitario con todos sus datos.
		/// </summary>
		/// <param name="legajo"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Universitario(int legajo, string nombre , string apellido , string dni , ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
		{
			this.legajo = legajo;
		}
		#endregion

		#region Operadores
		/// <summary>
		/// Dos universitarios serán iguales si poseen igual DNI o legajo y pertenecen a la misma clase C#.
		/// </summary>
		/// <param name="pg1">Universitario a comparar.</param>
		/// <param name="pg2">Universitario a comparar.</param>
		/// <returns>Devuelve true si los objetos son iguales o false en caso contrario.</returns>
		public static bool operator ==(Universitario pg1, Universitario pg2)
		{
			//Esta evaluación imposibilita generar un error en tiempo de ejecución de la aplicación con valores nulos.
			return !object.Equals(pg1, null) && pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI);
		}
		/// <summary>
		/// Dos universitarios serán distintos si su legajo o DNI no coinciden o son de distinta clase C#.
		/// </summary>
		/// <param name="pg1">Universitario a comparar.</param>
		/// <param name="pg2">Universitario a comparar.</param>
		/// <returns>Devuelve true si los objetos son distintos o false en caso contrario.</returns>
		public static bool operator !=(Universitario pg1, Universitario pg2)
		{
			return !(pg1 == pg2);
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Verifica que dos objetos de tipo universitario sean de la misma clase.
		/// </summary>
		/// <param name="obj">Objeto a comparar.</param>
		/// <returns>Devuelve true si los objetos son de la misma clase.</returns>
		public override bool Equals(object obj)
		{
			//Revisa que el objeto no sea nulo para no generar un error en tiempo de ejecución.
			return !object.Equals(obj,null) && this.GetType() == obj.GetType();
		}
		/// <summary>
		/// Muestra los datos del objeto Universitario y los devuelve como string.
		/// </summary>
		/// <returns></returns>
		protected virtual string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.ToString());
			datos.AppendFormat("LEGAJO NÚMERO: {0}", this.legajo);
			return datos.ToString();
		}
		protected abstract string ParticiparEnClase();
		#endregion
	}
}
