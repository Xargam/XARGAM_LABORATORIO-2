using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Cartuchera1 
    {
        #region Atributos
        private List<IAcciones> _obj;
        #endregion

        #region Metodos
        public bool ProbarElementos(List<IAcciones> acciones)
        {
            bool verificacion = true;
            foreach (IAcciones item in acciones)
            {
                item.UnidadesDeEscritura -= 1;
                if (item.UnidadesDeEscritura < 0)
                {
                    verificacion = false;
                    try
                    {
                        item.Recargar(1);
                    }
                    catch (Exception)
                    {
                    }
                    break;
                }
            }
            return verificacion;
        }
        #endregion
    }
}
