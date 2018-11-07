using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Libreria
{
  public class MiClase3
  {
    public void MetodoDeInstancia()
    {
      try
      {
        new MiClase2(4,'c');
      }
      catch(Exception e)
      {
        throw new MiExcepcion(e.Message + "\nError en MetodoDeInstancia en Clase3.", e);
      }
    }
  }
}
