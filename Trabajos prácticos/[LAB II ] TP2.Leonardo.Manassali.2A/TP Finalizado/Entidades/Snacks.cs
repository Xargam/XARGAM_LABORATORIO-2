using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2018
{
    public class Snacks : Producto
    {
		#region Propiedades

		/// <summary>
		/// Los snacks tienen 104 calorías
		/// </summary>
		protected override short CantidadCalorias
		{
			get
			{
				return 104;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Inicializa un objeto.
		/// </summary>
		/// <param name="marca">Enumerado de marcas de tipo EMarca.</param>
		/// <param name="patente">Codigo de barras del producto.</param>
		/// <param name="color">Enumerado de colores de tipo ConsoleColor.</param>
		public Snacks(EMarca marca, string patente, ConsoleColor color)
			: base(patente, marca, color)
		{
		}

		#endregion

		#region Override

		/// <summary>
		/// Muestra los datos de un objeto.
		/// </summary>
		/// <returns></returns>
		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("SNACKS");
			sb.AppendLine(base.Mostrar());
			sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
			sb.AppendLine("");
			sb.AppendLine("---------------------");

			return sb.ToString();
		} 

		#endregion
	}
}
