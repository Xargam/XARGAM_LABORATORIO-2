using Billetes;
using System;

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

namespace Ejercicio_20
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 20";

			Dolar ahorros = 10;
			Euro euros = 100;
			Peso ars = 100;
			Console.WriteLine(  (ahorros + ars).GetCantidad());
			Console.ReadLine();


		}
	}
}
