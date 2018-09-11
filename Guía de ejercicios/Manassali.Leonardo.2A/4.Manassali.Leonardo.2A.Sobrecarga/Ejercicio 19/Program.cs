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
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 19";

			Sumador sumador = new Sumador(10);
			Sumador sumador2 = new Sumador(10);
			//Console.WriteLine("La suma da {0}",sumador.Sumar(5, 5)); 
			//Console.WriteLine("La suma da {0}",sumador.Sumar("a", "b")); 
		    long sumas = sumador + sumador2;
			Console.WriteLine("Se han realizado {0} sumas",sumas);
			if( sumador | sumador2 )
			{
				Console.WriteLine("Son iguales");
			}
			Console.ReadLine();

		}
	}
}
