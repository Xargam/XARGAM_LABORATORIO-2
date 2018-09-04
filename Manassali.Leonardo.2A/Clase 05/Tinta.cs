using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  public class Tinta
  {
    private ConsoleColor _color;
    private ElTipoTinta _tipoDeTinta;

    public Tinta()
    {
      this._color = ConsoleColor.Blue;
      this._tipoDeTinta = ElTipoTinta.ConBrillito;
    }

    public Tinta(ConsoleColor color) : this()
    {
      this._color = color;
    }

    public Tinta(ConsoleColor color, ElTipoTinta tinta) : this(color)
    {
      this._tipoDeTinta = tinta;
    }

    /*
    private string _Mostrar()
    {
      string atributos;
      atributos = ;
      return atir;
    }

    public static string Mostrar( Tinta t1 )
    {
      string atributos;
      
    }
    */

    public static bool operator ==( Tinta t1, Tinta t2)
    {
      return t1._tipoDeTinta == t2._tipoDeTinta && t1._color == t2._color ;
    }

    public static bool operator !=(Tinta t1, Tinta t2)
    {
      return !(t1._tipoDeTinta == t2._tipoDeTinta && t1._color == t2._color);
    }

  }
}
