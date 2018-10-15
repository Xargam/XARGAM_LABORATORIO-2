using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
	public class Cliente
	{
		#region Atributos
		private string _nombre;
		private int _numero;
		#endregion

		#region Propiedades
		public string Nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				this._nombre = value;
			}
		}
		public int Numero
		{
			get
			{
				return this._numero;
			}
		}
		#endregion

		#region Constructor
		public Cliente(int numero)
		{
			this._numero = numero;
		}
		public Cliente(int numero, string nombre) : this(numero)
		{
			this.Nombre = nombre;
		}
		#endregion

		#region Operadores
		public static bool operator ==(Cliente c1 , Cliente c2)
		{
			return c1.Numero == c2.Numero;
		}
		public static bool operator !=(Cliente c1, Cliente c2)
		{
			return !(c1 == c2);
		}
		#endregion
	}
}
