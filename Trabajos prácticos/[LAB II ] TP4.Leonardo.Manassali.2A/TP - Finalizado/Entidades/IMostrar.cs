using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMostrar<T>
    {
        #region Metodos
        /// <summary>
        /// Metodo que muestra los datos de un objeto que implementa esta interfaz con un tipo de dato genérico.
        /// </summary>
        /// <param name="elemento">Elemento a mostrar.</param>
        /// <returns></returns>
        string MostrarDatos(IMostrar<T> elemento);
        #endregion
    }
}
