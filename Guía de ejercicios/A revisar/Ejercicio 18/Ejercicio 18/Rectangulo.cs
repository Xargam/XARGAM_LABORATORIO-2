using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

/*
18.
c. La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
obtener la distancia entre puntos).
d. Realizar los métodos getters para los atributos privados lado, área y perímetro.
e. Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo
una vez, al llamar por primera vez a su correspondiente método getter. Luego se deberá
retornar siempre el mismo valor.
En el espacio de nombres PruebaGeometria es donde se escribirá
una clase con el método Main.
f. Probar las funcionalidades de las clases Punto y Rectangulo.
i. Generar un nuevo Rectangulo.
ii. Imprimir por pantalla los valores de área y perímetro.
g. Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como
parámetro.
*/

namespace Geometria
{


  class Rectangulo
  {
    #region Atributos

    private float _lado;
    private float _area;
    private float _perimetro;

    private Punto _vertice1;
    private Punto _vertice2;
    private Punto _vertice3;
    private Punto _vertice4;

    #endregion


    #region Constructor



    #endregion

    #region Metodos

    private float Perimetro()
    {

    }

    private float Area()
    {
      float area = getArea();
      area = 
    }

    public float GetLado()
    {
      return this._lado;
    }
    
    public float getArea()
    {
      return this._area;
    }

    public float getPerimetro()
    {
      return this._perimetro;
    }

    private float Rectangulo( Punto vertice1 , Punto vertice3 )
    {
      
    }

  

    #endregion



  }
}

