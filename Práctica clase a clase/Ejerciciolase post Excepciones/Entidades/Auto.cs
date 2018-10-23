using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Auto
  {
    #region Atributos
    private string _color;
    private string _marca;
    #endregion

    #region Propiedades
    public string Color
    {
      get
      {
        return this._color;
      }
    }
    public string Marca
    {
      get
      {
        return this._marca;
      }
    }
    #endregion

    #region Constructor
    public Auto(string color, string marca)
    {
      this._color = color;
      this._marca = marca;
    }
    #endregion

    #region Sobrecargas
    public static bool operator ==(Auto a, Auto b)
    {
      return a.Marca == b.Marca && a.Color == b.Color;
    }
    public static bool operator !=(Auto a, Auto b)
    {
      return !(a == b);
    }
    #endregion

    #region Metodos
    public override string ToString()
    {
      StringBuilder data = new StringBuilder();
      data.AppendFormat("Marca: {0} - Color: {1}", this.Marca, this.Color);
      return data.ToString();
    }

    public override bool Equals(object obj)
    {
      return (obj is Auto) && (Auto)obj  == this;
    }
    #endregion
  }
}
