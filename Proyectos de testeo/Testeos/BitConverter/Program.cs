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


namespace Jeje
{
    public class Program
	{
        public static void Main(string[] args)
        {
            try
            {

                StreamReader stream = new StreamReader("gjgdflg");
                stream.ReadToEnd();
                stream.Close();
            }
            catch (Exception)
            {

                throw;
            }
           // Test test = new Test();
           // test.Mostrar();
            Console.ReadKey();
        }
    }
}
