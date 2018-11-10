using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();
            bool valor;

            cartuchera1.Acciones.Add(new Lapiz(10));
            cartuchera1.Acciones.Add(new Lapiz(-5));
            cartuchera1.Acciones.Add(new Boligrafo(100,ConsoleColor.Black));
            cartuchera1.Acciones.Add(new Boligrafo(50,ConsoleColor.Cyan));
            cartuchera1.Acciones.Add(new Lapiz(100));
            cartuchera1.Acciones.Add(new Boligrafo(10,ConsoleColor.DarkCyan));
            cartuchera1.Acciones.Add(new Lapiz(7));

            cartuchera2.Boligrafos.Add(new Boligrafo(100, ConsoleColor.Black));
            cartuchera2.Boligrafos.Add(new Boligrafo(50, ConsoleColor.Cyan));
            cartuchera2.Boligrafos.Add(new Boligrafo(10, ConsoleColor.DarkCyan));
            cartuchera2.Lapices.Add(new Lapiz(10));
            cartuchera2.Lapices.Add(new Lapiz(10));
            cartuchera2.Lapices.Add(new Lapiz(100));
            cartuchera2.Lapices.Add(new Lapiz(7));

            Console.WriteLine("Probando cartuchera 1:\n");
            do
            {
                 valor = cartuchera1.ProbarElementos();
                Console.WriteLine(valor);
            }
            while (valor);

            Console.WriteLine("\nProbando cartuchera 2:\n");
            do
            {
                valor = cartuchera2.ProbarElementos();
                Console.WriteLine(valor);
            }
            while (valor);
            Console.ReadKey();
        }
    }
}
