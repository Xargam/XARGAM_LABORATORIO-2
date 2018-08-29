using System;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Datos
{
	public static class Conversor
	{
		public static string DecimalBinario(double num)
		{
			string binario = "";
			string aux = "";
			long entero = (long)num;
			bool negativo = false;

			if( entero < 0)
			{
				negativo = true;
				entero *= -1;
			}
			num -= entero;
			while (entero > 1)
			{
				aux += entero % 2;
				binario = binario.Insert(0, aux);
				aux = "";
				entero /= 2;
			}
			binario = binario.Insert(0, "1");
			if (num > 0)
			{
				binario += ",";
				while (num > 0)
				{
					num *= 2;
					entero = (long)num;
					binario += entero;

				}
			}
			if( negativo == true )
			{
				binario = binario.Insert(0, "-");
			}
			return binario;
		}

		public static double BinarioDecimal(string num)
		{
			double numDecimal = 0;
			string aux;
			int point = num.IndexOf('.');
			int pointAux = 0;
			bool isDecimal = false;


			point = (point < 0) ? num.IndexOf(',') : point;
			point = (point < 0) ? num.Length : point;

			for (int i = 0; i < point; i++)
			{
				aux = (isDecimal == false) ? num.Substring(i, 1) : num.Substring(pointAux + i - 1, 1);
				if (aux == "1")
				{
					numDecimal += (isDecimal == true) ? Math.Pow(2, -i) : Math.Pow(2, point - i - 1);
				}
				aux = "";
				if (i == point - 1 && num.Length > point && isDecimal == false)
				{
					isDecimal = true;
					num = num.Remove(point, 1);
					pointAux = point;
					point = (num.Length - point) + 1;
					i = 0;
				}
			}

			if (num.StartsWith("-") == true)
			{
				numDecimal *= -1;
			}
			return numDecimal;
		}
	}
}
