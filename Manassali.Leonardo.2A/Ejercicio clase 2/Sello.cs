using System;

namespace Entidades
{
    internal class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string imprimir()
        {
            return Sello.mensaje;
        }

        public static void borrar()
        {
            mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.imprimir());
        }

    }
}
