using Numero;
using Ejercicio_13;
using System;


/*
22. Tomando la clase Conversor del ejercicio 13, se pide:
Agregar las clases:
a. NumeroBinario:
i. único atributo número (string)
ii. único constructor privado (recibe un parámetro de tipo string)
b. NumeroDecimal
i. único atributo número (double)
ii. único constructor privado (recibe un parámetro de tipo double)
Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de
operadores:
c. NumeroBinario:
i. string + (NumeroBinario, NumeroDecimal)
ii. string - (NumeroBinario, NumeroDecimal)
iii. bool == (NumeroBinario, NumeroDecimal)
iv. bool != (NumeroBinario, NumeroDecimal)
d. NumeroDecimal:
i. double + (NumeroDecimal, NumeroBinario)
ii. double - (NumeroDecimal, NumeroBinario)
iii. bool == (NumeroDecimal, NumeroBinario)
iv. bool != (NumeroDecimal, NumeroBinario)
Agregar conversiones implícitas para poder ejecutar:
e. NumeroBinario objBinario = "1001";
f. NumeroDecimal objDecimal = 9;
Agregar conversiones explícitas para poder ejecutar:
g. (string)objBinario
h. (double)objDecimal
Generar el código en el Main para instanciar un objeto de cada tipo y operar entre ellos,
imprimiendo cada resultado por pantalla.
*/

namespace Ejercicio_22
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 22";
			NumeroBinario binario = "1111";
			NumeroDecimal decimal2 = -5;
			NumeroBinario binario2 = "101,1";
			 binario -= decimal2;
			decimal2 = Conversor.BinarioDecimal((string)binario);
			decimal2 += binario2;
			Console.WriteLine((double)decimal2);

			//Console.WriteLine((string)binario);
			Console.ReadLine();
		}
	}
}
