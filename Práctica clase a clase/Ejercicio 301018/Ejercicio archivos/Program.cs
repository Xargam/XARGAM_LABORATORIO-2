using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio_archivos
{
  class Program
  {
    static void Main(string[] args)
    {
      string data = "Hola mundo! Desktop!";
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.txt";

      //verifico si existe el path
      if (File.Exists(path))
      {
        Console.WriteLine("La ruta {0} SI existe", path);
      }
      else
      {
        Console.WriteLine("La ruta {0} NO existe", path);
      }

      //Leo y escribo en escritorio
      if ( AdministradorArchivos.Escribir(path, data))
      {
        Console.WriteLine("Operacion de esctritura realizada correctamente",path);
      }
      if( AdministradorArchivos.Leer(path, out data))
      {
        Console.WriteLine("Operacion de lectura realizada correctamente", path);
        Console.WriteLine("Datos leidos: {0}", data);
      }
      //Cambio path a documentos
      path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\archivo.txt";
      data = @"Hola mundo! Mis documentos!";
      //Leo y escribo en documentos
      if (AdministradorArchivos.Escribir(path, data))
      {
        Console.WriteLine("Operacion de esctritura realizada correctamente");
      }
      if (AdministradorArchivos.Leer(path, out data))
      {
        Console.WriteLine("Operacion de lectura realizada correctamente");
        Console.WriteLine("Datos leidos: {0}", data);
      }
     //Cambio path a imagenes
      path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\archivo.txt";
      data = @"Hola mundo! Mis imagenes!";
      //Leo y escribo en imagenes
      if (AdministradorArchivos.Escribir(path, data))
      {
        Console.WriteLine("Operacion de esctritura realizada correctamente");
      }
      if (AdministradorArchivos.Leer(path, out data))
      {
        Console.WriteLine("Data leidos: {0}",data);
        Console.WriteLine("Operacion de lectura realizada correctamente");
      }

      //Cambio path a exe de la app
      path = AppDomain.CurrentDomain.BaseDirectory + "\\archivo.txt";
      data = @"Hola mundo! .exe!";
      //Leo y escribo en exe de la app
      if (AdministradorArchivos.Escribir(path, data))
      {
        Console.WriteLine("Operacion de esctritura realizada correctamente");

      }
      if (AdministradorArchivos.Leer(path, out data))
      {
        Console.WriteLine("Data leidos: {0}", data);
        Console.WriteLine("Operacion de lectura realizada correctamente");
      }
      Console.ReadKey();
    }
  }
}
