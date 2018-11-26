using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos
        private static SqlCommand comando;
        private static SqlConnection conexion;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa los atributos de la clase a fin de prepararse para conectar con una base de datos.
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.correo_sp_2017);
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = CommandType.Text;
            PaqueteDAO.comando.Connection = conexion;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega el paquete pasado por parámetro a la base de datos.
        /// </summary>
        /// <param name="p">Paquete a agregar a la base de datos.</param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            bool verificacion = true;
            try
            {
                PaqueteDAO.comando.CommandText = String.Format("INSERT INTO [correo-sp-2017].[dbo].[Paquetes] " +
                    "(direccionEntrega,trackingID,alumno) VALUES ('{0}','{1}','{2}')",p.DireccionEntrega,p.TrackingID,"Leonardo Manassali");
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                verificacion = false;
            }
            finally
            {
                try
                {
                    PaqueteDAO.conexion.Close();
                }
                catch (Exception)
                {
                    verificacion = false;
                }
                
            }
            return verificacion;
        }
        #endregion
    }
}
