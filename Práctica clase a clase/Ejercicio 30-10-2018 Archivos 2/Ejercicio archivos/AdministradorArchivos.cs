using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_archivos
{
  public static class AdministradorArchivos
  {
    #region Metodos
    public static bool Escribir(string path , string data)
    {
      bool verificacion = false;
      try
      {
        using (StreamWriter streamWriter = new StreamWriter(path,true))
        {
          streamWriter.WriteLine(data);
        }
        verificacion = true;
      }
      catch (Exception)
      {
        Console.WriteLine("ERROR durante escritura de un fichero.");
      }
      return verificacion;
    }
    public static bool Leer(string path, out string data)
    {
      bool verificacion = false;
      data = "";
      try
      {
        using (StreamReader streamReader = new StreamReader(path))
        {
          data = streamReader.ReadToEnd();
        }
        verificacion = true;
      }
      catch (Exception)
      {
        Console.WriteLine("ERROR durante lectura de un fichero.");
      }
      return verificacion;
    }
    #endregion
  }
}
