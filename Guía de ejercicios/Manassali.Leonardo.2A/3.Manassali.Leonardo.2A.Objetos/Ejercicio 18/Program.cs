using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

/*
18. Escribir una aplicación con estos dos espacios de nombres(namespaces) : Geometría y
PruebaGeometria.
Dentro del espacio de nombres Geometría se deberán escribir dos clases: Punto y Rectangulo.
a.La clase Punto ha de tener dos atributos privados con acceso de sólo lectura(sólo con
getters), que serán las coordenadas del punto.También un constructor que reciba los
parámetros x e y.
b.La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4
(que corresponden a los cuatro vértices del rectángulo).
c.La base de todos los rectángulos de esta clase será siempre horizontal.Por lo tanto, debe
tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
obtener la distancia entre puntos).
d.Realizar los métodos getters para los atributos privados área y perímetro.
e.Los atributos área(base * altura) y perímetro((base + altura)*2) se deberán calcular sólo
una vez, al llamar por primera vez a su correspondiente método getter.Luego se deberá
retornar siempre el mismo valor.
En el espacio de nombres PruebaGeometria es donde se escribirá
una clase con el método Main.
f.Probar las funcionalidades de las clases Punto y Rectangulo.
i.Generar un nuevo Rectangulo.
ii.Imprimir por pantalla los valores de área y perímetro.
g.Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como
parámetro.
*/

namespace PruebaGeometria
{
	public class program
	{
		public static void Main(string[] args)
		{
			Punto vertice1 = new Punto(-10, -3);
			Punto vertice3 = new Punto(3, -1);
			Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

			Console.Title = "Ejercicio 18";
			
			MostrarRectangulo(rectangulo,vertice1,vertice3);
			Console.ReadLine();
		}

		public static void MostrarRectangulo(Rectangulo rectangulo, Punto vertice1, Punto vertice3)
		{
			Punto vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
			Punto vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

			Console.WriteLine("Vertice 1: X: {0} Y: {1}", vertice1.GetX(), vertice1.GetY());
			Console.WriteLine("Vertice 2: X: {0} Y: {1}", vertice2.GetX(), vertice2.GetY());
			Console.WriteLine("Vertice 3: X: {0} Y: {1}", vertice3.GetX(), vertice3.GetY());
			Console.WriteLine("Vertice 4: X: {0} Y: {1}", vertice4.GetX(), vertice4.GetY());
			Console.WriteLine("Perimetro: {0}", rectangulo.Perimetro());
			Console.WriteLine("Area: {0}", rectangulo.Area());
			//Console.WriteLine(rectangulo.Area());
			//Console.WriteLine(rectangulo.Perimetro());
		}
	}
	
}
