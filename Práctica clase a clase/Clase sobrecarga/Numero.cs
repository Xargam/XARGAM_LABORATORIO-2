using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_sobrecarga
{
  class Numero
  {
    public double valor;

    public static explicit operator Numero(double a )
    {
      Numero c = new Numero();
      c.valor = a;
      return c;
    }
  }
}
