using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
  public class Punto
  {
    #region Atributos

    private int _x;
    private int _y;

    #endregion

    #region Constructor

    Punto(int x , int y )
    {
      this.x = x;
      this.y = y;
    }

    #endregion

    #region Metodos

    public int GetX()
    {
      return this._x;
    }

    public int GetY()
    {
      return this._y;
    }

    #endregion

  }
}
