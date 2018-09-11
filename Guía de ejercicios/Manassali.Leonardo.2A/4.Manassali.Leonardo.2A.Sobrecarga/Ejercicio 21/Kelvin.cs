using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
21. Crear tres clases: Fahrenheit, Celsius y Kelvin.Realizar un ejercicio similar al anterior, teniendo en
cuenta que:
F = C* (9/5) + 32
C = (F-32) * 5/9
F = K* 9/5 – 459.67
K = (F + 459.67) * 5/9
*/

namespace Grados
{
	public class Kelvin
	{
		#region Atributos

		private double _grados;

		#endregion

		#region Constructor

		public Kelvin(double grados)
		{
			this._grados = grados;
		}

		#endregion

		#region Operadores

		#region Conversion

		public static explicit operator Celsius(Kelvin gradosK)
		{
			Fahrenheit gradosF = new Fahrenheit((gradosK.GetGrados() * (9.0 / 5.0)) - 459.67);
			return (Celsius)gradosF;
		}

		public static explicit operator Fahrenheit(Kelvin gradosK)
		{
			return (Fahrenheit)(Celsius)gradosK;
		}

		public static implicit operator Kelvin(double grados)
		{
			Kelvin gradosK = new Kelvin(grados);
			return gradosK;
		}

		public static implicit operator double(Kelvin gradosK)
		{
			return gradosK.GetGrados();
		}

		#endregion

		#region SumaResta

		public static Kelvin operator -(Kelvin gradosK, Fahrenheit gradosF)
		{
			return gradosK - (Celsius)gradosF ;
		}

		public static Kelvin operator -(Kelvin gradosK, Celsius gradosC)
		{
			Kelvin resultado = new Kelvin(gradosK.GetGrados() - ((Kelvin)gradosC).GetGrados());
			return resultado;
		}

		public static Kelvin operator +(Kelvin gradosK, Fahrenheit gradosF)
		{
			return gradosK + (Celsius)gradosF;
		}

		public static Kelvin operator +(Kelvin gradosK, Celsius gradosC)
		{
			Kelvin resultado = new Kelvin(gradosK.GetGrados() + ((Kelvin)gradosC).GetGrados());
			return resultado;
		}

		#endregion

		#region Igualdad

		public static bool operator !=(Kelvin gradosK, Celsius gradosC)
		{
			return !(gradosK == gradosC);
		}

		public static bool operator !=(Kelvin gradosK, Fahrenheit gradosF)
		{
			return !(gradosK == gradosF); ;
		}

		public static bool operator !=(Kelvin gradosK1, Kelvin gradosK2)
		{
			return !(gradosK1 == gradosK2);
		}

		public static bool operator ==(Kelvin gradosK, Fahrenheit gradosF)
		{
			return gradosK == (Kelvin)gradosF;
		}

		public static bool operator ==(Kelvin gradosK, Celsius gradosC)
		{
			return gradosK == (Kelvin)gradosC;
		}

		public static bool operator ==(Kelvin gradosK1, Kelvin gradosK2)
		{
			return gradosK1.GetGrados() == gradosK2.GetGrados();
		}

		#endregion

		#endregion

		#region Getters

		public double GetGrados()
		{
			return this._grados;
		}

		#endregion
	}
}
