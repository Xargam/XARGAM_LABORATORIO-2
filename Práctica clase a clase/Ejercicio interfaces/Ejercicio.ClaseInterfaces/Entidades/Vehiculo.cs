using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public abstract class Vehiculo
  {
    #region Atributos
    protected double _precio;
    #endregion

    /*#region Propiedades
    public virtual double Precio { get;  }
    #endregion*/

    #region Constructor
    public Vehiculo(double precio)
    {
      this._precio = precio;
    }
    #endregion

    #region Metodos
    public abstract void MostrarPrecio();
    #endregion
  }
}
