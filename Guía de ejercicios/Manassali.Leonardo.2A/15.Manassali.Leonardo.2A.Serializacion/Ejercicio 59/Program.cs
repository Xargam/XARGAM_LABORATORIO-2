using System;

namespace Ejercicio_59
{
    //Main DE CENTRALITA
	class Program
	{
		private static void Main(string[] args)
		{
			Console.Title = "Ejercicio 59";
			//Mi central
			Centralita c = new Centralita("Fede Center");
			//Mis 4 llamadas
			Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
			Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
			Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
			Provincial l4 = new Provincial(Provincial.Franja.Franja_1, l2);

			//Las llamadas se irán registrando en la Centralita.
			//La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
			try
			{
				//c += l1;
				////Console.WriteLine(c.ToString());
				//c += l2;
				////Console.WriteLine(c.ToString());
				//c += l3;
				////Console.WriteLine(c.ToString());
				//c += l4;
				////Console.WriteLine(c.ToString());
				//c += l4;
				////Console.WriteLine(c.ToString());
			}
			catch ( CentralitaException )
			{
				Console.WriteLine("Llamada ya registrada en el sistema.");
			}
            l1.RutaDelArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivito localito.xml";
            l1.Guardar();
            Console.WriteLine(l1.Leer());
            //Console.WriteLine(c.Leer());
            Console.ReadKey();

        }
	}
}
