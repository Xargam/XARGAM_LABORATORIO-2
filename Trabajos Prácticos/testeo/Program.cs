using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_1___Laboratorio_II;

namespace testeo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine( int.TryParse("415654654654654654654654654465", out num) );
            Console.ReadLine();
        }
    }
}
