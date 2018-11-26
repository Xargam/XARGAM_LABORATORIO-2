using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Platano:Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo { get { return "Platano"; } }

        public Platano() { }

        public Platano(float peso, ConsoleColor color, string pais)
            :base(peso,color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Pais de origen:" + this.paisOrigen);
            sb.AppendLine("Tipo: " + this.Tipo);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
