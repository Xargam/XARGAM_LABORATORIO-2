using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    where V : IComparable
    {
        #region Metodos
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leido", typeof(V));
        } 
        #endregion
    }
}
