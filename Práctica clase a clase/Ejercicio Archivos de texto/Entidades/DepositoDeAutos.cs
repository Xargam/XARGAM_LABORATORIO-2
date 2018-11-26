using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class DepositoDeAutos
  {
    #region Atributos
    private int _capacidadMaxima;
    private List<Auto> _lista;
    #endregion

    #region Constructor
    public DepositoDeAutos(int capacidad)
    {
      this._lista = new List<Auto>();
      this._capacidadMaxima = capacidad;
    }
    #endregion

    #region Sobrecargas
    public static bool operator +(DepositoDeAutos d, Auto a)
    {
      bool verify = (d._lista.Count < d._capacidadMaxima);
      if(verify )
      {
        d._lista.Add(a);
      }
      return verify;
    }
    public static bool operator -(DepositoDeAutos d, Auto a)
    {
      int indice = d.GetIndice(a);
      if( indice > -1)
      {
        d._lista.RemoveAt(indice);
      }
      return (indice > -1)? true : false;
    }
    #endregion

    #region Metodos

    public bool Agregar(Auto a)
    {
      return this + a;
    }
    private int GetIndice(Auto a)
    {
      int indice = -1;
      for(int i = 0; i < this._lista.Count; i++)
      {
        if(this._lista[i] == a)
        {
          indice = i;
          break;
        }
      }
      return indice;
    }
    public bool Remover(Auto a)
    {
      return this - a;
    }
    public override string ToString()
    {
      StringBuilder data = new StringBuilder();
      data.AppendFormat("Capacidad maxima: {0}\nListado de Autos:\n", this._capacidadMaxima);
      foreach (Auto item in this._lista)
      {
        data.AppendLine(item.ToString());
      }
      return data.ToString();
    }
    #endregion
  }
}
