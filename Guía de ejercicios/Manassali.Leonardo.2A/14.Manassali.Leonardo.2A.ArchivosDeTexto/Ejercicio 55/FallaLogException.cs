using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_55
{
    public class FallaLogException : Exception
    {
        private const string _mensajePorDefecto = "Se produjo un error al guardar log.";
        #region Constructor
        public FallaLogException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
        public FallaLogException(Exception innerException ) : this("Se produjo un error al guardar log.",innerException)
        {

        }
        public FallaLogException(string mensaje) : this(mensaje,null)
        {

        }
        public FallaLogException() : this(_mensajePorDefecto)
        {

        }
        #endregion
    }
}
