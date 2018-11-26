using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
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
        /// <summary>
        /// Guarda esta cadena en un archivo de texto en el escritorio de la PC.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo">Nombre del archivo txt a donde guardar.</param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            //Evito que el metodo colapse con un valor nulo 
            archivo = (object.Equals(archivo, null)) ? "" : archivo ;

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;
            bool existe = File.Exists(ruta);
            bool verificacion = true;
            try
            {
                using (StreamWriter stream = new StreamWriter(ruta, existe))
                {
                    stream.WriteLine(texto);
                } 
            }
            catch (Exception)
            {
                verificacion = false;
            }
            return verificacion;
        }
        #endregion
    }
}
