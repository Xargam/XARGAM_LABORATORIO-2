using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
  public class Alumno
  {
    #region Atributos
    private string _nombre;
    private string _apellido;
    private int _dni;
    private string _fotoAlumno;
    #endregion

    #region Propiedades
    public string Apellido
    {
      get
      {
        return this._apellido;
      }
      set
      {
        this._apellido = value;
      }
    }
    public int Dni
    {
      get
      {
        return this._dni;
      }
      set
      {
        this._dni = value;
      }
    }
    public string FotoAlumno
    {
      get
      {
        return this._fotoAlumno;
      }
      set
      {
        this._fotoAlumno = value;
      }
    }
    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }
    #endregion

    #region Constructores
    public Alumno(string nombre , string apellido , int dni , string ruta )
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
      this.Dni = dni;
    }
    #endregion
  }
}
