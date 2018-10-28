using System;

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

namespace Geometria
{
	public class Rectangulo
	{
		#region Atributos
		private float _area;
		private float _perimetro;
		private Punto _vertice1;
		private Punto _vertice2;
		private Punto _vertice3;
		private Punto _vertice4;
		#endregion

		#region Constructor

		public Rectangulo(Punto vertice1, Punto vertice3)
		{
			this._area = float.NaN;
			this._perimetro = float.NaN;

			this._vertice1 = vertice1;
			this._vertice3 = vertice3;
			this._vertice2 = new Punto(this._vertice3.GetX(), this._vertice1.GetY());
			this._vertice4 = new Punto(this._vertice1.GetX(), this._vertice3.GetY());
		}

		#endregion

		#region Metodos

		public float Area()
		{
			if ( float.IsNaN(this._area) )
			{
				this._area = Math.Abs(this._vertice2.GetX() - this._vertice1.GetX());
				this._area *= Math.Abs(this._vertice4.GetY() - this._vertice1.GetY());
			}
			return this._area;
		}

		public float Perimetro()
		{
			if ( float.IsNaN(this._perimetro) )
			{
				this._perimetro = Math.Abs(this._vertice2.GetX() - this._vertice1.GetX());
				this._perimetro += Math.Abs(this._vertice4.GetY() - this._vertice1.GetY());
				this._perimetro *= 2;
			}
			return this._perimetro;
		}

		#endregion
	}
}
