using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
  public class CentralitaException : Exception
  {
    #region Atributos
    private string _nombreClase;
    private string _nombreMetodo;
    #endregion

    #region Propiedades
    public string NombreClase
    {
      get
      {
        return this._nombreClase;
      }
    }
    public string NombreMetodo
    {
      get
      {
        return this._nombreMetodo;
      }
    }
    #endregion

    #region Constructor
    public CentralitaException(string mensaje, string clase, string metodo) : this(mensaje, clase , metodo , null )
    {

    }
    public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
    {
      this._nombreClase = clase;
      this._nombreMetodo = metodo;
    }
    #endregion
  }
}
