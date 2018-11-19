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
        private static SqlCommand _comando;
        private static SqlConnection _conexion;
        #endregion

        #region Constructores
        static PaqueteDAO(  )
        {

        }
        #endregion

        #region Metodos
        public static bool Insertar(Paquete p)
        {
            return true;
        }
        #endregion
    }
}
