using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public static class Gestion
  {
    #region Metodos
    public static double MostrarImpuestoNacional(IAFIP bienPunible)
    {
      return bienPunible.CalcularImpuesto();
    }
    public static double MostrarImpuestoProvincial(IARBA bienPunible)
    {
      return bienPunible.CalcularImpuesto();
    }
    #endregion
  }
}
