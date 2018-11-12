using System;
using System.IO;
using System.Text;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        #region Metodos

        #region IArchivos
        public bool Guardar(string ruta, string objeto)
        {
            if( this.ValidarArchivo(ruta, true) )
            {
                this.GuardarComo(ruta, objeto);
            }
            return true;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            if (ValidarArchivo(ruta,false))
            {
                StreamWriter archivo = new StreamWriter(ruta,false,Encoding.Default);
                archivo.WriteLine(objeto);
                archivo.Close();
            }
            return true;
        }

        public string Leer(string ruta)
        {
            string data = "";
            if (this.ValidarArchivo(ruta, true))
            {
                StreamReader archivo = new StreamReader(ruta,Encoding.Default);
                data = archivo.ReadToEnd();
                archivo.Close();
            }
            return data;
        }
        #endregion

        #region Propios
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            FileNotFoundException posibleExcepcion = null;
            string mensaje = "El archivo no es un .txt";

            if (validaExistencia)
            {
                try
                {
                    base.ValidarArchivo(ruta, true);
                }
                catch (FileNotFoundException e)
                {
                    posibleExcepcion = e;
                    mensaje = "El archivo no es correcto.";
                }
            }
            if (!object.Equals(posibleExcepcion, null) || !ruta.EndsWith(".txt"))
            {
                throw new ArchivoIncorrectoException(mensaje, posibleExcepcion);
            }
            return true;
        }
        #endregion

        #endregion
    }
}
