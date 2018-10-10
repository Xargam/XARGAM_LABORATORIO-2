using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public abstract class Persona
  {
    #region Atributos
    private string _nombre;
	private string _documento;
	private string _apellido;
    #endregion

    #region Propiedades
    public string Apellido
    {
      get
      {
        return this._apellido;
      }
    }
		public string Nombre
		{
			get
			{
				return this._nombre;
			}
		}


		public string Documento
    {
      get
      {
        return this._documento;
      }
      set
      {
		this._documento = (this.ValidarDocumentacion(value)) ? value : this._documento;
      }
    }
    #endregion

    #region Constructor
    public Persona(string nombre, string apellido, string documento)
    {
	  this.Documento = documento;
	  this._nombre = nombre;
      this._apellido = apellido;
    }
	#endregion

	#region Metodos
	public virtual string ExponerDatos()
    {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Nombre: {0}\nApellido: {1}\n", this.Nombre, this.Apellido);
			sb.AppendFormat("Documento: {0}", this.Documento);
			return sb.ToString();
    }

	protected abstract bool ValidarDocumentacion(string doc);
    #endregion

    

  }

}
