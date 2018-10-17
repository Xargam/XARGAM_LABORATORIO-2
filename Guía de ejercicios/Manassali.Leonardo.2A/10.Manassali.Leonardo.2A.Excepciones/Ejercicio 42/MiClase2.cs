using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  public class MiClase2
  {
    private int _numero2;
    private char _letra2;

    public MiClase2(int numero , char letra)
    {
      try
      {
        this._numero2 = numero;
        this._letra2 = letra;
        new MiClase(this._numero2,this._letra2);
      }
      catch(Exception e)
      {
        throw new UnaExepcion(e.Message + "\nError en constructor clase 2.", e);
      }
      
    }

  }
}
