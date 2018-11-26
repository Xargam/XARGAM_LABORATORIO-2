using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la lista de paquetes asociada al correo.
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = ( object.Equals(value, null)  )? this.paquetes : value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Genera una nueva instancia de la clase correo.
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Agrega un paquete al correo si es que este no se encuentra en el mismo. En caso de intentar agregar 
        /// un elemento repetido lanza una excepcion.
        /// </summary>
        /// <param name="c">Objeto de tipo correo donde agregar paquete.</param>
        /// <param name="p">Objeto de tipo paquete a agregar al correo.</param>
        /// <returns>Devuelve el objeto correo.</returns>
        public static Correo operator +(Correo c ,Paquete p )
        {
            if (!object.Equals(c, null) && !object.Equals(p, null))
            {
                foreach (Paquete item in c.Paquetes)
                {
                    if (item == p)
                    {
                        throw new TrackingIdRepetidoException(string.Format("El Tracking ID {0} ya figura en la lista de envios.", p.TrackingID));
                    }
                }
                c.Paquetes.Add(p);
                Thread ciclo = new Thread(p.MockClicloDeVida);
                c.mockPaquetes.Add(ciclo);
                ciclo.Start();
            }
            return c;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Cierra todos los hilos generados por los paquetes.
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }
        /// <summary>
        /// Retorna una cadena de caracteres que representa a este objeto Correo.
        /// </summary>
        /// <param name="elementos">Correo u objeto que implementa la interfaz IMostrar para una lista de paquetes.</param>
        /// <returns>Devuelve un string.</returns>
        public string MostrarDatos( IMostrar<List<Paquete>> elementos)
        {
            string datos = "";
            if ( !object.Equals(elementos,null) )
            {
                foreach (Paquete item in ((Correo)elementos).Paquetes)
                {
                    datos += string.Format("{0} para {1} ({2})\r\n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString());
                }
            }
            return datos;
        }
        #endregion
    }
}
