using System.Collections.Generic;

namespace Ejercicio_53
{
    public class Cartuchera1
    {
        #region Propiedades
        public List<IAcciones> Acciones
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public Cartuchera1()
        {
            this.Acciones = new List<IAcciones>();
        }
        #endregion

        #region Metodos
        public bool ProbarElementos()
        {
            bool verificacion = true;
            foreach (IAcciones item in this.Acciones)
            {
                item.UnidadesDeEscritura -= 1;
                if ( item.UnidadesDeEscritura < 0)
                {
                    item.UnidadesDeEscritura = 0;
                    verificacion = false;
                    break;
                }
            }
            return verificacion;
        }
        #endregion
    }
}
