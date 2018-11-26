using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;//new
using System.IO;//new

namespace Entidades
{
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]

    public abstract class Fruta
    {
        #region Atributos
        protected ConsoleColor _color;
        protected float _peso;
        #endregion
        public Fruta() { }
        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }
        public abstract bool TieneCarozo { get; }

        protected virtual string FrutaToString()
        {
            return "Color: " + this._color.ToString() + "\nPeso: " + this._peso.ToString();
        }
    }
}
