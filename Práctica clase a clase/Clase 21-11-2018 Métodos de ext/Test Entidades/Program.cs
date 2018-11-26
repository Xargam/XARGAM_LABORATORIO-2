using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Test_Entidades
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Persona persona = new Persona("Javier", "Binario",45,ESexo.Masculino);
       PersonaExterna p2 = new PersonaExterna("John", "T", 45,Entidades.Externa.ESexo.Masculino);
       PersonaExternaHeredada p3 = new PersonaExternaHeredada("John", "T", 45, Entidades.Externa.ESexo.Masculino);
       PersonaExternaSellada p4 = new PersonaExternaSellada("Nahuel", "Cy", 45, Entidades.Externa.Sellada.ESexo.Masculino);
       Console.WriteLine(p4.ObtenerDatos());

       Persona persona2 = new Persona("Nahuel", "Cy", 45, ESexo.Masculino);
       Console.WriteLine(persona2.EsNulo());*/

      Persona p1 = new Persona("Leonardo","Tiny",5,ESexo.Masculino);
      Console.WriteLine( p1.Modificar(7) );
      //Console.WriteLine(p1.AgregarDB());
      Console.ReadKey();
    }
  }
}
