using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace Calculo
{
    public class Area
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }

        public static double CalcularTriangulo(double baseTriangulo , double altura)
        {
            double area = baseTriangulo * altura / 2;
            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = 3.14 * radio * radio;
            return area;
        }
    }
}
