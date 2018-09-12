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
		public static string DecimalBinario(double numero)
		{
			string binario = "";
			long parteEntera = (long)Math.Abs(numero);
			double parteDecimal = Math.Abs(numero) - parteEntera;

			binario += (parteEntera == 0) ? '0' : '1';
			while (parteEntera > 1)
			{
				binario = binario.Insert(1, Convert.ToString(parteEntera % 2));
				parteEntera = parteEntera / 2;
			}

			binario = (parteDecimal == 0) ? binario : binario + ',';
			while (parteDecimal > 0)
			{
				parteDecimal *= 2;
				binario += (parteDecimal >= 1) ? '1' : '0';
				parteDecimal = (parteDecimal >= 1) ? parteDecimal - 1 : parteDecimal;
			}
			if (numero < 0)
			{
				binario = binario.Insert(0, "-");
			}

			return binario;
		}

		public static string DecimalBinario(string numero)
		{

			DecimalBinario(numero.ToString());
		}

		public static double BinarioDecimal(string binario)
		{
			int indicePunto;
			int exponente;
			double numeroDecimal = 0;
			bool negativo = false;

			negativo = binario.StartsWith("-");
			binario = (negativo == true) ? binario.Remove(0, 1) : binario;
			indicePunto = binario.IndexOf(',');
			indicePunto = (indicePunto == -1) ? binario.IndexOf('.') : indicePunto;
			indicePunto = (indicePunto == -1) ? binario.Length : indicePunto;
			binario = (indicePunto < binario.Length) ? binario.Remove(indicePunto, 1) : binario;
			exponente = (indicePunto == -1) ? binario.Length - 1 : indicePunto - 1;

			for (int indice = 0; indice < binario.Length; exponente--, indice++)
			{
				if (binario.Substring(indice, 1) == "1")
				{
					numeroDecimal += Math.Pow(2, exponente);
				}
			}
			if (negativo == true)
			{
				numeroDecimal *= -1;
			}
			return numeroDecimal;
		}
	}
}
