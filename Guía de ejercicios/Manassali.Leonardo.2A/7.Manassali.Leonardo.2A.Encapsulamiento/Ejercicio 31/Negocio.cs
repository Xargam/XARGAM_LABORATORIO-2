using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
	public class Negocio
	{
		#region Atributos
		private PuestoAtencion _caja;
		private Queue<Cliente> _clientes;
		private string _nombre;
		#endregion

		#region Propiedades
		public int ClientesPendientes
		{
			get
			{
				return this._clientes.Count;
			}
		}
		public Cliente Cliente
		{
			get
			{
				return this._clientes.Dequeue();
			}
			set
			{
				if(this != value)
				{
					this._clientes.Enqueue(value);
				}
			}
		}
		#endregion

		#region Constructor
		private Negocio()
		{
			this._clientes = new Queue<Cliente>();
			this._caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
		}
		public Negocio(string nombre) : this()
		{
			this._nombre = nombre;
		}
		#endregion

		#region Operadores
		public static bool operator +(Negocio n, Cliente c)
		{
			n.Cliente = c;
			return n != c;
		}
		public static bool operator ~(Negocio n)
		{
			bool verificacion = n.ClientesPendientes > 0;
			if( verificacion )
			{
				n._caja.AtenderCliente(n.Cliente);
			}
			return verificacion;
		}
		public static bool operator ==(Negocio n, Cliente c)
		{
			bool verificacion = false;
			foreach (Cliente item in n._clientes)
			{
				if( item == c )
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Negocio n, Cliente c)
		{
			return !(n == c);
		}
		#endregion

	}
}
