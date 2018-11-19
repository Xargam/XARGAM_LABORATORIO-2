using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Propiedades
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        #endregion

        #region Constructores
        public Correo()
        {
        }
        #endregion

        #region Operadores
        public static Correo operator +(Correo c ,Paquete p )
        {
            return c;
        }
        #endregion

        #region Metodos
        public void FinEntregas()
        {

        }
        public string MostrarDatos( IMostrar<List<Paquete>> elementos)
        {
            return "";
        }
        #endregion
    }
}
