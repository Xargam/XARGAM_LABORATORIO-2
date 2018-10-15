using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_31
{
	public class PuestoAtencion
	{
		#region Atributos
		private static int _numeroActual;
		private Puesto _puesto;
		#endregion

		#region Propiedades
		public static int NumeroActual
		{
			get
			{
				return ++PuestoAtencion._numeroActual;
			}
		}
		#endregion

		#region Constructor
		static PuestoAtencion()
		{
			PuestoAtencion._numeroActual = 0;
		}
		public PuestoAtencion(Puesto puesto)
		{
			this._puesto = puesto;
		}
		#endregion

		#region Metodos
		public bool AtenderCliente(Cliente cli)
		{
			PuestoAtencion._numeroActual = PuestoAtencion.NumeroActual;
			Thread.Sleep(5000);
			return true;
		}
		#endregion

		#region Enumerados
		public enum Puesto
		{
			caja1,
			caja2
		}
		#endregion
	}
}
