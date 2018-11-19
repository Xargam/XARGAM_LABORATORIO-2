using System.IO;
using System.

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


namespace Entidades
{
    public static class GuardaString
    {
        #region Metodos
        public static bool Guardar(this string texto, string archivo)
        {
            bool verificacion = false;
            if (File.Exists(archivo) )
            {
                StreamWriter stream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo, true);
                stream.WriteLine(texto);
                stream.Close();
                verificacion = true;
            }
            return verificacion;
        }
        #endregion
    }
}
