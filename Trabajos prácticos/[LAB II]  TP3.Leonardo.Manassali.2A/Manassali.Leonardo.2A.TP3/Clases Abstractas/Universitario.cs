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
		public Universitario(int legajo, string nombre , string apellido , string dni , ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
		{
			this.legajo = legajo;
		}
		#endregion

		#region Operadores
		public static bool operator ==(Universitario pg1, Universitario pg2)
		{
			return pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI);
		}
		public static bool operator !=(Universitario pg1, Universitario pg2)
		{
			return !(pg1 == pg2);
		}
		#endregion

		#region Metodos
		public override bool Equals(object obj)
		{
			return obj.GetType() == this.GetType();
		}
		protected virtual string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.ToString());
			datos.AppendFormat("Legajo: {0}\r\n", this.legajo);
			return datos.ToString();
		}
		protected abstract string ParticiparEnClase();
		#endregion
	}
}
