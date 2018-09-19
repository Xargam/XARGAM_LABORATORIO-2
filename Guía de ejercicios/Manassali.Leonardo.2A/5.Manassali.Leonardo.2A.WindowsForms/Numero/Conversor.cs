using System;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Numero
{
	public class Conversor
	{	
		public static double BinarioDecimal(string binario)
		{
			double numDecimal;
			int exponente = 0;
			bool negativo = binario.Contains("-");
			if (Double.TryParse(binario, out numDecimal) && binario.Trim('1', '0', ',', '.', '-') == "")
			{
				numDecimal = 0;
				binario = binario.Replace(",", "");
				binario = binario.Replace("-", "");
				exponente = (binario.IndexOf('.') > -1) ? binario.IndexOf('.') - 1 : binario.Length - 1;
				binario = binario.Replace(".", "");
				for (int i = 0; i < binario.Length; i++)
				{
					numDecimal += Double.Parse(binario[i].ToString()) * Math.Pow(2, exponente - i);
				}
				numDecimal = (negativo) ? numDecimal * -1 : numDecimal;
			}
			else {
				numDecimal = Double.NaN;
			}
			return numDecimal;
		}

		public static string DecimalBinario(double numero)
		{
			return Conversor.DecimalBinario(numero.ToString());
		}
		public static string DecimalBinario(string numero)
		{
			double parteEntera;
			double parteDecimal;
			string binario = "NeuN";
			bool negativo;

			if( double.TryParse(numero,out parteDecimal) )
			{
				negativo = parteDecimal < 0;
				parteDecimal = Math.Abs(parteDecimal);
				parteEntera = Math.Truncate(parteDecimal);
				parteDecimal = parteDecimal - parteEntera;

				binario = (parteEntera == 0) ? "0" : "";
				while (parteEntera > 0)
				{
					binario = (Math.Truncate(parteEntera % 2)).ToString() + binario;
					parteEntera = Math.Truncate(parteEntera / 2);
				}
				binario += (parteDecimal == 0) ? "" : ".";
				while (parteDecimal > 0)
				{
					binario += Math.Truncate(parteDecimal *= 2).ToString();
					parteDecimal = (parteDecimal >= 1) ? parteDecimal - 1 : parteDecimal;
				}
				binario = (negativo) ? binario.Insert(0, "-") : binario;
			}
			return binario;
		}
	}
}
