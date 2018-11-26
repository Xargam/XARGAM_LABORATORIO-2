using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades
{
  public class PersonaExternaHeredada : PersonaExterna
  {
    public PersonaExternaHeredada(string nombre , string apellido , int edad , Entidades.Externa.ESexo sexo) : base(nombre,apellido,edad,sexo)
    {
    }

    #region Metodos
    public string ObtenerDatos()
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("{0} {1} {2} {3}", base._nombre, base._apellido, base._edad, base._sexo.ToString());
      return datos.ToString();
    }
    #endregion
  }
}
