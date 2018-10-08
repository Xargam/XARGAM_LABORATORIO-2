using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades2018
{
    public class Leche : Producto
    {
		#region Atributos

		private ETipo tipo;

		#endregion

		#region Propiedades

		/// <summary>
		/// Las leches tienen 20 calorías
		/// </summary>
		protected override short CantidadCalorias
		{
			get
			{
				return 20;
			}
		}
		#endregion

		#region Constructor

		/// <summary>
		/// Por defecto, TIPO será ENTERA
		/// </summary>
		/// <param name="marca">Enumerado de marcas de tipo EMarca.</param>
		/// <param name="patente">Codigo de barras del producto.</param>
		/// <param name="color">Enumerado de colores de tipo ConsoleColor.</param>
		public Leche(EMarca marca, string patente, ConsoleColor color)
			: base(patente, marca, color)
		{
			this.tipo = Leche.ETipo.Entera;
		}

		/// <summary>
		/// Inicializa un objeto.
		/// </summary>
		/// <param name="marca">Enumerado de marcas de tipo EMarca.</param>
		/// <param name="patente">Codigo de barras del producto.</param>
		/// <param name="color">Enumerado de colores de tipo ConsoleColor.</param>
		/// <param name="tipo">Enumerado de tipos de tipo ETipo.</param>
		public Leche(EMarca marca, string patente, ConsoleColor color, ETipo tipo)
			: base(patente, marca, color)
		{
			this.tipo = tipo;
		}

		#endregion

		#region Override

		/// <summary>
		/// Muestra datos de un objeto.
		/// </summary>
		/// <returns></returns>
		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("LECHE");
			sb.AppendLine(base.Mostrar());
			sb.AppendFormat("CALORIAS : {0} TIPO : {1}", this.CantidadCalorias, this.tipo.ToString());
			sb.AppendLine("\r\n\r\n---------------------");

			return sb.ToString();
		} 

		#endregion

		#region Enumerados

		/// <summary>
		/// Enumerado de tipos de leche.
		/// </summary>
		public enum ETipo
		{
			Entera,
			Descremada
		} 

		#endregion
	}
}
