using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
	public class DirectorTecnico : Persona
	{
		#region Atributos
		private DateTime _fechaNacimiento;
		#endregion

		#region Constructor
		private DirectorTecnico(string nombre) : base(nombre)
		{
		}
		public DirectorTecnico(string nombre , DateTime fechaNacimiento) : this(nombre)
		{
			this._fechaNacimiento = fechaNacimiento;
		}
		#endregion

		#region Operadores
		public static bool operator ==(DirectorTecnico t1 , DirectorTecnico t2)
		{
			return t1.Nombre == t2.Nombre && t1._fechaNacimiento == t2._fechaNacimiento;
		}
		public static bool operator !=(DirectorTecnico t1, DirectorTecnico t2)
		{
			return !(t1 == t2);
		}
		#endregion

		#region Metodos
		public new string MostrarDatos()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Nombre: {0}\n",this.Nombre);
			datos.AppendFormat("Fecha de nacimiento: {0:dd/MM/yyyy}\n", this._fechaNacimiento);
			return datos.ToString();
		}
		#endregion
	}
}
