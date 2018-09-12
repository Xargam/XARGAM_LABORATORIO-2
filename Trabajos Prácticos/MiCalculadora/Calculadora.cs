using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Laboratorio_II
{
	public class Calculadora
	{
		#region Metodos

		private static string ValidarOperador( string operador )
		{
			if( operador != "*" && operador != "+" && operador != "-" && operador != "/" )
			{
				operador = "+";
			}
			return operador;
		}

		public static double Operar( Numero num1 , Numero num2 , string operador )
		{
			double resultado;

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
			return num1 + num2;
		}

		#endregion
	}
}
