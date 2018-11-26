using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Familiar : Auto
  {
    #region Atributos
    protected int _cantAsientos;
    #endregion

    #region Constructor
    public Familiar(double precio, string patente , int cantidadAsientos):base(precio,patente)
    {
      this._cantAsientos = cantidadAsientos;
    }
    #endregion
  }
}
