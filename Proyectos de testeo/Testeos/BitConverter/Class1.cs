﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverter
{
    class Jaja : ISerializable<string> , Interface4
    {
        public void Msj(int metodo)
        {
            throw new NotImplementedException();
        }

        void ISerializable<string>.Serializar(object obj)
        {
            throw new NotImplementedException();
        }
    }
}