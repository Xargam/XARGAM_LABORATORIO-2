using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    public class Serializar<S, V> : IGuardar<S, V> , IFormatProvider
    where V : IComparable
    {
        public object GetFormat(Type formatType)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(S obj)
        {
            return true;
        }
        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto Leido",typeof(V));
        }
    }
}
