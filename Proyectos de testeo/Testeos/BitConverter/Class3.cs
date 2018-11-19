using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Hotel
{
    class Test
    {
        public static bool AbrirBinario(string path)
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream archivo = new FileStream(path, FileMode.Open);
            bool obj = (bool)binario.Deserialize(archivo);
            archivo.Close();
            return obj;
        }
        public string Mostrar()
        {
            List<int> lista = new List<int>();
            lista.Add(5);
            lista.Add(10);
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            lista.Add(55);
            lista.Add(51);
            lista.Add(51);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);
           
            BitConverter.Internet internet = new BitConverter.Internet();
            return "";
        }
    }
}

namespace BitConverter
{
    class Internet
    {
        public static bool AbrirBinario(string path)
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream archivo = new FileStream(path, FileMode.Open);
            bool obj = (bool)binario.Deserialize(archivo);
            archivo.Close();
            return obj;
        }
        public string Speedy()
        {
            Console.WriteLine(this.GetType().Assembly); 
            return "";
        }
    }

    interface IJaja
    {
        void Naranja(int numerin);
    }

    abstract class Class3 : IJaja
    {

        public int Raro()
        {
            return 00;
        }

        void IJaja.Naranja(int numerin)
        {
            throw new NotImplementedException();
        }
    }
}
