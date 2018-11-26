using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Auto : Vehiculo
  {
    protected int _cantidadAsientos;

    public Auto(EMarcas marca, int cantidadAsientos, string patente, byte cantidadRuedas) : base(patente,cantidadRuedas,marca)
    {
      this._cantidadAsientos = cantidadAsientos;
    }

    public Auto(string patente , EMarcas marca , byte cantidadAsientos ) : this(marca,cantidadAsientos,patente,4)
    {
    }

    protected override string Mostrar()
    {
      return string.Format("Auto:\nCantidad de asientos: {0}\n", this._cantidadAsientos) + base.Mostrar();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

  }
}
