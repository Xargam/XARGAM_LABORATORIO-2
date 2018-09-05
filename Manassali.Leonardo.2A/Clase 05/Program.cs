using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio clase 6";

      Tinta lapiz = null;
      Tinta lapiz2 = new Tinta(ConsoleColor.Blue, ElTipoTinta.Comun);

      Pluma lapicera = new Pluma();

      lapicera -= lapiz;

      Console.ReadLine();

    }
  }
}
