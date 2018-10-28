using System;

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
	public class Program
	{
		public static void Main(string[] args)
		{
			double operando1;
			double operando2;
			string resultado;
			char operacion;
			char quit = 's';

			Console.Title = "Ejercicio 15";

			do
			{
				Console.WriteLine("Ingrese el primer operando:");
				operando1 = Double.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese el segundo operando:");

				operando2 = Double.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese la operacion que desea realizar (+ , - , * ó / ):");
				operacion = Console.ReadKey().KeyChar;
				resultado = Calculadora.Calcular(operando1, operacion, operando2);
				if( resultado == "ERROR")
				{
					Console.WriteLine("\n\nError.");
				}
				else
				{
					Console.WriteLine("\n\nResultado: {0} {1} {2} = {3} .", operando1, operacion, operando2, resultado);
				}
				Console.WriteLine("Continuar? s/n :");
				quit = Console.ReadKey().KeyChar;
				Console.Clear();
			}
			while (quit == 's');
		}
	}
}
