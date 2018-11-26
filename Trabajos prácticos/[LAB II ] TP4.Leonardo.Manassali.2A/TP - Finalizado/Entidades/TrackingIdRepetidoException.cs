using System;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {
        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia de TrackingIdRepetidoException con un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar en la excepcion.</param>
        public TrackingIdRepetidoException(string mensaje ) : this(mensaje,null)
        {
        }
        /// <summary>
        /// Inicializa una nueva instancia de TrackingIdRepetidoException con un mensaje personalizado y una InnerException.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar en la excepcion.</param>
        /// <param name="inner">Excepcion interna de esta instancia.</param>
        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje,inner)
        {
        }
        #endregion
    }
}
