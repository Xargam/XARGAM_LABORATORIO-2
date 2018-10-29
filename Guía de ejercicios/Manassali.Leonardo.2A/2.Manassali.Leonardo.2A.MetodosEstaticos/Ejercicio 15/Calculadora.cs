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
*/

namespace Ejercicio_15
{
	public class Calculadora
	{
		#region Metodos
		private static bool Validar(double operando2)
		{
			return operando2 != 0;
		}
		public static string Calcular(double operando1, char operacion, double operando2)
		{
			string resultado = "ERROR";

			switch ( operacion )
			{
				case '+':
					resultado = (operando1 + operando2).ToString();
					break;
				case '-':
					resultado = (operando1 - operando2).ToString();
					break;
				case '*':
					resultado = (operando1 * operando2).ToString();
					break;
				case '/':

					if ( Validar(operando2) )
					{
						resultado = (operando1 / operando2).ToString();
					}
					break;
			}
			return resultado;
		} 
		#endregion
	}
}
