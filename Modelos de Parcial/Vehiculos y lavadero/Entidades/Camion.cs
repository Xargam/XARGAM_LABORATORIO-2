using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Camion : Vehiculo
  {
    protected float _tara;

    public Camion(EMarcas marca, float tara, string patente, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._tara = tara;
    }

    public Camion(Vehiculo v, float tara) : this(v.marca,tara,v.patente,v.cantRuedas)
    {
    }

    protected override string Mostrar()
    {
      return "Camion:\n" + "Tara: " + this._tara + "\n" + base.Mostrar();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
