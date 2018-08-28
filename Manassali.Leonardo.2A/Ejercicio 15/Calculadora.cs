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
    public class Calculadora
    {
        public static double Calcular(double operando1 , double operando2 , char operacion)
        {
            double resultado = 0;
            switch(operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if( Calculadora.Validar(operando2) )
                    {
                        resultado = operando1 / operando2;
                    }
                    break;
            }
            return resultado;
        }
        
        public static void Mostrar(double resultado)
        {
            Console.WriteLine("Resultado: {0} .",resultado);
        }

        private static bool Validar(double num)
        {
            bool verificacion = false;
            if( num != 0)
            {
                verificacion = true;
            }
            return verificacion;
        }
    }
}
