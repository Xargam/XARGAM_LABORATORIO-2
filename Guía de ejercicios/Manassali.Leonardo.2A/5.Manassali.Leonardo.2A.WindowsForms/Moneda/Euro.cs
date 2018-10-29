using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
20. Generar un nuevo proyecto del tipo Console Application.Construir tres clases dentro de un
namespace llamado Billetes: Pesos, Euro y Dolar.
a.Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
equivale a 1,3642 dólares y 1 dólar equivale a 17,55 pesos.
b.El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
c.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los
distintos tipos de datos.
d.Colocar dentro del Main el código necesario para probar todos los métodos.
e.Los constructores privados le darán una cotización respecto del dólar por defecto a las
clases.
f.Los comparadores == compararan cantidades.
g.Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego
sumarlos.
h.Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.
*/

namespace Billetes
{
	public class Euro
	{
		#region Atributos

		private double _cantidad;
		private static float _cotizRespectoDolar;

		#endregion

		#region Constructor

		static Euro()
		{
			Euro._cotizRespectoDolar = 0.87671F;
		}

		public Euro(double cantidad)
		{
			this._cantidad = cantidad;
		}

		public Euro(double cantidad, float cotizacion) : this(cantidad)
		{
			Euro._cotizRespectoDolar = cotizacion;
		}

		#endregion

		#region Operadores

		#region Conversion 

		public static explicit operator Dolar(Euro euros)
		{
			return new Dolar(euros.GetCantidad() / Euro.GetCotizacion());
		}

		public static explicit operator Peso(Euro euros)
		{
			return (Peso)((Dolar)euros);
		}

		public static implicit operator Euro(double euros)
		{
			return new Euro(euros);
		}

		#endregion

		#region SumaResta

		public static Euro operator -(Euro euro, Dolar dolar)
		{
			return (Euro)((Dolar)euro - (Euro)dolar);
		}

		public static Euro operator -(Euro euro, Peso peso)
		{
			return euro - (Dolar)peso;
		}

		public static Euro operator +(Euro euro, Dolar dolar)
		{
			return (Euro)(dolar + euro);
		}

		public static Euro operator +(Euro euro, Peso peso)
		{
			return euro + (Dolar)peso;
		} 

		#endregion

		public static bool operator !=(Euro euros1, Euro euros2)
		{
			return !(euros1 == euros2);
		}

		public static bool operator !=(Euro euros, Peso pesos)
		{
			return !(euros == pesos);
		}

		public static bool operator !=(Euro euros, Dolar dolares)
		{
			return !(euros == dolares);
		}

		public static bool operator ==(Euro euros1, Euro euros2)
		{
			return (Dolar)euros1 == (Dolar)euros2;
		}

		public static bool operator ==(Euro euros, Peso pesos)
		{
			return euros == (Euro)pesos;
		}

		public static bool operator ==(Euro euros, Dolar dolares)
		{
			return euros == (Euro)dolares;
		}

		#endregion

		#region Getters

		public double GetCantidad()
		{
			return this._cantidad;
		}

		public static float GetCotizacion()
		{
			return Euro._cotizRespectoDolar;
		}

		#endregion

	}
}
