using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BitConverter
{
    public class ClientePlus : Cliente
    {
        private int _atributo4 = 45;
        public override void ImprimirText(string nombre, bool append)
        {
            StreamWriter archivo = new StreamWriter(".\\" + nombre , append);
            archivo.WriteLine(this._atributo4.ToString() + base._atributo1.ToString() + base._atributo2.ToString() + base._atributo3.ToString());
            archivo.Close();
            StreamReader archivin = new StreamReader(".\\" + nombre);
            Console.WriteLine(archivin.ReadToEnd());
            Console.ReadKey();
            archivin.Close();
        }

        
    }
}
