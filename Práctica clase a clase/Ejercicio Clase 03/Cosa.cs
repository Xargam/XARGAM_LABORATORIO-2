using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_3
{
  public class Cosa
  {
    public string cadena = "";
    public double numero;
    public DateTime fecha;

    public Cosa()
    {
      this.cadena = "Sin valor";
      this.numero = 1.9;
      this.fecha = DateTime.Now;
    }

    public Cosa(string cadena) : this()
    {
      this.cadena = cadena;
    }

    public Cosa(double num) : this()
    {
      this.numero = num;
    }

    public Cosa(DateTime fecha) : this()
    {
      this.fecha = fecha;
    }

    public Cosa(double c, string b) : this()
    {
      this.numero = c;
    }

    #region Mostrar

    public static string Mostrar(Cosa obj)
    {
      return obj.Mostrar();
    }


    private string Mostrar()
    {
      return this.cadena + '\n' +  this.numero.ToString() + '\n' + this.fecha.ToString() + '\n';
    }

    #endregion Mostrar

    public void EstablecerValor(string cadena )
    {
      this.cadena = cadena;
    }

    public void EstablecerValor(double numero)
    {
      this.numero = numero;
    }

    public void EstablecerValor(DateTime fecha)
    {
      this.fecha = fecha;
    }
  }
}
