using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaLibreria
{
    public interface IGuardar<T>
    {
        #region Propiedades
        string RutaDelArchivo { get; set; }
        #endregion
        #region Metodos
        bool Guardar();
        T Leer();
        #endregion
    }
}
