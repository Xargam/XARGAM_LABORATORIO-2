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
    public class Program
	{
        public static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Mostrar();
            Console.ReadKey();
        }
    }
}
