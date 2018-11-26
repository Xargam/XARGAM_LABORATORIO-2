using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manzana:Fruta
    {
        public string distribuidora;

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo { get { return "Manzana"; } }

        public Manzana() { }

        public Manzana(float peso, ConsoleColor color, string distribuidora)
            :base(peso,color)
        {
            this.distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Distribudora:" + this.distribuidora);
            sb.AppendLine("Tipo: " + this.Tipo);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
