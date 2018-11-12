using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        #region Metodos
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia && !File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            return true;
        }
        #endregion
    }
}
