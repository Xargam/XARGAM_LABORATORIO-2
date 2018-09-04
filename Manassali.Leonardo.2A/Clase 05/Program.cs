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
      Console.Title = "Ejercicio clase 5";
      Tinta x = new Tinta();
      Tinta y = new Tinta();
      if(x == y)
      {
        Console.WriteLine("Son iguales.");
      }
      Console.ReadLine();
      

    }
  }
}
