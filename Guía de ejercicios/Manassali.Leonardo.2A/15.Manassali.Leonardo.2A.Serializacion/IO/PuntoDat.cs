using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        #region Atributos
        private string _contenido;
        #endregion

        #region Propiedades
        public string Contenido
        {
            get 
            {
                return this._contenido;
            }
            set
            {
                this._contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            if (this.ValidarArchivo(ruta, true))
            {
                this.GuardarComo(ruta, objeto);
            }
            return true;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            if (this.ValidarArchivo(ruta, false))
            {
                FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate);
                BinaryFormatter binario = new BinaryFormatter();
                binario.Serialize(archivo, objeto.Contenido);
                archivo.Close();
            }          
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat dat = new PuntoDat();
            if (this.ValidarArchivo(ruta, true))
            {
                BinaryFormatter binario = new BinaryFormatter();
                FileStream archivo = new FileStream(ruta, FileMode.Open);
                dat.Contenido = (string)binario.Deserialize(archivo);
                archivo.Close();
            }
            return dat;
        }
        #endregion

        #region Metodos


        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            FileNotFoundException posibleExcepcion = null;
            string mensaje = "El archivo no es un .dat";
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
            if (!object.Equals(posibleExcepcion, null) || !ruta.EndsWith(".dat"))
            {
                throw new ArchivoIncorrectoException(mensaje, posibleExcepcion);
            }
            return true;
        }
        #endregion
    }
}
