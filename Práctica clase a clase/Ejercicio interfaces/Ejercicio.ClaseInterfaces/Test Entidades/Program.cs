using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test_Entidades
{
  public class Program
  {
    static void Main(string[] args)
    {
      Privado privado = new Privado(400, 3000, 5);
      Comercial comercial = new Comercial(100,50,40);
      Avion avion = new Avion(4000, 2000);

      Console.WriteLine( Gestion.MostrarImpuestoProvincial( comercial )); // La seleccion de implementaciones de interfaces funciona igual que el polimorfismo. 
      Console.WriteLine( Gestion.MostrarImpuestoProvincial( avion ));
      Console.ReadKey();
      //Deportivo deportivo2 = new Deportivo(100);
      //Console.WriteLine("Impuesto: {0}",); La implementacion de interfaces existe en clases derivadas, si se implementa de manera explicita la interfaz será necesario un casteo.
      
      Deportivo deportivo = new Deportivo(2000, "trivago", 400);
      Avion av2 = new Avion(400, 2500);
      Console.WriteLine( Gestion.MostrarImpuestoProvincial(av2));
      Console.WriteLine( Gestion.MostrarImpuestoNacional(av2));

      IAFIP deluxeCar = deportivo;
      IAFIP plane = avion;

      deportivo.MostrarPatente();
      Console.WriteLine("El impuesto a pagar por el avion es de ${0}",plane.CalcularImpuesto());
      Console.WriteLine("El impuesto a pagar por el deportivo es de ${0}",deluxeCar.CalcularImpuesto());
      Console.ReadKey();
      Console.WriteLine();
    }
  }
}
