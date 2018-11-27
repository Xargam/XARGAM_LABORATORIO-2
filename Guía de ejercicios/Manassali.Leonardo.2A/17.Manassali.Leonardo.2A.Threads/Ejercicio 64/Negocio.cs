using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    public class Negocio
    {
        #region Atributos
        private Caja _caja1;
        private Caja _caja2;
        private List<string> _clientes;
        #endregion

        #region Propiedades
        public List<string> Clientes
        {
            get
            {
                return this._clientes;
            }
        }
        public Caja Caja1
        {
            get
            {
                return this._caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this._caja2;
            }
        }
        #endregion

        #region Constructores
        public Negocio(Caja c1 , Caja c2)
        {
            this._clientes = new List<string>();
            this._caja1 = c1;    
            this._caja1 = c2;    
        } 
        #endregion
       
        #region Metodos
        public void AsignarCaja()
        {

        } 

        #endregion
    }
}
