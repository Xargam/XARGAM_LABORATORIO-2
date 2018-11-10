using System.Collections.Generic;

namespace Ejercicio_53
{
    public class Cartuchera2
    {
        #region Propiedades
        public List<Boligrafo> Boligrafos
        {
            get;
            set;
        }
        public List<Lapiz> Lapices
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public Cartuchera2()
        {
            this.Lapices = new List<Lapiz>();
            this.Boligrafos = new List<Boligrafo>();
        }
        #endregion

        #region Metodos
        public bool ProbarElementos()
        {
            bool verificacion = true;
            foreach (Boligrafo item in this.Boligrafos)
            {
                item.UnidadesDeEscritura -= 1;
                if (item.UnidadesDeEscritura < 0)
                {
                    verificacion = false;
                    item.UnidadesDeEscritura = 0;
                    break;
                }
            }
            if (verificacion)
            {
                foreach (Lapiz item in this.Lapices)
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                    if (((IAcciones)item).UnidadesDeEscritura < 0)
                    {
                        ((IAcciones)item).UnidadesDeEscritura = 0;
                        verificacion = false;
                        break;
                    }
                }
            }
            return verificacion;
        }
        #endregion
    }
}
