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

namespace BitConverter
{
    [Serializable]
    public   class Class1
    {

        public int numero = 0;
        public int numero2 = 444;
        public override string ToString()
        {
            return "numero es 1 y numero 2 444"; 
        }
        public Class1()
        {
        }
    }
}
