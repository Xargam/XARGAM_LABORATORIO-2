using System;

namespace Entidades
{
	public class Numero
	{
		#region AtributosPropidades

		private double _numero;

		/// <summary>
		/// Setea un string en el atributo numero previamente validando que sea un número valido. En caso de error setea 0.
		/// </summary>
		private string SetNumero
		{
			set
			{
				double numero = this.ValidarNumero(value);
				this._numero = numero;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Inicializa el atributo numero con el valor 0.
		/// </summary>
		public Numero()
		{
			this._numero = 0;
		}

		/// <summary>
		/// Inicializa el atributo numero con un valor instanciado como double.
		/// </summary>
		/// <param name="numero">Numero en formato double</param>
		public Numero(double numero) : this(numero.ToString())
		{
		}

		/// <summary>
		/// Inicializa el atributo numero con un valor instanciado como string.
		/// </summary>
		/// <param name="strNumero">Numero en formato string.</param>
		public Numero(string strNumero)
		{
			this.SetNumero = strNumero;
		}

		#endregion

		#region Sobrecargas

		/// <summary>
		/// Realiza una suma entre dos instancias de Numero tomando su valor instanciado y devuelve un double con el resultado.
		/// </summary>
		/// <param name="n1">Operando 1.</param>
		/// <param name="n2">Operando 2.</param>
		/// <returns></returns>

		public static double operator +(Numero n1, Numero n2)
		{
			return n1._numero + n2._numero;
		}

		/// <summary>
		/// Realiza una resta entre dos instancias de Numero tomando su valor instanciado y devuelve un double con el resultado.
		/// </summary>
		/// <param name="n1">Operando 1.</param>
		/// <param name="n2">Operando 2.</param>
		/// <returns></returns>
		public static double operator -(Numero n1, Numero n2)
		{
			return n1._numero - n2._numero;
		}

		/// <summary>
		/// Realiza una multiplicación entre dos instancias de Numero tomando su valor instanciado y devuelve un double con el resultado.
		/// </summary>
		/// <param name="n1">Operando 1.</param>
		/// <param name="n2">Operando 2.</param>
		/// <returns></returns>
		public static double operator *(Numero n1, Numero n2)
		{
			return n1._numero * n2._numero;
		}

		/// <summary>
		/// Realiza una división entre dos instancias de Numero tomando su valor instanciado y devuelve un double con el resultado.
		/// </summary>
		/// <param name="n1">Operando 1.</param>
		/// <param name="n2">Operando 2.</param>
		/// <returns></returns>
		public static double operator /(Numero n1, Numero n2)
		{
			return (n2._numero != 0) ? n1._numero / n2._numero : 0;
		}

		#endregion

		#region Metodos

		#region Conversion

		/// <summary>
		/// Convierte un string con un número binario a su equivalente decimal como string. En caso de error devuelve "Valor invalido".
		/// </summary>
		/// <param name="binario">Numero binario a convertir.</param>
		/// <returns></returns>
		public string BinarioDecimal(string binario)
		{
			string numDecimal = "Valor invalido";
			double numero;
			//Valida que sea un número, que sea y binario y que no sea demasiado extenso...
			if ( Double.TryParse(binario, out numero) && binario.Trim('1','0',',','.','-') == "" && Math.Abs(numero) <= 1111111111111111111111111111111111111111111111111.0 )
			{
				numero = 0;
				//Eliminación de parte no entera, coma, signo y puntos en caso de existir.
				binario = binario.Replace("-", "");
				binario = binario.Replace(".", "");
				binario = (binario.IndexOf(',') > -1)? binario.Remove(binario.IndexOf(',')) : binario ;
				for (int i = 0 ; i < binario.Length; i++)
				{
					numero += Double.Parse(binario[i].ToString())*Math.Pow(2, binario.Length -1-i);
				}
				numDecimal = numero.ToString();
			}
			return numDecimal;
		}

		/// <summary>
		/// Convierte un número decimal en formato double a su binario equivalente en formato string. En caso de error devuelve "Valor invalido".
		/// </summary>
		/// <param name="numero">Numero decimal a convertir.</param>
		/// <returns></returns>
		public string DecimalBinario(double numero)
		{
			return this.DecimalBinario(numero.ToString());
		}

		/// <summary>
		/// Convierte un número decimal en formato string a su binario equivalente en formato string. En caso de error devuelve "Valor invalido".
		/// </summary>
		/// <param name="numero">Numero decimal a convertir.</param>
		/// <returns></returns>
		public string DecimalBinario(string numero)
		{
			string binario = "Valor invalido";
			if( Double.TryParse(numero,out double numDecimal))
			{
				if( (numDecimal = Math.Truncate(Math.Abs(numDecimal))) < 536870912 )
				{
					binario = (numDecimal == 0) ? "0" : "";
					while (numDecimal > 0)
					{
						binario = (Math.Truncate(numDecimal % 2)).ToString() + binario;
						numDecimal = Math.Truncate(numDecimal / 2);
					}
				}
			}
			return binario;
		}

		#endregion

		#region Validacion

		/// <summary>
		/// Verifica que un numero en formato string pueda ser convertido a un double.
		/// </summary>
		/// <param name="numero"></param>
		/// <returns></returns>
		private double ValidarNumero(string numero)
		{
			Double.TryParse(numero, out double verificacion);
			return verificacion;
		}

		#endregion

		#endregion
	}
}
