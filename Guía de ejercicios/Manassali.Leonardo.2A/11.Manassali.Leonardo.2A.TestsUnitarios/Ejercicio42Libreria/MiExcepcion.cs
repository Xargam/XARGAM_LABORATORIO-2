using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Libreria
{
  public class MiExcepcion : Exception
  {
    public MiExcepcion(string mensaje , Exception e) : base(mensaje , e)
    {
    }
  }
}
