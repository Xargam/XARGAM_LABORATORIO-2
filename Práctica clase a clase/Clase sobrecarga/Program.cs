using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_sobrecarga
{
  class Program
  {
    static void Main(string[] args)
    {
      Numero a = new Numero();
      a = (Numero)5.0;
    }
  }
}
