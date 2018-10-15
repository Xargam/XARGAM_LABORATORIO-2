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
		public override float CostoLlamada
		{
			get
			{
				return this.CalcularCosto();
			}
		}
		#endregion

		#region Constructor
		public Local(Llamada llamada , float costo) : this(llamada.NroOrigen, llamada.Duracion , llamada.NroDestino,costo)
		{
		}
		public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
		{
			this._costo = costo;
		}
		#endregion

		#region Metodos
		public override bool Equals(object obj)
		{
			return obj is Local;
		}
		public override string ToString()
		{
			return this.Mostrar();
		}
		protected override string Mostrar()
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
