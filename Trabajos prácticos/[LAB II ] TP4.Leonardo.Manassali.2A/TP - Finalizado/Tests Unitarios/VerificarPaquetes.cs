using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests_Unitarios
{
    [TestClass]
    public class VerificarPaquetes
    {
        /// <summary>
        /// Verifica que la lista de paquetes de la clase Correo sea correctamente instanciada.
        /// </summary>
        [TestMethod]
        public void VerificarListaDePaquetesEnCorreo()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes, "La lista de paquetes de la instancia de Correo no se inicializó correctamente.");
        }
        /// <summary>
        /// Verifica que no se puedan cargar paquetes con el mismo TrackingID.
        /// </summary>
        [TestMethod]
        public void VerificarCargaPaquetes()
        {
            bool seProdujoLaExcepcion = false;
            Correo correo = new Correo();
            Paquete pq1 = new Paquete("lio@yopmail.com", "142");
            Paquete pq2 = new Paquete("litio@yahoo.com", "142");

            try
            {
                correo += pq1;
                correo += pq2;
            }
            catch (TrackingIdRepetidoException)
            {
                seProdujoLaExcepcion = true;
            }
            Assert.IsTrue(seProdujoLaExcepcion, "No se produjo la excepción esperada al intentar agregar dos paquetes con el " +
                "mismo TrackingID.");
        }

    }
}
