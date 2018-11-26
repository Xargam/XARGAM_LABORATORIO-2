using System;

namespace Entidades
{
  internal class Sello
  {
    public static string Mensaje;
    public static ConsoleColor Color;

    public static string Imprimir()
    {
      string cadena = "";
      if( Sello.TryParse( Sello.Mensaje , out cadena ) == true )
      {
        cadena = Sello.ArmarFormatoMensaje();
      }
      return cadena ;
    }

    public static void Borrar()
    {
      Mensaje = "";
    }
    
    public static void ImprimirSinColor()
    {
      Console.WriteLine(Sello.Imprimir());
    }

    public static void ImprimirEnColor()
    {
      Console.BackgroundColor = Sello.Color;
      Console.WriteLine(Sello.Imprimir());
    }


    private static bool TryParse(string msg, out string okMsg)
    {
      bool verificacion = false;
      okMsg = "";
      if( msg.Length > 0 )
      {
        okMsg = msg;
        verificacion = true;
      }
      return verificacion;
    }

    private static string ArmarFormatoMensaje()
    {
      string formato = "";
      string mensajeFormateado = "";

      for (int i = -1; i <= Mensaje.Length; i++)
      {
        formato += '*';
      }
      formato += '\n';

      mensajeFormateado += formato;
      mensajeFormateado += '*';
      mensajeFormateado += Sello.Mensaje;
      mensajeFormateado += "*\n";
      mensajeFormateado += formato;


      /*
      Sello.Mensaje = Sello.Mensaje.Insert(0, "*");
      Sello.Mensaje = Sello.Mensaje.Insert(0,mensajeFormateado);
      Sello.Mensaje += "*\n";
      Sello.Mensaje += mensajeFormateado;*/

      return mensajeFormateado;
    }

  }
}
