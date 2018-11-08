using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<string, int> guardarTexto = new GuardarTexto<string, int>();
            Serializar<string, int> serializar = new Serializar<string, int>();
            Console.WriteLine(guardarTexto.Guardar("hotellum")); 
            Console.WriteLine(serializar.Guardar("Trivago"));
            Console.WriteLine(guardarTexto.Leer());
            Console.ReadKey();
        }
    }
}
