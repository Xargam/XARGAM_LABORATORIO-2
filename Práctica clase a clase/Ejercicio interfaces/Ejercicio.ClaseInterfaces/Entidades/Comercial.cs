using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Comercial : Avion , IARBA
  {
    #region Atributos
    protected int _capacidadPasajeros;
    #endregion

    #region Constructor
    public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
    {
      this._capacidadPasajeros = pasajeros;
    }
    #endregion

    #region Implementacion IARBA
    double IARBA.CalcularImpuesto()
    {
      return this._precio * 0.25;
    }
    #endregion
  }
}
