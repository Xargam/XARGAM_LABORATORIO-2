using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numero;

namespace Numero
{
	public class NumeroBinario
	{
		#region Atributos

		private string _numero;

		#endregion

		#region Constructor

		private NumeroBinario(string numero)
		{
			this._numero = numero;
		}

		#endregion

		#region Sobrecargas

		#region Conversiones

		public static explicit operator string(NumeroBinario binario)
		{
			return binario.GetNumero();
		}

		public static implicit operator NumeroBinario(string binario)
		{
			NumeroBinario numeroBinario = new NumeroBinario(binario);
			return numeroBinario;
		}

		#endregion

		#region SumasRestas

		public static string operator +(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			string resultado = Convert.ToString(  (double)numDecimal + Conversor.BinarioDecimal( (string)binario ));
			return resultado;
		}
		public static string operator -(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			string resultado = Convert.ToString((double)numDecimal - Conversor.BinarioDecimal((string)binario));
			return resultado;
		}
		public static bool operator ==(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			return ((double)numDecimal == Conversor.BinarioDecimal((string)binario));
		}
		public static bool operator !=(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			return !(numDecimal == binario);
		}

		#endregion

		#endregion

		#region Getters

		private string GetNumero()
		{
			return this._numero;
		}

		#endregion
	}
}
