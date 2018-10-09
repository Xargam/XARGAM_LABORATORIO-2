using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Moto : Vehiculo
  {
    protected float _cilindrada;

    public Moto(EMarcas marca, float cilindrada , string patente , byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._cilindrada = cilindrada;
    }

    protected override string Mostrar()
    {
      return string.Format("Moto:\nCilindrada: {}\n" + this._cilindrada) + base.ToString();
     }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
