using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
19. Realizar una aplicación de consola. Agregar la clase Sumador.
a. Crear dos constructores:
i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
siguiente lógica:
i. En el caso de Sumar(long, long) sumará los valores numéricos
ii. En el de Sumar(string, string) concatenará las cadenas de texto.
Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
c. Generar una conversión explícita que retorne cantidadSumas.
d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
con dicho valor.
e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
cantidadSumas.
Agregar un segundo objeto del tipo Sumador en el Main y probar el código.*/

namespace Ejercicio_19
{
	public class Sumador
	{

		#region Atributos

		private int _cantidadSumas;

		#endregion

		#region Constructor

		public Sumador() : this(0)
		{
		}

		public Sumador( int cantidadSumas)
		{
			this._cantidadSumas = cantidadSumas;
		}

		#endregion

		#region Operadores

		public static explicit operator int (Sumador sumador)
		{
			return sumador._cantidadSumas;
		}

		public static long operator +(Sumador sumador1 , Sumador sumador2)
		{
			return sumador1._cantidadSumas + sumador2._cantidadSumas;
		}

		public static bool operator |( Sumador sumador1 , Sumador sumador2)
		{
			return sumador1._cantidadSumas == sumador2._cantidadSumas;
		}

		#endregion

		#region Metodos

		public long Sumar( long a , long b )
		{
			this._cantidadSumas++;
			return a + b ;
		}

		public string Sumar(string a, string b) 
		{
			this._cantidadSumas++;
			return a + b;
		}

		#endregion
	}
}
