using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Avion : Vehiculo , IAFIP , IARBA
  {
    #region Atributos
    protected double _velocidadMaxima;
    #endregion

    #region Constructor
    public Avion(double precio, double velMax) : base(precio)
    {
      this._velocidadMaxima = velMax;
    }
    #endregion

    #region Metodos
    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio {0}", base._precio);
    }
    double IAFIP.CalcularImpuesto()
    {
      return this._precio * 0.33;
    }

    double IARBA.CalcularImpuesto()
    {
      return this._precio * 0.27;
    }
    #endregion
  }
}
