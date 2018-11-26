using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Carreta : Vehiculo, IARBA
  {
    #region Constructor
    public Carreta(double precio) : base(precio)
    {

    }
    #endregion

    #region Metodos
    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio: {0}",this._precio);
    }

    #endregion

    #region Implementacion IARBA
    double IARBA.CalcularImpuesto()
    {
      return this._precio * 0.18;
    }
    #endregion
  }
}
