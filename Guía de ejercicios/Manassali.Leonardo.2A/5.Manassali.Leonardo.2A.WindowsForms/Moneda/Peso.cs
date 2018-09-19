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

namespace Moneda
{
	public class Peso
	{
		#region Atributos

		private double _cantidad;
		private static float _cotizRespectoDolar;

		#endregion

		#region Constructor

		static Peso()
		{
			Peso._cotizRespectoDolar = 40;
		}

		public Peso(double cantidad)
		{
			this._cantidad = cantidad;
		}

		public Peso(double cantidad, float cotizacion) : this(cantidad)
		{
			Peso._cotizRespectoDolar = cotizacion;
		}

		#endregion

		#region Operadores

		public static explicit operator Dolar(Peso pesos)
		{
			Dolar dolares = new Dolar(pesos.GetCantidad() / Peso.GetCotizacion() );
			return dolares;
		}

		public static explicit operator Euro(Peso pesos)
		{
			return (Euro)((Dolar)pesos);
		}

		public static implicit operator Peso(double peso)
		{
			Peso pesos = new Peso(peso);
			return pesos;
		}

		/*public static implicit operator double(Peso pesos)
		{
			return pesos.GetCantidad();
		}*/

		public static Peso operator -(Peso pesos, Euro euros)
		{
			return (Peso)((Dolar)pesos - euros);
		}

		public static Peso operator -(Peso pesos, Dolar dolares)
		{
			return pesos - (Euro)dolares;
		}

		public static Peso operator +(Peso pesos, Euro euros)
		{
			return (Peso)((Dolar)pesos + euros) ;
		}

		public static Peso operator +(Peso pesos, Dolar dolares)
		{
			return pesos + (Euro)dolares;
		}

		public static bool operator !=(Peso pesos, Euro euros)
		{
			return !(pesos == euros);
		}
		
		public static bool operator !=(Peso pesos1, Peso pesos2)
		{
			return !(pesos1 == pesos2);
		}

		public static bool operator !=(Peso pesos, Dolar dolares)
		{
			return !(pesos == dolares);
		}

		public static bool operator ==(Peso pesos, Euro euros)
		{
			return  pesos == (Dolar)euros;
		}

		public static bool operator ==(Peso pesos1, Peso pesos2)
		{
			return pesos1 == (Dolar)pesos2;
		}

		public static bool operator ==(Peso pesos, Dolar dolares)
		{
			return (Dolar)pesos == dolares;
		}


		#endregion

		#region Getters

		public double GetCantidad()
		{
			return this._cantidad;
		}

		public static float GetCotizacion()
		{
			return Peso._cotizRespectoDolar;
		}

		#endregion

	}
}
