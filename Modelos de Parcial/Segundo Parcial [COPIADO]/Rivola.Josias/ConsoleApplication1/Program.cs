using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {


        public static bool Deserializar(ISerializable obj)
        {         
            return ((Cajon<Fruta>)obj).DeserealizarXML();
        }

        public static bool Serializar(ISerializable obj)
        {
            return ((Cajon<Fruta>)obj).SerializarXML();
        }

        static void Main(string[] args)
        {
            

            Cajon<Fruta> cajon = new Cajon<Fruta>(6,5);
            Manzana m1 = new Manzana(10,ConsoleColor.Black,"filgo");
            Manzana m2 = new Manzana(11, ConsoleColor.Red, "filgo");
            Manzana m3 = new Manzana(12, ConsoleColor.Green, "filgo");

            Platano p1 = new Platano(20, ConsoleColor.Red, "Cuba");
            Platano p2 = new Platano(21, ConsoleColor.White, "Arabia");
            Platano p3 = new Platano(22, ConsoleColor.Yellow, "Asgard");

            try
            {
                cajon += m1;
                cajon += m2;
                cajon += m3;
                cajon += p1;
                cajon += p2;
                cajon += p3;
            }
            catch (CajonLlenoException e)
            {
                Console.Write(e.Message);
            }
            Console.WriteLine(cajon.ToString());

            try
            {
                Program.Serializar(cajon);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            Console.Read();

        }

        private string ObtenerPreciosBD(ISerializable obj)
        {                                      
            return "";
        }

        

        public delegate void ListadoBD(object objeto, EventArgs evento);

    }
}
