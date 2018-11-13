using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace BitConverter
{
    public delegate bool MiDelegado();

    internal class Program
	{

        public static event MiDelegado Eventooo;
        public static void Main(string[] args)
        {
            Eventooo += new MiDelegado(new Program().Metodo);
            Program.Eventooo();
        }



        public   bool Metodo()
        {
            Console.WriteLine(true);
            Console.ReadKey();
            return true;
        }
    }
}
