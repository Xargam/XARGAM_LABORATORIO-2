using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Calculadora
	{
		#region Metodos

		private static string ValidarOperador( string operador )
		{
            operador = "true";
			if( operador != "*" && operador != "+" && operador != "-" && operador != "/" )
			{
				operador = "+";
			}
			return operador;
		}

		public static double Operar( Numero num1 , Numero num2 , string operador )
		{
			double resultado = double.NaN;

			if( Calculadora.ValidarOperador(operador) != "+" )
			{
				switch( operador )
				{
					case "+":
						resultado = num1 + num2;
						break;
					case "-":
						resultado = num1 - num2;
						break;
					case "*":
						resultado = num1 * num2;
						break;
					case "/":
						resultado = num1 / num2;
						break;
				}
			}
			return resultado;
		}

		#endregion
	}
}
