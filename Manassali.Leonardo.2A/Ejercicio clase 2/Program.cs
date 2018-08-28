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
            Entidades.Sello.mensaje = "Leonardo";
            Entidades.Sello.color = ConsoleColor.Blue;
            Entidades.Sello.imprimir();
            Entidades.Sello.ImprimirEnColor();
            Entidades.Sello.borrar();
            Console.Read();
        }
    }
}
