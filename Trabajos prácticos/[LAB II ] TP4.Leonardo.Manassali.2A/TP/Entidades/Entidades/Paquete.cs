using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete
    {
        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Propiedades
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }
        #endregion

        #region Constructores
        public Paquete( string direccionEntrega , string trackingID) 
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Paquete p1 , Paquete p2)
        {
            return true;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return false;
        }
        #endregion

        #region Metodos
        public void MockClicloDeVida()
        {

        }
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return "";
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
        #endregion

        #region Eventos

        #endregion

        #region Enumerados
        public enum EEstado
        {
        }
        #endregion
    }
}
