using System;

/*
14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace Ejercicio_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;

            Console.Title = "Ejercicio 14";

            do
            {
                Console.WriteLine("Ingrese el valor de un lado de su cuadrado (cm):");
                ladoCuadrado = double.Parse(Console.ReadLine());
                if (ladoCuadrado < 1)
                {
                    Console.WriteLine("El valor ingresado debe ser mayor a 0. Reingrese.\n");
                }
            }
            while (ladoCuadrado < 1);

            ladoCuadrado = Calculo.Area.CalcularCuadrado(ladoCuadrado);
            Console.WriteLine("Su cuadrado tiene un area de {0} cm.\n", ladoCuadrado);

            do
            {
                Console.WriteLine("Ingrese el radio de su circulo (cm):");
                radioCirculo = double.Parse(Console.ReadLine());
                if (radioCirculo < 1)
                {
                    Console.WriteLine("El valor ingresado debe ser mayor a 0. Reingrese.\n");
                }

            }
            while (radioCirculo < 1);

            radioCirculo = Calculo.Area.CalcularCirculo(radioCirculo);
            Console.WriteLine("Su circulo tiene un area de {0} cm.\n", radioCirculo);

            do
            {
                Console.WriteLine("Ingrese la base de su triangulo (cm):");
                baseTriangulo = double.Parse(Console.ReadLine());
                if (baseTriangulo < 1  )
                {
                    Console.WriteLine("El valor de la base del triángulo deb ser mayor a 0.\n");
                }
            }
            while (baseTriangulo < 1);

            do
            {
                Console.WriteLine("Ingrese la altura de su triangulo (cm):");
                alturaTriangulo = double.Parse(Console.ReadLine());
                if (alturaTriangulo < 1)
                {
                    Console.WriteLine("El valor de la altura del triángulo deb ser mayor a 0.\n");
                }

            }
            while ( alturaTriangulo < 1);

            Console.WriteLine("Su triángulo tiene un area de {0} cm.\n", Calculo.Area.CalcularTriangulo(baseTriangulo, alturaTriangulo));

            Console.ReadLine();
        }

    }
}
