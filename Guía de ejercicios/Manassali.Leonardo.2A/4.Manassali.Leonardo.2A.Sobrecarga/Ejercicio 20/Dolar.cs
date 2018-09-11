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
	public class Dolar
	{
		#region Atributos

		private double _cantidad;
		private static float _cotizRespectoDolar;

		#endregion

		#region Constructor

		static Dolar()
		{
			Dolar._cotizRespectoDolar = 1;
		}

		public Dolar(double cantidad)
		{
			this._cantidad = cantidad; 
		}

		public Dolar(double cantidad , float cotizacion ) : this(cantidad)
		{
			Dolar._cotizRespectoDolar = cotizacion;
		}

		#endregion

		#region Operadores

		#region Conversion

		public static explicit operator Euro(Dolar dolar)
		{
			Euro euros = new Euro(dolar.GetCantidad() * Euro.GetCotizacion() );
			return euros;
		}

		public static explicit operator Peso(Dolar dolar)
		{
			Peso pesos = new Peso(dolar.GetCantidad() * Peso.GetCotizacion() );
			return pesos;
		}

		public static implicit operator Dolar(double dolares)
		{
			Dolar dolar = new Dolar(dolares );
			return dolar;
		}

		public static implicit operator double(Dolar dolares)
		{
			return dolares.GetCantidad();
		}

		#endregion

		#region SumaResta

		public static Dolar operator -(Dolar dolares, Euro euros)
		{
			Dolar resultado = new Dolar(dolares.GetCantidad() - ((Dolar)euros).GetCantidad() );
			return resultado;
		}

		public static Dolar operator -(Dolar dolares, Peso pesos)
		{
			return dolares - (Euro)pesos;
		}

		public static Dolar operator +(Dolar dolares, Euro euros)
		{
			Dolar resultado = new Dolar(dolares.GetCantidad() + ((Dolar)euros).GetCantidad() );
			return resultado;
		}

		public static Dolar operator +(Dolar dolares, Peso pesos)
		{
			return dolares + (Euro)pesos; 
		}

		#endregion

		#region Igualdad

		public static bool operator !=(Dolar dolares, Euro euros)
		{
			return !(dolares == euros);
		}

		public static bool operator !=(Dolar dolares, Peso pesos)
		{
			return !(dolares == pesos); ;
		}

		public static bool operator !=(Dolar dolares, Dolar dolares2)
		{
			return !(dolares == dolares2);
		}

		public static bool operator ==(Dolar dolares, Euro euros)
		{
			return dolares == (Dolar)euros;
		}

		public static bool operator ==(Dolar dolares, Peso pesos)
		{
			return dolares == (Dolar)pesos;
		}

		public static bool operator ==(Dolar dolares, Dolar dolares2)
		{
			return dolares.GetCantidad() == dolares2.GetCantidad();
		} 

		#endregion

		#endregion

		#region Getters

		public double GetCantidad()
		{
			return this._cantidad;
		}

		public static float GetCotizacion()
		{
			return Dolar._cotizRespectoDolar;
		} 

		#endregion


	}
}
