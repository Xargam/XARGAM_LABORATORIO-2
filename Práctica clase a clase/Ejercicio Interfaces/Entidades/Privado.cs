using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Privado : Avion
  {
    #region Atributos
    protected int _valoracionSerivicioDeAbordo;
    #endregion

    #region Constructor
    public Privado(double precio,double velocidad,int valoracion):base(precio,velocidad)
    {
      this._valoracionSerivicioDeAbordo = valoracion;
    }
    #endregion
  }
}
