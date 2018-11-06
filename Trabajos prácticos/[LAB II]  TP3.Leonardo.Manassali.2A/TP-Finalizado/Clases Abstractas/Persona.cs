using Excepciones;
using System.Text;

namespace EntidadesAbstractas
{
	public abstract class Persona
	{
		#region Atributos
		private string nombre;
		private string apellido;
		private int dni;
		private ENacionalidad nacionalidad;
		#endregion

		#region Propiedades
		/// <summary>
		/// El apellido solo será seteado si es una cadena de caracteres válida para este dato.
		/// </summary>
		public string Apellido
		{
			get
			{
				return this.apellido;
			}
			set
			{
				this.apellido = this.ValidarNombreApellido(value);
			}
		}
		/// <summary>
		/// Si el DNI a setear no es válido se produce una excepción.
		/// </summary>
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
		/// <summary>
		/// El nombre solo será seteado si es una cadena de caracteres válida para este dato.
		/// </summary>
		public string Nombre
		{
			get 
			{
				return this.nombre;
			}
			set
			{
				this.nombre = this.ValidarNombreApellido(value);
			}
		}
		/// <summary>
		/// Si el DNI a setear no es válido se produce una excepción.
		/// </summary>
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
		/// <summary>
		/// Inicializa un objeto persona sin DNI. Este dato quedará en 0.
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Nacionalidad = nacionalidad;
		}
		/// <summary>
		/// Inicializa un objeto persona con todos sus datos.
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,dni.ToString(),nacionalidad)
		{
		}
		/// <summary>
		/// Inicializa un objeto persona con todos sus datos.
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
		{
			this.StringToDNI = dni;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve una cadena de caracteres detallando los datos del objeto Persona. Si una cadena vacía se ve en algún atributo significa que no se ha cargado un valor correcto al mismo.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("NOMBRE COMPLETO: {0}, {1}\r\n", this.Apellido, this.Nombre);
			datos.AppendFormat("NACIONALIDAD: {0}\r\n", this.Nacionalidad.ToString());
			datos.AppendFormat("DNI: {0}", this.DNI );
			return datos.ToString();
		}
		/// <summary>
		/// Valida que un DNI de tipo int32 extranjero este en un rango que va de 90000000 a 99999999 y uno Argentino entre 1 y 89999999 en caso contrario lanza una excepción propia.
		/// </summary>
		/// <param name="nacionalidad">Nacionalidad asociada del objeto Persona.</param>
		/// <param name="dato">Numero de documento.</param>
		/// <returns>Devuelve el DNI en formato int32 validado.</returns>
		private int ValidarDni(ENacionalidad nacionalidad, int dato)
		{
			if ((nacionalidad == ENacionalidad.Argentino && (dato > 89999999 || dato < 1)) || (nacionalidad == ENacionalidad.Extranjero && (dato > 99999999 || dato < 90000000)))
			{
				throw new NacionalidadInvalidaException("La nacionalidad no se coincide con el número de DNI.");
			}
			return dato;
		}
		/// <summary>
		/// Valida que un DNI en formato string tenga una cantidad correcta de caracteres y sea numérico, en caso de error lanza una excepción. Realiza además una vericación de rango númerico correcto lanzando en ese caso otra excepción.
		/// </summary>
		/// <param name="nacionalidad">Nacionalidad asociada del objeto Persona.</param>
		/// <param name="dato">Numero de documento.</param>
		/// <returns>Devuelve el dni validado en formato int32.</returns>
		private int ValidarDni(ENacionalidad nacionalidad, string dato)
		{
			if( !object.Equals(dato , null) && dato.Length > 0 && dato.Length < 9 && int.TryParse(dato, out dni))
			{
				dni = this.ValidarDni(nacionalidad, dni);
			}
			else
			{
				throw new DniInvalidoException("El DNI posee un error de formato.");
			}
			return dni;
		}
		/// <summary>
		/// Valida que una cadena contenga únicamente caracteres alfabéticos. Devuelve una cadena vacía en caso de error.
		/// </summary>
		/// <param name="dato">Cadena de carácteres a verificar.</param>
		/// <returns></returns>
		private string ValidarNombreApellido(string dato)
		{
			//Si el string recibido es nulo aquí se evita un error.
			dato = (object.Equals(dato, null)) ? "" : dato;
			//Revisa que la cadena contenga letras.
			foreach (char item in dato)
			{
				if (!char.IsLetter(item))
				{
					dato = "";
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