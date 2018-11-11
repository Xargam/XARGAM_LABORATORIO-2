using System;
using IO;

namespace Ejercicio_54
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Ejercicio 54";
            string path = "";
            try
            {
                MiClase3 obj = new MiClase3();
                obj.MetodoDeInstancia();
            }
            catch (Exception e)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + DateTime.Now.ToString("yyyyMMdd-hhmm") + ".txt";
                ArchivoTexto.Guardar(path,e.Message);
            }
            Console.WriteLine(ArchivoTexto.Leer(path));
            Console.ReadKey();
        }

        public static void MiMetodo()
        {
            throw new DivideByZeroException();
        }
    }
}
