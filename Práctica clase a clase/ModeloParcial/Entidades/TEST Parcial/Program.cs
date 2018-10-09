using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TEST_Parcial
{
  class Program
  {
    static void Main(string[] args)
    {
      Lavadero lavadero = new Lavadero("Xargam");
      Auto a1 = new Auto("100",EMarcas.Fiat,4);
      Auto a2 = new Auto("101", EMarcas.Honda, 4);
      Auto a3 = new Auto("102", EMarcas.Scania, 4);
      lavadero += a1;
      lavadero += a2;
      lavadero += a3;
      Console.WriteLine(lavadero.Vehiculos);

    }
  }
}
