using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace Entidades
{
  public class Persona
  {
    #region Atributos
    protected string _nombre;
    protected string _apellido;
    protected int _edad;
    protected ESexo _sexo;

    #endregion

    #region Propiedades
    public string Nombre
    {
      get
      {
        return this._nombre;
      }
    }

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
    }
    public int Edad
    {
      get
      {
        return this._edad;
      }
    }
    public ESexo Sexo
    {
      get
      {
        return this._sexo;
      }
    }
    #endregion

    #region Constructores
    public Persona()
    {

    }
    public Persona(string nombre , string apellido , int edad , ESexo sexo)
    {
      this._nombre = nombre;
      this._apellido = apellido;
      this._edad = edad;
      this._sexo = sexo;
    }
    #endregion

    /*#region Operadores

    #region Comparacion

    #endregion

    #region Aritmeticos

    #endregion

    #endregion
  */
    #region Metodos
    public string ObtenerDatos()
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("{0} {1} {2} {3}",this.Nombre, this.Apellido, this.Edad , this.Sexo.ToString());
      return datos.ToString();
    }


    #endregion

  }
}
