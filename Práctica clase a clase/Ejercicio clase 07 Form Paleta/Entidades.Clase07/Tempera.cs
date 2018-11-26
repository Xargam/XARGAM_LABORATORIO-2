using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
  public class Tempera
  {
    #region Atributos

    private sbyte _cantidad;
    private ConsoleColor _color;
    private string _marca;

    #endregion

    #region Constructor

    public Tempera( sbyte cantidad , ConsoleColor color , string marca)
    {
      this._cantidad = cantidad;
      this._color = color;
      this._marca = marca;
    }

    #endregion

    #region Sobrecargas

    #region Conversion

    public static implicit operator string(Tempera tempera)
    {
      return tempera.Mostrar();
    }

    public static explicit operator sbyte(Tempera tempera)
    {
      return tempera._cantidad;
    }

    #endregion


    #region Comparacion

    public static bool operator ==(Tempera tempera1, Tempera tempera2)
    {
      return tempera1._color == tempera2._color && tempera1._marca == tempera2._marca;
    }

    public static bool operator !=(Tempera tempera1, Tempera tempera2)
    {
      return !(tempera1 == tempera2);
    }

    #endregion


    #region SumaResta

    public static Tempera operator +(Tempera tempera1, Tempera tempera2)
    {
      Tempera tempera3 = new Tempera(tempera1._cantidad, tempera1._color, tempera1._marca);

      if (tempera1 == tempera2)
      {
        tempera3 += tempera2._cantidad;
      }
      return tempera3;
    }

    public static Tempera operator +(Tempera tempera1, sbyte cantidad)
    {
      Tempera tempera2 = new Tempera((sbyte)(tempera1._cantidad + cantidad), tempera1._color, tempera1._marca);
      return tempera2;
    }

    #endregion

    #endregion

    #region Metodos

    private string Mostrar()
    {
      string datos = "Marca: " + this._marca + "   ";
      datos += "Color: " + this._color.ToString() + "   ";
      datos += "Cantidad: " + this._cantidad.ToString();
      return datos;
    }

    #endregion
  }
}
