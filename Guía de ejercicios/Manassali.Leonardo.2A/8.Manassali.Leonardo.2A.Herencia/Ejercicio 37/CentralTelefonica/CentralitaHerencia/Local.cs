using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Local : Llamada
	{
		#region Atributos
		protected float _costo;
		#endregion

		#region Propiedades
		public float CostoLlamada
		{
			get
			{
				return this.CalcularCosto();
			}
		}
		#endregion

		#region Constructor
		public Local(Llamada llamada , float costo) : base(llamada.Duracion, llamada.NroDestino , llamada.NroOrigen)
		{
			this._costo = costo;
		}
		public Local(string origen, float duracion, string destino, float costo) : this( new Llamada(duracion,destino,origen), costo )
		{
		}
		#endregion

		#region Metodos
		public new string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.Mostrar());
			datos.AppendFormat("Costo: {0}\n", this.CostoLlamada);
			return datos.ToString();
		}
		private float CalcularCosto()
		{
			return this.Duracion * this._costo;
		}
		#endregion
	}
}
