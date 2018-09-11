using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numeros;

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
			NumeroDecimal numeroDecimal = new NumeroDecimal(numero);
			return numeroDecimal;
		}

		#endregion

		#region SumasRestas

		public static double operator +(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			double resultado = Double.Parse( binario + numDecimal );
			return resultado;
		}
		public static double operator -(NumeroDecimal numDecimal, NumeroBinario binario)
		{
			double resultado = (double)numDecimal + Conversor.BinarioDecimal( (string)binario );
			return resultado;
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
