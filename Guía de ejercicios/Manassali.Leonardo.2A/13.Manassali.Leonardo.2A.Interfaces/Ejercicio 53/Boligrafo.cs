using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Boligrafo : IAcciones
    {
        #region Atributos
        private ConsoleColor _colorTinta;
        private float _tinta;
        #endregion

        #region Propiedades
        public ConsoleColor Color
        {
            get
            {
                return this._colorTinta;
            }
            set
            {
                this._colorTinta = value;
            }

        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this._tinta;
            }
            set
            {
                this._tinta = (value > 0)? value : 0;
            }
        }
        #endregion

        #region Constructor
        public Boligrafo(int unidades , ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = (unidades > 0)? unidades : 0 ;
        }
        #endregion


        #region Metodos
        public EscrituraWrapper Escribir(string texto)
        {
            string escritura = "";
            while (texto.Length > 0 && (decimal)this.UnidadesDeEscritura - 0.3M >= 0)
            {
                this.UnidadesDeEscritura = (float)((decimal)this.UnidadesDeEscritura - 0.3M);
                escritura += texto.Substring(0, 1);
                texto = texto.Remove(0,1);
            }
            return new EscrituraWrapper(escritura, this.Color);
        }

        public bool Recargar(int unidades)
        {
            bool verificacion = this.UnidadesDeEscritura + unidades >= 0;
            if (verificacion)
            {
                this.UnidadesDeEscritura += unidades;
            }
            return verificacion;
        }

        public override string ToString()
        {
            return "Boligrafo:\r\n" + "Color: " + this.Color + "\r\nTinta: " + this.UnidadesDeEscritura;
        }

        #endregion


    }
}
