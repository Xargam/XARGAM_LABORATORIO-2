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
        string MotsrarDatos(IMostrar<T> elemento);
        #endregion
    }
}
