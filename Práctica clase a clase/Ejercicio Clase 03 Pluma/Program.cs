using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_3
{
  class Program
  {
    static void Main(string[] args)
    {
      Cosa obj = new Cosa();
      obj.EstablecerValor("hi");
      obj.EstablecerValor(4.5);
      Console.WriteLine(Cosa.Mostrar(obj));
      Console.ReadLine();

    }
  }
}
