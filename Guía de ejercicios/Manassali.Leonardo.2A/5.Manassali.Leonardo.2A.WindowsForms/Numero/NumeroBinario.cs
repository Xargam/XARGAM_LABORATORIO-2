using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			return binario._numero;
		}

		public static implicit operator NumeroBinario(string binario)
		{
			return new NumeroBinario(binario);
		}

		#endregion

		#region SumasRestas

		public static string operator +(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			return Conversor.DecimalBinario(Conversor.BinarioDecimal((string)binario) + (double)numDecimal);
		}
		public static string operator -(NumeroBinario binario, NumeroDecimal numDecimal)
		{
			return binario + ((double)numDecimal * -1);
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
	}
}
