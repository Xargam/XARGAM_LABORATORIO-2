using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Lavadero
  {
    #region Atributos
    private List<Vehiculo> _vehiculos;
    private static float _precioAuto;
    private static float _precioCamion;
    private static float _precioMoto;
    private string _razonSocial;
    #endregion

    #region Propiedades
    public string LavaderoToString
    {
      get
      {
        string datos = string.Format("Lavadero:\nRazon social: {0}\nPrecios:\nAutos: {1} - Camiones: {2} - Motos: {3}\n",
          this._razonSocial, Lavadero._precioAuto, Lavadero._precioCamion, Lavadero._precioMoto);
        datos += this.Vehiculos;
        return datos;
      }

    }

    public string Vehiculos
    {
      get
      {
        string datos = "";
        foreach (Vehiculo v in this._vehiculos)
        {
          datos += v.ToString() + "\n";
        }
        return datos;
      }

    }
    #endregion

    #region Constructor
    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(string razonSocial) : this()
    {
      this._razonSocial = razonSocial;
    }

    static Lavadero()
    {
      Random precios = new Random();
      Lavadero._precioAuto = precios.Next(150, 566);
      Lavadero._precioCamion = precios.Next(150, 566);
      Lavadero._precioMoto = precios.Next(150, 566);
    }
    #endregion

    #region Operadores

    #region Comparacion
    public static bool operator ==(Lavadero l, Vehiculo v)
    {
      return ((v == l) > -1) ? true : false;
    }

    public static bool operator !=(Lavadero l, Vehiculo v)
    {
      return !(l == v);
    }

    public static int operator ==(Vehiculo v, Lavadero l)
    {
      int index = -1;
      for (int i = 0; i < l._vehiculos.Count; i++)
      {
        if (l._vehiculos[i] == v)
        {
          index = i;
          break;
        }
      }
      return index;
    }

    public static int operator !=(Vehiculo v, Lavadero l)
    {
      return 0;
    }
    #endregion

    #region Aritmetica

    public static Lavadero operator +(Lavadero l, Vehiculo v)
    {
      if (l != v)
      {
        l._vehiculos.Add(v);
      }
      return l;
    }

    public static Lavadero operator -(Lavadero l, Vehiculo v)
    {
      if (l == v)
      {
        l._vehiculos.RemoveAt(v == l);
      }
      return l;
    }

    #endregion

    #endregion

    #region Metodos

    public double MostrarTotalFacturado()
    {
      double ganancia = 0;
      ganancia += this.MostrarTotalFacturado(EVehiculos.Auto);
      ganancia += this.MostrarTotalFacturado(EVehiculos.Camion);
      ganancia += this.MostrarTotalFacturado(EVehiculos.Moto);
      return ganancia;
    }

    public double MostrarTotalFacturado(EVehiculos vehiculo)
    {
      double ganacia = 0;
      foreach (Vehiculo v in this._vehiculos)
      {
        switch (vehiculo)
        {
          case EVehiculos.Auto:
            if (v is Auto)
            {
              ganacia += Lavadero._precioAuto;
            }
            break;
          case EVehiculos.Camion:
            if (v is Camion)
            {
              ganacia += Lavadero._precioCamion;
            }
            break;
          case EVehiculos.Moto:
            if (v is Moto)
            {
              ganacia += Lavadero._precioMoto;
            }
            break;
        }
      }
      return ganacia;

    }

    public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
    {
      return string.Compare(v1.patente, v2.patente);
    }

    public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
    {
      return string.Compare(v1.marca.ToString(), v2.marca.ToString());
    }

    #endregion
  }
}
