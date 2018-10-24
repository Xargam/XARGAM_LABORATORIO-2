using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public abstract class Auto : Vehiculo
  {
    #region Atributos
    protected string _patente;
    #endregion

    #region Propiedades
   
    #endregion

    #region Constructor
    public Auto(double precio, string patente) : base(precio)
    {
      this._patente = patente;
    }
    #endregion

    #region Metodos
    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio {0}", base._precio);
    }
    public void MostrarPatente()
    {
      Console.WriteLine("Patente: {0}", this._patente);
    }
    #endregion
  }
}
