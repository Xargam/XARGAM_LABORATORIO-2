using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Entidades_Parte_2
{
  public class Deposito<T>
  {
    #region Atributos
    private int _capacidadMaxima;
    private List<T> _lista;
    #endregion

    #region Constructor
    public Deposito(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<T>();
    }
    #endregion

    #region Sobrecargas
    public static bool operator +(Deposito<T> d, T c)
    {
      bool verify = (d._lista.Count < d._capacidadMaxima);
      if (verify)
      {
        d._lista.Add(c);
      }
      return verify;
    }
    public static bool operator -(Deposito<T> d, T c)
    {
      int indice = d.GetIndice(c);
      if (indice > -1)
      {
        d._lista.RemoveAt(indice);
      }
      return (indice > -1) ? true : false;
    }
    #endregion

    #region Metodos
    private int GetIndice(T c)
    {
      int indice = -1;
      for (int i = 0; i < this._lista.Count; i++)
      {
        if (Object.Equals(this._lista[i],c) )
        {
          indice = i;
          break;
        }
      }
      return indice;
    }
    public bool Agregar(T c)
    {
      return this + c;
    }
    public bool Remover(T c)
    {
      return this - c;
    }

    public override string ToString()
    {
      StringBuilder data = new StringBuilder();
      data.AppendFormat("Capacidad máxima: {0}\r\nListado de {1}:\r\n", this._capacidadMaxima, typeof(T).Name);
      foreach (T item in this._lista)
      {
        data.AppendLine(item.ToString());
      }
      return data.ToString();
    }

    public bool Guardar(string ruta)
    {
      bool verify = true;
      try
      {
        using (StreamWriter stream = new StreamWriter(ruta, true))
        {
          stream.WriteLine(this.ToString());
        }
      }
      catch (Exception)
      {
        verify = false;
      }
      return verify;

    }

    public bool Recuperar(string ruta)
    {
      bool verify = true;
      try
      {
        using (StreamReader stream = new StreamReader(ruta))
        {
          Console.WriteLine(stream.ReadToEnd());
        }
      }
      catch (Exception)
      {
        verify = false;
      }
      return verify;
    }
    #endregion
  }
}
