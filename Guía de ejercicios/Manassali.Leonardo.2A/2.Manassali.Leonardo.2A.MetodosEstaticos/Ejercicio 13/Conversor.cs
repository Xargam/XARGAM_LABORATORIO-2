using System;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Ejercicio_13
{
	public class Conversor
	{
		public static double BinarioDecimal(string binario)
		{
			double numDecimal = Double.NaN;
			if (Double.TryParse(binario, out numDecimal) && binario.Trim('1', '0', ',', '.', '-') == "" && Math.Abs(numDecimal) <= 1111111111111111111111111111111111111111111111111.0)
			{
				numDecimal = 0;
				//Eliminación de parte no entera, coma, signo y puntos en caso de existir.
				binario = binario.Replace("-", "");
				binario = binario.Replace(".", "");
				binario = (binario.IndexOf(',') > -1) ? binario.Remove(binario.IndexOf(',')) : binario;
				for (int i = 0; i < binario.Length; i++)
				{
					numDecimal += Double.Parse(binario[i].ToString()) * Math.Pow(2, binario.Length - 1 - i);
				}
			}
			return numDecimal;
		}

		public static string DecimalBinario(double numero)
		{
			string binario = "Valor invalido";

			if ((numero = Math.Truncate(Math.Abs(numero))) < 536870912)
			{
				binario = (numero == 0) ? "0" : "";
				while (numero > 0)
				{
					binario = Math.Truncate(numero % 2).ToString() + binario;
					numero = Math.Truncate(numero / 2);
				}
			}
			return binario;
		}
	}
}
