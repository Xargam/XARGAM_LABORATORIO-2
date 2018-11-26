using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        #region Atributos
        private Correo correo;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia del formulario. Establece el evento para el funcionamiento e instancia atributo
        /// correo.
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
            this.FormClosing += new FormClosingEventHandler(this.FrmPpal_FormClosing);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Detecta cuando el formulario se va a cerrar y antes de ello cierra los hilos generados por los paquetes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
        /// <summary>
        /// Muestra un mensaje de error acorde a un error de conexion a base de datos.
        /// </summary>
        private void SqlError()
        {
            MessageBox.Show("Carga errónea. Fallo durante conexión con la base de datos de paquetes.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Limpia los listBox del formulario y carga los paquetes nuevamente donde correspondan.
        /// </summary>
        private void ActualizarEstados()
        {
            this.lstEstadoEntregado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoIngresado.Items.Clear();
            foreach (Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }
        /// <summary>
        /// Agrega un paquete a la lista del formulario y actualiza los estados. Lo carga en una base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
            paquete.InformaEstado += new Paquete.DelegadoEstado(this.paq_InformaEstado);
            paquete.ServerError += new Paquete.DelegadoSqlError(this.SqlError);
            try
            {
                this.correo += paquete;
            }
            catch (TrackingIdRepetidoException excepcion)
            {
                MessageBox.Show(excepcion.Message,"Paquete repetido",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            this.ActualizarEstados();
        }
        /// <summary>
        /// Muestra los paquetes en el cuadro inferior izquierdo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)this.correo);
        }
        /// <summary>
        /// Carga los datos de un objeto recibido al cuadro inferior izquierdo y guarda un archivo txt con información
        /// en el escritorio.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento )
        {
            bool error = false;
            if ( !object.Equals(elemento , null))
            {
                string datos = elemento.MostrarDatos(elemento);
                this.rtbMostrar.Text = datos;
                if ( !datos.Guardar("salida.txt") )
                {
                    error = true;
                }
                
            }
            if (error)
            {
                MessageBox.Show("Se produjo un error durante la manipulación del fichero de salida.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  Muestra informacion de un elemento en particular de lstEntregados en el recuadro izquierdo inferior. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        /// <summary>
        /// Verifica los subprocesos y actualiza los estados de los listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }
        #endregion
    }
}
