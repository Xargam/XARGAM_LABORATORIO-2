using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
15. Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar(pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea tres métodos estáticos(de clase):
a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática.El método devolverá el resultado de la operación.
b.Validar(privado): Recibirá como parámetro el segundo número.Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.
c.Mostrar (público): Este método recibe como paráme
*/


namespace Ejercicio_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double operando1;
            double operando2;
            double resultado;
            char operacion;
            char quit;
            do
            {
                Console.WriteLine("Ingrese el primer operando:");
                operando1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo operando:");
                operando2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operacion a realizar (+ - * / ):");
                operacion = Console.ReadKey(true).KeyChar;

                if (operacion == '+' || operacion == '-' || operacion == '/' || operacion == '*')
                {
                    resultado = Calculadora.Calcular(operando1, operando2, operacion);
                    Console.WriteLine("El resultado de la operacion es: {0} .", resultado);
                }
                else
                {
                    Console.WriteLine("Operador erróneo.");
                }
                Console.WriteLine("Continuar: S/N");
                quit = Console.ReadKey(true).KeyChar;
                quit = Char.ToLower(quit);
            }
            while (quit == 's');
            
        }
    }
}
