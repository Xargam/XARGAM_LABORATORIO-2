using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece una cadena que contiene la dirección de entrega asociada a este objeto.
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = (object.Equals(value, null)) ? this.direccionEntrega : value;
            }
        }
        /// <summary>
        /// Obtiene o establece el enumerado EEstado asociado este objeto.
        /// </summary>
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
        /// <summary>
        /// Obtiene o establece una cadena que contiene el TrackingID asociado a este objeto.
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = (object.Equals(value, null)) ? this.trackingID : value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Genera una nueva instancia de la clase Paquete.
        /// </summary>
        /// <param name="direccionEntrega">Cadena con direccion de entrega del objeto.</param>
        /// <param name="trackingID">Cadena con Tracking ID del objeto.</param>
        public Paquete( string direccionEntrega , string trackingID) 
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Define si dos paquetes son iguales comparando su atributo TrackingID.
        /// </summary>
        /// <param name="p1">Objeto paquete 1 a comparar.</param>
        /// <param name="p2">Objeto paquete 2 a comparar.</param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1 , Paquete p2)
        {
            return !object.Equals(p1, null) && !object.Equals(p2, null) && p1.TrackingID == p2.TrackingID;
        }
        /// <summary>
        /// Define si dos paquetes son distintos comparando su atributo TrackingID.
        /// </summary>
        /// <param name="p1">Objeto paquete 1 a comparar.</param>
        /// <param name="p2">Objeto paquete 2 a comparar.</param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Realiza cambios de estados de este paquete cada 4 segundos hasta llegar a entregado. Al finalizar guarda 
        /// el objeto en una base de datos.
        /// </summary>
        public void MockClicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                this.Estado++;
                this.InformaEstado(null,null);
            }
            while ( this.Estado != EEstado.Entregado );
            if( !PaqueteDAO.Insertar(this) )
            {
                this.ServerError();
            }
        }
        /// <summary>
        /// Retorna una cadena que representa a este objeto.
        /// </summary>
        /// <param name="elemento">Paquete u objeto que implementa la interfaz IMostrar para paquetes.</param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return (object.Equals(elemento,null))? "" : string.Format("{0} para {1}\r\n", ((Paquete)elemento).TrackingID , ((Paquete)elemento).DireccionEntrega );
        }
        /// <summary>
        /// Devuelve una cadena que representa a este objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this); 
        }
        #endregion

        //Agregado evento de control de errores de SQL (Habilitado por fragmento de enunciado de PaqueteDAO).
        #region Eventos
        public event DelegadoEstado InformaEstado;
        public event DelegadoSqlError ServerError;
        #endregion

        #region Delegados
        public delegate void DelegadoEstado(object sender, EventArgs e); 
        public delegate void DelegadoSqlError(); 
        #endregion

        #region Enumerados
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
        #endregion
    }
}
