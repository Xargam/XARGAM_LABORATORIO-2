using System;

namespace TP_1___Laboratorio_II
{
	public class Numero
	{
		#region Atributos

		private double _numero;

		#endregion

		#region Constructor

		public Numero() : this(0)
		{
		}

		public Numero(double numero)
		{
			this._numero = numero;
		}

		/*public Numero(string numero) 
		{
			if( ValidarNumero(numero) != 0)
			{
				this(Double.Parse(numero));
			}
		}*/

		#endregion

		#region Sobrecargas

		public static double operator +(Numero n1 , Numero n2)
		{
			return n1._numero + n2._numero ;
		}
		public static double operator -(Numero n1, Numero n2)
		{
			return n1._numero - n2._numero;
		}
		public static double operator *(Numero n1, Numero n2)
		{
			return n1._numero * n2._numero;
		}
		public static double operator /(Numero n1, Numero n2)
		{
			return n1._numero / n2._numero;
		}

		#endregion

		#region Metodos

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

		public string DecimalBinario(double numero)
		{
			string binario = "";
			long parteEntera = (long)Math.Abs(numero);
			double parteDecimal = (double)((decimal)Math.Abs(numero) - (decimal)parteEntera);

			binario += (parteEntera == 0) ? "0" : "1";
			binario += (parteDecimal > 0) ? "," : "";
			while (parteEntera > 1)
			{
				binario = binario.Insert(1, (parteEntera % 2).ToString());
				parteEntera /= 2;
			}
			for (int index = 0; index < 3 && parteDecimal > 0; index++)
			{
				parteDecimal *= 2;
				binario += (parteDecimal >= 1) ? "1" : "0";
				parteDecimal = (parteDecimal >= 1) ? parteDecimal - 1 : parteDecimal;
			}

			binario = (numero >= 0) ? binario : binario.Insert(0, "-");

			return binario;
		}

		public string DecimalBinario(string numero)
		{
			string binario = "Valor inválido";
			if(this.ValidarNumero(numero) != 0)
			{
				binario = this.DecimalBinario(Double.Parse(numero));
			}
			return binario;
		}

		private double ValidarNumero(string number)
		{
			double validatedNumber = 0;
			Double.TryParse(number, out validatedNumber);
			return validatedNumber;
		}

		#endregion
	}
}
