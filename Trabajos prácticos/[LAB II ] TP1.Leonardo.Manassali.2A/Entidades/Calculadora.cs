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
            string verificacion = "true";
			if( operador != "*" && operador != "+" && operador != "-" && operador != "/" )
			{
				verificacion = "+";
			}
			return verificacion;
		}

		public static double Operar( Numero num1 , Numero num2 , string operador )
		{
			double resultado = Double.NaN;

			if( Calculadora.ValidarOperador(operador) == "true" )
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
			resultado = (Double.IsInfinity(resultado)) ? Double.NaN : resultado;
			return resultado;
		}

		#endregion
	}
}
