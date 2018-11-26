using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_06
{
  public class Pluma
  {
    #region Atributos

    private string _marca;
    private int _cantidad;
    private Tinta _tinta;

    #endregion

    #region Constructor

    public Pluma()
    {
      this._marca = "Sin marca";
      this._tinta = null;
      this._cantidad = 0;
    }

    public Pluma(Tinta tinta) : this()
    {
      this._tinta = tinta;
    }

    public Pluma(Tinta tinta, int cantidad) : this(tinta)
    {
      this._cantidad = cantidad;
    }

    public Pluma(Tinta tinta, int cantidad, string marca) : this(tinta, cantidad)
    {
      this._marca = marca;
    }

    #endregion


    #region Operadores

    public static implicit operator string(Pluma p1)
    {
      return p1.Mostrar();
    }

    public static bool operator ==(Pluma p1, Tinta t1)
    {
      return Object.Equals(t1 , null ) &&  t1 == p1._tinta ;
    }

    public static bool operator !=(Pluma p1, Tinta t1)
    {
      return !(p1 == t1);
    }
    
    public static Pluma operator +( Pluma p1 , Tinta t1 )
    {
      if( p1 == t1 )
      {
        p1._cantidad = (p1._cantidad + 10 <= 90) ? p1._cantidad + 10 : 100 ;
      }
      return p1;
    }

    public static Pluma operator -(Pluma p1, Tinta t1)
    {
      if (p1 == t1)
      {
        p1._cantidad = (p1._cantidad - 10 >= 0 ) ? p1._cantidad - 10 : 0;
      }

      return p1;
    }

    #endregion


    #region Metodos

    private string Mostrar()
    {
      string cadena = "";

      cadena = this._cantidad.ToString();
      cadena += '\n';

      cadena += this._marca;
      cadena += '\n';

      cadena += Tinta.Mostrar(this._tinta);

      return cadena;
    }

    #endregion
  }
}
