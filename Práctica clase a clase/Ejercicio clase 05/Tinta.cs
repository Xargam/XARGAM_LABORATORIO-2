using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  public class Tinta
  {

    #region Atributos

    private ConsoleColor _color;
    private ElTipoTinta _tipoDeTinta;

    #endregion

    #region Constructor

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

    #endregion

    #region Metodos

    private string Mostrar()
    {
      string atributos = "";

      atributos += this._color.ToString();
      atributos += '\n';
      atributos += this._tipoDeTinta.ToString();
      atributos += '\n';

      return atributos;

    }

    public static string Mostrar( Tinta t1 )
    {
      string retorno = "---";

      if( !Object.Equals(t1,null) )
      {
        retorno = t1.Mostrar();
      }

      return retorno;
    }

    #endregion

    #region Operadores

    public static bool operator ==( Tinta t1, Tinta t2)
    {
      bool retorno = false;

      if( !Object.Equals(t1, null) && !Object.Equals(t2, null) )
      {
        retorno = t1._tipoDeTinta == t2._tipoDeTinta && t1._color == t2._color;
      }

      return retorno ;
    }

    public static bool operator !=(Tinta t1, Tinta t2)
    {
      return !(t1._tipoDeTinta == t2._tipoDeTinta && t1._color == t2._color);
    }

    #endregion
  }
}
