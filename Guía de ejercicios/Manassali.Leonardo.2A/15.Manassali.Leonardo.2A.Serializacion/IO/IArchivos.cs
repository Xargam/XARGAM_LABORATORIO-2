using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public interface IArchivos<T>
    {
        #region Metodos
        bool Guardar(string ruta, T objeto);
        bool GuardarComo(string ruta, T objeto);
        T Leer(string ruta);
        #endregion
    }
}
