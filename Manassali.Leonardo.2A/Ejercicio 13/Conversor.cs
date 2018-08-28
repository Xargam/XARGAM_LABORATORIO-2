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

namespace Datos
{
	public static class Conversor
	{
		public static string DecimalBinario(double num)
		{
			string binario = "";
			string aux = "";
			long entero = (long)num;
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
					num -= entero;
				}
			}
			return binario;
		}

		public static double BinarioDecimal(string num)
		{
			double numDecimal = 0;
			string aux;
			int point = num.IndexOf('.');
			bool isDecimal = false; 

			point = (point < 0) ? num.IndexOf(',') : point;
			point = (point < 0) ? num.Length : --point;

			for (int i = 0; i < point+1; i++)
			{
				aux = num.Substring(i, 1);
				if (aux == "1")
				{
					numDecimal += Math.Pow(2, (point - i) );
				}
				aux = "";
				if (i == point && num.Length > point)
				{
					num = num.Remove(point+1, 1);
					point += (num.Length - point);
				}
			}
			return numDecimal;
		}
	}
}
