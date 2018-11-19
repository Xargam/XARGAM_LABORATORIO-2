using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverter
{
    class Class2 : ISerializable<string>
    {
        void ISerializable<String>.Serializar(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
