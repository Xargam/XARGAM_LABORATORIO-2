using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
21. Crear tres clases: Fahrenheit, Celsius y Kelvin. Realizar un ejercicio similar al anterior, teniendo en
cuenta que:
F = C * (9/5) + 32
C = (F-32) * 5/9
F = K * 9/5 – 459.67
K = (F + 459.67) * 5/9
*/

namespace Grados
{
	public class Celsius
	{
		#region Atributos

		private double _grados;

		#endregion

		#region Constructor

		public Celsius(double grados)
		{
			this._grados = grados;
		}

		#endregion

		#region Operadores

		#region Conversion

		public static explicit operator Fahrenheit(Celsius gradosC)
		{
			return new Fahrenheit((gradosC.GetGrados() * (9.0 / 5.0)) + 32.0);
		}

		public static explicit operator Kelvin(Celsius gradosC)
		{
			return (Kelvin)(Fahrenheit)gradosC;
		}

		public static implicit operator Celsius(double grados)
		{
			return new Celsius(grados);
		}

		#endregion

		#region SumaResta

		public static Celsius operator -(Celsius gradosC, Fahrenheit gradosF)
		{
			return gradosC + new Fahrenheit( gradosF.GetGrados() * -1);
		}

		public static Celsius operator -(Celsius gradosC, Kelvin gradosK )
		{
			return gradosC - (Fahrenheit)gradosK;
		}

		public static Celsius operator +(Celsius gradosC, Fahrenheit gradosF)
		{
			return new Celsius(gradosC.GetGrados() + ((Celsius)gradosF).GetGrados());
		}

		public static Celsius operator +(Celsius gradosC, Kelvin gradosK)
		{
			return  gradosC + (Fahrenheit)gradosK;
		}


		#endregion

		#region Igualdad

		public static bool operator !=(Celsius gradosC, Kelvin gradosK)
		{
			return !(gradosC == gradosK);
		}

		public static bool operator !=(Celsius gradosC, Fahrenheit gradosF)
		{
			return !(gradosC == gradosF); ;
		}

		public static bool operator !=(Celsius gradosC1, Celsius gradosC2)
		{
			return !(gradosC1 == gradosC2);
		}

		public static bool operator ==(Celsius gradosC, Fahrenheit gradosF )
		{
			return gradosC == (Celsius)gradosF;
		}

		public static bool operator ==(Celsius gradosC, Kelvin gradosK)
		{
			return gradosC == (Celsius)gradosK;
		}

		public static bool operator ==(Celsius gradosC1, Celsius gradosC2)
		{
			return gradosC1.GetGrados() == gradosC2.GetGrados();
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

