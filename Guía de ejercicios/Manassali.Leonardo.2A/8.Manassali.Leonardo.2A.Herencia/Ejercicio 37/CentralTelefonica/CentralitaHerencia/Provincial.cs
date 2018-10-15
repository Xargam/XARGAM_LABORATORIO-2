using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Provincial : Llamada
	{
		#region Atributos
		protected Franja _franjaHoraria;
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
		public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
		{
			this._franjaHoraria = miFranja;
		}
		public Provincial(string origen,Franja miFranja ,float duracion, string destino) : this(miFranja,new Llamada(duracion, destino, origen))
		{
		}
		#endregion

		#region Metodos
		public new string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.Mostrar());
			datos.AppendFormat("Franja horaria: {0}\n", this._franjaHoraria.ToString());
			datos.AppendFormat("Costo: {0}\n", this.CostoLlamada);
			return datos.ToString();
		}
		private float CalcularCosto()
		{
			float precio = 0;
			switch(this._franjaHoraria)
			{
				case Franja.Franja_1:
					precio = this.Duracion * 0.99F;
					break;
				case Franja.Franja_2:
					precio = this.Duracion * 1.25F;
					break;
				case Franja.Franja_3:
					precio = this.Duracion * 0.66F;
					break;
			}
			return precio;
		}
		#endregion

		#region Enumerados
		public enum Franja
		{
			Franja_1,
			Franja_2,
			Franja_3
		}
		#endregion
	}
}
