using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Ejercicio_13
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string binario;
			double numDecimal;
			char quit = 'S';

			Console.Title = "Ejercicio 13";

			do
			{
				Console.WriteLine("Ingrese un numero binario:");
				binario = Console.ReadLine();
				Console.WriteLine("El numero binario {0} es en decimal: {1} .", binario, Conversor.BinarioDecimal(binario));
				Console.ReadLine();
				Console.Clear();
				Console.WriteLine("Ingrese un numero decimal:");
				numDecimal = double.Parse(Console.ReadLine());
				Console.WriteLine("El numero decimal {0} es en binario: {1} .", numDecimal, Conversor.DecimalBinario(numDecimal));
				
				Console.WriteLine("Continuar? s/n :");
				quit = Char.ToLower(Console.ReadKey().KeyChar);
				Console.ReadLine();
				Console.Clear();
			}
			while (quit == 's');
		}
	}
}
