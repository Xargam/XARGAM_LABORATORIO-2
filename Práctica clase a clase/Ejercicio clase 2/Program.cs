using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Sello.Mensaje = "";
            Entidades.Sello.Color = ConsoleColor.DarkMagenta;
            Entidades.Sello.ImprimirEnColor();
            Entidades.Sello.Borrar();
            Console.Read();
        }
    }
}
