using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Deportivo : Auto , IARBA , IAFIP
  {
    #region Atributos
    protected int _caballosFuerza;
    #endregion

    #region Constructor
    public Deportivo(double precio, string patente, int hp) : base(precio, patente)
    {
      this._caballosFuerza = hp;
    }
    #endregion

    #region Implementacion IAFIP
    double IAFIP.CalcularImpuesto()
    {
      return this._precio * 0.28;
    }
    double IARBA.CalcularImpuesto()
    {
      return this._precio * 0.23;
    }
    #endregion
  }
}
