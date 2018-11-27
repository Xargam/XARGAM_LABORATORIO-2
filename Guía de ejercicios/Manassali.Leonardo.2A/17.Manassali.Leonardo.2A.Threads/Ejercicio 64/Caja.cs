using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    public class Caja
    {

        #region Atributos
        private List<string> _filaClientes;
        #endregion

        #region Propiedades
        public List<string> FilaClientes
        {
            get
            {
                return this._filaClientes;
            }
        }
        #endregion

        #region Constructores
        public Caja()
        {
            this._filaClientes = new List<string>();
        }
        #endregion

        #region Metodos
        public void AtenderClientes()
        {
            foreach (string item in this.FilaClientes)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

    }
}
