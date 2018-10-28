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
	public class Fahrenheit
	{
		#region Atributos

		private double _grados;

		#endregion

		#region Constructor

		public Fahrenheit(double grados)
		{
			this._grados = grados;
		}

		#endregion

		#region Operadores

		#region Conversion

		public static explicit operator Kelvin(Fahrenheit gradosF )
		{
			return new Kelvin((gradosF.GetGrados() + 459.67) * (5.0 / 9.0));
		}

		public static explicit operator Celsius(Fahrenheit gradosF)
		{
			return new Celsius((gradosF.GetGrados() - 32.0) * (5.0 / 9.0));
		}

		public static implicit operator Fahrenheit(double grados)
		{
			return new Fahrenheit(grados);
		}

		#endregion

		#region SumaResta

		public static Fahrenheit operator -(Fahrenheit gradosF, Celsius gradosC )
		{
			return (Fahrenheit)((Celsius)gradosF - (Fahrenheit)gradosC);
		}

		public static Fahrenheit operator -(Fahrenheit gradosF, Kelvin gradosK)
		{
			return gradosF - (Celsius)gradosK;
		}

		public static Fahrenheit operator +(Fahrenheit gradosF, Kelvin gradosK)
		{
			return (Fahrenheit)((Celsius)gradosF + gradosK);
		}

		public static Fahrenheit operator +(Fahrenheit gradosF, Celsius gradosC)
		{
			return gradosF + (Kelvin)gradosC;
		}

		#endregion

		#region Igualdad

		public static bool operator !=(Fahrenheit gradosF, Kelvin gradosK)
		{
			return !(gradosF == gradosK);
		}

		public static bool operator !=(Fahrenheit gradosF, Celsius gradosC)
		{
			return !(gradosF == gradosC); ;
		}

		public static bool operator !=(Fahrenheit gradosF1, Fahrenheit gradosF2)
		{
			return !(gradosF1 == gradosF2);
		}


		public static bool operator ==(Fahrenheit gradosF, Kelvin gradosK)
		{
			return gradosF == (Fahrenheit)gradosK;
		}

		public static bool operator ==(Fahrenheit gradosF, Celsius gradosC)
		{
			return gradosF == (Fahrenheit)gradosC;
		}

		public static bool operator ==(Fahrenheit gradosF1, Fahrenheit gradosF2)
		{
			return (Celsius)gradosF1 == (Celsius)gradosF2;
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
