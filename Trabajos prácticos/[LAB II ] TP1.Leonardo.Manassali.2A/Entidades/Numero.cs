using System;

namespace Entidades
{
	public class Numero
	{
		#region Atributos y propidades

		private double _numero;

		/// <summary>
		/// Setea un string en el atributo numero previamente validando que sea un número valido. En caso de error
		/// establece NaN.
		/// </summary>
		private string SetNumero
		{
			set
			{
				double numero = this.ValidarNumero(value);
				//Estas lineas verifican que si el numero a setear es -0,-00..,0000..,etc no sea invalidado.
				value = (value != "-" && value != "" && value.IndexOf('-') < 1)? value.Trim('0') : "ERROR";
				value = (value == "-" || value == "") ? "OK" : "ERROR";
				numero = (numero == 0 && value == "ERROR") ? Double.NaN : numero;
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
			return (n2._numero != 0) ? n1._numero / n2._numero : Double.NaN;
		}

		#endregion

		#region Metodos

		#region Conversion numerica

		/// <summary>
		/// Convierte un string con un número binario a su equivalente decimal como string. En caso de error o precision requerida excesiva devuelve "Valor invalido".
		/// </summary>
		/// <param name="binario">Numero binario a convertir.</param>
		/// <returns></returns>
		public string BinarioDecimal(string binario)
		{
			string numero;
			int indiceComa;
			int exponente;
			int indiceSigno;

			indiceSigno = binario.IndexOf('-');
			binario = (indiceSigno == 0) ? binario.Remove(0, 1) : binario;
			indiceComa = binario.IndexOf(',');
			//Verifico que la coma tenga índice correcto respecto al punto y la elimino.
			binario = (indiceComa > 0 && indiceComa > indiceSigno ) ? binario.Remove(indiceComa, 1) : binario;
			//El exponente para el bit mas significativo será asignado según si el num tiene coma o no.
			exponente = (indiceComa > -1) ? indiceComa - 1 : binario.Length - 1;
			//Verifico que el número no este vacío y que contenga a lo sumo 3 decimales.
			numero = (binario.Length == 0 )? "Valor invalido" : "0";
			for (int i = 0; i < binario.Length; i++)
			{
				if (binario[i] != '1' && binario[i] != '0')
				{
					numero = "Valor invalido";
					break;
				}
			}
			if (numero != "Valor invalido")
			{
				for (int i = 0; i < binario.Length ; i++)
				{
					//Reviso bit a bit el binario, lo sumo, elevo a la potencia de 2 correcta y guardo.
					numero = (binario.Substring(i, 1) == "1") ? (Double.Parse(numero) + Math.Pow(2, exponente - i)).ToString() : numero;
					//Si el numero es demasiado grande o pequeño lo descarto.
					if (Math.Abs(Double.Parse(numero)) > 2147483647)
					{
						numero = "Valor invalido";
						break;
					}
					else if (i == binario.Length - 1 && indiceSigno > -1)
					{
						numero = (Double.Parse(numero) * -1).ToString();
					}
				}
			}
			return numero;
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
			double parteEntera;
			if (Double.TryParse(numero, out double parteNoEntera) && Math.Abs(parteNoEntera) <= 2147483647)
			{
				parteNoEntera = Math.Abs(parteNoEntera);
				parteEntera = Math.Truncate(parteNoEntera);
				parteNoEntera = parteNoEntera - parteEntera;
				binario = (parteEntera == 0) ? "0" : "1";
				while (parteEntera > 1)
				{
					binario = binario.Insert(1, (parteEntera % 2).ToString());
					parteEntera = Math.Truncate(parteEntera / 2);
				}
				binario += (parteNoEntera > 0) ? "," : "";
				while(parteNoEntera > 0)
				{
					binario += (parteNoEntera * 2 >= 1) ? "1" : "0";
					parteNoEntera *= 2;
					parteNoEntera = (parteNoEntera >= 1) ? parteNoEntera - 1 : parteNoEntera;
				}
				//Agrego el signo del numero tomando en cuenta que no sea -0.
				binario =(numero.Contains("-") && parteEntera+parteNoEntera != 0) ? binario.Insert(0, "-"): binario;
			}
			return binario;
		}

		#endregion

		/// <summary>
		/// Verifica que un numero en formato string pueda ser convertido a un double.
		/// </summary>
		/// <param name="numero"></param>
		/// <returns></returns>
		#region Validacion

		private double ValidarNumero(string numero)
		{
			Double.TryParse(numero, out double verificacion);
			return verificacion;
		}

		#endregion

		#endregion
	}
}
