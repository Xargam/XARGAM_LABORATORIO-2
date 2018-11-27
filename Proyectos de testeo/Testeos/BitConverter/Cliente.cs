using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverter
{
    public abstract class Cliente
    {
        protected int _atributo1 = 1;
        protected int _atributo2 = 2;
        protected int _atributo3 = 3;
        public  abstract void ImprimirText(string nombre , bool append );
    }
}
