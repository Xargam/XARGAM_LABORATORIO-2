using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Llamada
	{
		#region Atributos
		protected float _duracion;
		protected string _nroDestino;
		protected string _nroOrigen;
		#endregion

		#region Propiedades
		public float Duracion
		{
			get
			{
				return this._duracion;
			}
		}
		public string NroDestino
		{
			get
			{
				return this._nroDestino;
			}
		}
		public string NroOrigen
		{
			get
			{
				return this._nroOrigen;
			}
		}
		#endregion

		#region Constructor
		public Llamada(float duracion , string nroDestino , string nroOrigen)
		{
			this._duracion = duracion;
			this._nroDestino = nroDestino;
			this._nroOrigen = nroOrigen;
		}
		#endregion

		#region Metodos
		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Duracion: {0}\n", this.Duracion);
			datos.AppendFormat("Numero origen: {0}\n", this.NroOrigen);
			datos.AppendFormat("Numero destino: {0}", this.NroDestino);
			return datos.ToString();
		}
		public static int OrdenarPorDuracion(Llamada llamada1 , Llamada llamada2)
		{
			int ordenamiento = 0;
			if(llamada1.Duracion > llamada2.Duracion )
			{
				ordenamiento = 1;
			}
			else if(llamada2.Duracion > llamada1.Duracion )
			{
				ordenamiento = -1;
			}
			return ordenamiento;
		}
		#endregion

		#region Enumerados
		public enum TipoLlamada
		{
			Local,
			Provincial,
			Todas,
		}
		#endregion
	}
}
