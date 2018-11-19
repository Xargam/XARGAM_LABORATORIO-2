using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverter
{
    interface ISerializable <T>
    {
        void Serializar(object obj);
    }
}
