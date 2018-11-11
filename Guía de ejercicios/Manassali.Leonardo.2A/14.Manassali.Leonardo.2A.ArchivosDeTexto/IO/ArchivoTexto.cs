using System;
using System.IO;
using IO;

namespace IO
{
    public class ArchivoTexto
    {
        #region Metodos
        public static bool Guardar(string path, string data)
        {
            bool exito = true;
            try
            {
                StreamWriter archivo = new StreamWriter(path);
                archivo.WriteLine(data);
                archivo.Close();

            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }
        public static string Leer(string path)
        {
            string data;
            try
            {
                StreamReader archivo = new StreamReader(path);
                data = archivo.ReadToEnd();
                archivo.Close();
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("No se encontró el archivo.", e);
            }
            return data;
        }
        #endregion
    }
}
