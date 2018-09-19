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
		public static string DecimalBinario(double numero)
		{
			string binario = "";
			double parteEntera = Math.Truncate(Math.Abs(numero));
			double parteDecimal = Math.Abs(numero) - parteEntera;

			binario += (parteEntera == 0) ? '0' : '1';
			while (parteEntera > 1)
			{
				binario = binario.Insert(1, Convert.ToString(Math.Truncate(parteEntera % 2)));
				parteEntera = Math.Truncate(parteEntera / 2);
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

		public static double BinarioDecimal(string binario)
		{
			int indicePunto;
			int exponente;
			double numeroDecimal = 0;
			bool negativo = false;

			//Pregunto si el numero es negativo y lo registro.
			negativo = binario.StartsWith("-");
			//Elimino el signo para trabajar mejor la transformacion.
			binario = (negativo == true) ? binario.Remove(0, 1) : binario;
			//verifico si el numero tiene coma y busco su indice.
			indicePunto = binario.IndexOf(',');
			//En caso de no hallarse busco un punto .
			indicePunto = (indicePunto == -1) ? binario.IndexOf('.') : indicePunto;
			indicePunto = (indicePunto == -1) ? binario.Length : indicePunto;
			//Si se hallo un punto o coma lo elimino del string para trabajar mejor.
			binario = (indicePunto < binario.Length) ? binario.Remove(indicePunto, 1) : binario ;
			//Fijo el exponente.
			exponente = (indicePunto == -1) ? binario.Length - 1 : indicePunto - 1;

			for (int indice = 0; indice < binario.Length; exponente--, indice++)
			{
				if (binario.Substring(indice, 1) == "1")
				{
					numeroDecimal += Math.Pow(2, exponente);
				}
			}

			if( negativo == true)
			{
				numeroDecimal *= -1;
			}
			return numeroDecimal;
		}
	}
}
