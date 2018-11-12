using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
57. Crear un nuevo proyecto del tipo Consola.
a.Crear una clase Persona con dos atributos privados del tipo string, nombre y apellido.
i.Agregarle un constructor que reciba ambos parámetros.
ii.Crear un método estático llamado Guardar que reciba una persona y la serialice en
un archivo.
iii.Crear un método estático Leer que deserialice un archivo y retorne una Persona.
iv.Sobrecargar el método ToString para mostrar los datos de la persona.
b.En el Main instanciar un objeto del tipo Persona e intentar serializarlo.
c.Luego intentar leer ese objeto serializado en una nueva instancia de persona y lo muestre
por pantalla.
d.Por cada excepción que lance la aplicación:
i.Generar un catch que la capture y la maneje.
ii.Luego corregir el problema que genera la excepción.
iii.Repetir el proceso hasta capturar todas las excepciones de forma individual (no
utilizar Exception).
iv.Los datos de la Persona
*/

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 57";
            try
            {
                Persona persona = new Persona("Leonardo", "Manassali");
                Persona persona2 = null;

                Persona.Guardar(persona);
                persona2 = Persona.Leer();
                Console.WriteLine(persona2);
            }
            catch (InvalidOperationException a)
            {
                Console.WriteLine("Me olvidé el constructor por default:\n{0}",a.Message);
            }
            Console.ReadKey();
        }
    }
}
