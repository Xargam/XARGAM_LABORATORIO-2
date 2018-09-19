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
			Fahrenheit gradosF = new Fahrenheit( (gradosC.GetGrados() * (9.0 / 5.0)) + 32.0);
			return gradosF;
		}

		public static explicit operator Kelvin(Celsius gradosC)
		{
			Kelvin gradosK = (Kelvin)(Fahrenheit)gradosC;
			return gradosK;
		}

		public static implicit operator Celsius(double grados)
		{
			Celsius gradosC = new Celsius(grados);
			return gradosC;
		}

		/*public static implicit operator double(Celsius gradosC)
		{
			return gradosC.GetGrados();
		}*/

		#endregion

		#region SumaResta

		public static Celsius operator -(Celsius gradosC, Fahrenheit gradosF)
		{
			Celsius resultado = new Celsius(gradosC.GetGrados() - ((Celsius)gradosF).GetGrados());
			return resultado;
		}

		public static Celsius operator -(Celsius gradosC, Kelvin gradosK )
		{
			return gradosC - (Fahrenheit)gradosK;
		}

		public static Celsius operator +(Celsius gradosC, Fahrenheit gradosF)
		{
			Celsius resultado = new Celsius(gradosC.GetGrados() + ((Celsius)gradosF).GetGrados());
			return resultado;
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

