using Excepciones;
using System.Text;

namespace EntidadesAbstractas
{
	//	Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
	// Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad.Argentino entre 1 y
	//89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción
	//NacionalidadInvalidaException.
	// Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará
	//DniInvalidoException.
	// Sólo se realizarán las validaciones dentro de las propiedades.
	// Validará que los nombres sean cadenas con caracteres válidos para nombres.Caso contrario, no se
	//cargará.
	// ToString retornará los datos de la Persona.
	public abstract class Persona
	{
		#region Atributos
		private string nombre;
		private string apellido;
		private int dni;
		private ENacionalidad nacionalidad;
		#endregion

		#region Propiedades
		public string Apellido
		{
			get
			{
				return this.apellido;
			}
			set
			{
				this.apellido = value;
			}
		}
		public int DNI
		{
			get
			{
				return this.dni;
			}
			set  
			{
				this.dni = this.ValidarDni(this.Nacionalidad,value);
			}
		}
		public ENacionalidad Nacionalidad
		{
			get
			{
				return this.nacionalidad;
			}
			set 
			{
				this.nacionalidad = value;
			}
		}
		public string Nombre
		{
			get 
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		public string StringToDNI
		{
			set
			{
				this.dni = this.ValidarDni(this.nacionalidad, value);
			}
		}
		#endregion

		#region Constructores
		public Persona()
		{

		}
		public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Nacionalidad = nacionalidad;
		}
		public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,dni.ToString(),nacionalidad)
		{
		}
		public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
		{
			this.StringToDNI = dni;
		}
		#endregion

		#region Metodos
		public override string ToString()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Nombre y apellido: {0} {1}\r\n", this.Nombre, this.Apellido);
			datos.AppendFormat("DNI: {0}\r\n", this.DNI);
			datos.AppendFormat("Nacionalidad: {0}", this.Nacionalidad.ToString());
			return datos.ToString();
		}
		private int ValidarDni(ENacionalidad nacionalidad, int dato)
		{
			if ((nacionalidad == ENacionalidad.Argentino && (dato > 89999999 || dato < 1)) || (nacionalidad == ENacionalidad.Extranjero && (dato > 99999999 || dato < 90000000)))
			{
				throw new NacionalidadInvalidaException("El número de DNI no coincide para la nacionalidad o es invalido.");
			}
			return dato;
		}
		private int ValidarDni(ENacionalidad nacionalidad, string dato)
		{
			if(dato.Length > 0 && dato.Length < 9 && int.TryParse(dato, out dni))
			{
				dni = this.ValidarDni(nacionalidad, dni);
			}
			else
			{
				throw new DniInvalidoException("El DNI posee un error de formato.");
			}
			return dni;
		}
		private string ValidarNombreApellido(string dato)
		{
			foreach (char item in dato)
			{
				if(!char.IsLetter(item))
				{
					dato = string.Empty;
					break;
				}
			}
			return dato;
		}
		#endregion

		#region Enumerados
		public enum ENacionalidad
		{
			Argentino,
			Extranjero
		}
		#endregion
	}
}