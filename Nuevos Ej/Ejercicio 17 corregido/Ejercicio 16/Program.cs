using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*
16. Crear la clase Alumno de acuerdo al siguiente diagrama:
a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
nombre, apellido y legajo a cada uno de ellos.
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado".
*/


namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintura = "";

            Console.Title = "Ejercicio 17";

            Boligrafo lapiz = new Boligrafo();

            lapiz.color = ConsoleColor.DarkRed;
            lapiz.tinta = 2;
            if (lapiz.Pintar(4, out pintura) == false)
            {
                Console.WriteLine("No alcanzo la tinta para completar el dibujo.");
            }


        }
    }
}
