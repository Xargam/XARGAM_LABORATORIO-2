using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_Parte_2
{
  public class Cocina
  {
    #region Atributos
    private int _codigo;
    private bool _esIndustrial;
    private double _precio;
    #endregion

    #region Propiedades
    public int Codigo
    {
      get
      {
        return this._codigo;
      }
    }
    public bool EsIndustrial
    {
      get
      {
        return this._esIndustrial;
      }
    }
    public double Precio
    {
      get
      {
        return this._precio;
      }
    }
    #endregion

    #region Constructor
    public Cocina(int codigo, double precio, bool esIndustrial)
    {
      this._codigo = codigo;
      this._precio = precio;
      this._esIndustrial = esIndustrial;
    }
    #endregion

    #region Sobrecargas
    public static bool operator ==(Cocina a , Cocina b)
    {
      return a.Codigo == b.Codigo;
    }
    public static bool operator !=(Cocina a, Cocina b)
    {
      return !(a == b);
    }
    #endregion

    #region Metodos
    public override bool Equals(object obj)
    {
      return (obj is Cocina) && (Cocina)obj == this;
    }
    public override string ToString()
    {
      StringBuilder data = new StringBuilder();
      data.AppendFormat("Código: {0} - Precio: {1} - Es industrial? {2}", this.Codigo, this.Precio, this.EsIndustrial);
      return data.ToString();
    }
    #endregion

  }
}
