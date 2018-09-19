using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numero;

namespace Numeros
{
	public class NumeroDecimal
	{
		#region Atributos

		private double _numero;

		#endregion

		#region Constructor

		private NumeroDecimal(double numero)
		{
			this._numero = numero;
		}

		#endregion

		#region Sobrecargas

		#region Conversiones

		public static explicit operator double(NumeroDecimal numero )
		{
			return numero.GetNumero();
		}

		public static implicit operator NumeroDecimal(double numero )
		{
			return new NumeroDecimal(numero);
		}

		#endregion

		#region SumasRestas

		public static double operator +(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			return Conversor.BinarioDecimal(binario + numDecimal);
		}
		public static double operator -(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			return (double)numDecimal + Conversor.BinarioDecimal((string)binario)*-1;
		}
		public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			return binario == numDecimal;
		}
		public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			return !(binario == numDecimal);
		} 

		#endregion

		#endregion

		#region Getters

		private double GetNumero()
		{
			return this._numero;
		}

		#endregion


	}
}
