using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2018
{
    public class Dulce : Producto
    {
		#region Propiedades

		/// <summary>
		/// Los dulces tienen 80 calorías
		/// </summary>
		protected override short CantidadCalorias
		{
			get
			{
				return 80;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Inicializa un dulce.
		/// </summary>
		/// <param name="marca">Enumerado de marcas de tipo EMarca.</param>
		/// <param name="patente">Codigo de barras del producto.</param>
		/// <param name="color">Enumerado de colores de tipo ConsoleColor.</param>
		public Dulce(EMarca marca, string patente, ConsoleColor color) : base(patente, marca, color)
		{
		}

		#endregion

		#region Override

		/// <summary>
		/// Muestra datos de un objecto.
		/// </summary>
		/// <returns></returns>
		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("DULCE");
			sb.AppendLine(base.Mostrar());
			sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
			sb.AppendLine("");
			sb.AppendLine("---------------------");

			return sb.ToString();
		} 

		#endregion
	}
}
