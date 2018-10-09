using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Vehiculo
  {
    #region Atributos
    protected string _patente;
    protected byte _cantRuedas;
    protected EMarcas _marca;
    #endregion

    #region Propiedades
    public string patente
    {
      get
      {
        return this._patente;
      }
    }

    public byte cantRuedas
    {
      get
      {
        return this._cantRuedas;
      }
      set
      {
        this._cantRuedas = value;
      }
    }

    public EMarcas marca
    {
      get
      {
        return this._marca;
      }
    }
    #endregion

    #region Constructor

    public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
    {
      this._patente = patente;
      this._cantRuedas = cantRuedas;
      this._marca = marca;
    }
    #endregion

    #region Metodos
    protected virtual string Mostrar()
    {
      return "Patente: " + this._patente + "\nCantidad de Ruedas: " + this._cantRuedas.ToString() +
       "\nMarca: " + this._marca.ToString() + "\n";
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
    #endregion

    #region Sobrecargas
    public static bool operator ==(Vehiculo v1, Vehiculo v2)
    {
      return v1._marca == v2._marca && v1._patente == v2._patente;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
      return !(v1 == v2);
    } 
    #endregion

  }

}
