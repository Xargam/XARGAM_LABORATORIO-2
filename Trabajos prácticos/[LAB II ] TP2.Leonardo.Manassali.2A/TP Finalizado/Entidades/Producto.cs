using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
		#region Atributos

		private string codigoDeBarras;
		private ConsoleColor colorPrimarioEmpaque;
		private EMarca marca;

		#endregion

		#region Propiedades

		/// <summary>
		/// ReadOnly: Retornará la cantidad de calorias del producto.
		/// </summary>
		protected abstract short CantidadCalorias
		{
			get;
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Inicializa un objeto.
		/// </summary>
		/// <param name="marca">Enumerado de marcas de tipo EMarca.</param>
		/// <param name="patente">Codigo de barras del producto.</param>
		/// <param name="color">Enumerado de colores de tipo ConsoleColor.</param>
		public Producto(string patente, EMarca marca, ConsoleColor color)
		{
			this.marca = marca;
			this.codigoDeBarras = patente;
			this.colorPrimarioEmpaque = color;
		}

		#endregion

		#region Sobrecargas

		/// <summary>
		/// Obtiene datos del objeto a partir de un casteo explcito.
		/// </summary>
		/// <param name="p"></param>
		public static explicit operator string(Producto p)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", p.codigoDeBarras);
			sb.AppendFormat("MARCA          : {0}\r\n", p.marca.ToString());
			sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", p.colorPrimarioEmpaque.ToString());
			sb.AppendLine("---------------------");

			return sb.ToString();
		}

		/// <summary>
		/// Dos productos son iguales si comparten el mismo código de barras
		/// </summary>
		/// <param name="v1">Producto 1</param>
		/// <param name="v2">Producto 2</param>
		/// <returns></returns>
		public static bool operator ==(Producto v1, Producto v2)
		{
			return (v1.codigoDeBarras == v2.codigoDeBarras);
		}

		/// <summary>
		/// Dos productos son distintos si su código de barras es distinto
		/// </summary>
		/// <param name="v1">Producto 1</param>
		/// <param name="v2">Producto 2</param>
		/// <returns></returns>
		public static bool operator !=(Producto v1, Producto v2)
		{
			return !(v1 == v2);
		}

		#endregion

		#region Metodos

		/// <summary>
		/// Publica todos los datos del Producto.
		/// </summary>
		/// <returns></returns>
		public virtual string Mostrar()
		{
			return (string)this;
		}

		#endregion

		#region Enumerados

		/// <summary>
		/// Enumerados de marcas de productos.
		/// </summary>
		public enum EMarca
		{
			Serenisima,
			Campagnola,
			Arcor,
			Ilolay,
			Sancor,
			Pepsico
		} 

		#endregion
	}
}
