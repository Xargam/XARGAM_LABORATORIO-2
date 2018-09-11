using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numeros;

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
			NumeroBinario binario = "101.1";
      NumeroDecimal decimal2 = 50;
      NumeroBinario binario2 = "101.1";

      NumeroDecimal deci = 5.5;
			deci = deci + binario;
			if( deci != binario )
			{
				Console.WriteLine("Son igualitos");
			}

			Console.WriteLine((double)deci);

			//Console.WriteLine((string)binario);
			Console.ReadLine();
		}
	}
}
