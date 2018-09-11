using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
16. Crear la clase Alumno de acuerdo al siguiente diagrama:
a.Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main.Colocarle
nombre, apellido y legajo a cada uno de ellos.
b.Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado".
*/

namespace Ejercicio_16
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Ejercicio 16";

			Alumno alumno1 = new Alumno();
			alumno1.apellido = "Varela";
			alumno1.nombre = "Nancy";
			alumno1.legajo = 10;
			alumno1.Estudiar(10, 10);
			Console.WriteLine(alumno1.Mostrar());

			Alumno alumno2 = new Alumno();
			alumno2.nombre = "José";
			alumno2.apellido = "Biscardi";
			alumno2.legajo = 11;
			alumno2.Estudiar(1, 2);
			Console.WriteLine(alumno2.Mostrar());

			Alumno alumno3 = new Alumno();
			alumno3.nombre = "Juan";
			alumno3.apellido = "Crusso";
			alumno3.legajo = 12;
			alumno3.Estudiar(4, 6);
			Console.WriteLine(alumno3.Mostrar());

			Console.ReadLine();
		}
	}
}
