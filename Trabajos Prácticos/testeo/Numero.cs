using System;

namespace TP_1___Laboratorio_II
{
    public class Numero
    {
        #region AtributosYPropidades

        public double _numero;
        private string SetNumero
        {
            set
            {
                double numero = this.ValidarNumero(value);
                if ( numero != 0 )
                {
                    this._numero = numero;
                }
                
            }
        }

        #endregion

        #region Constructor

        public Numero()
        {
            this._numero = 0;
        }

        public Numero(double numero) : this(numero.ToString())
        {
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Sobrecargas

        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }

        #endregion

        #region Metodos

        #region ConversionNumerica

        /*public static double BinarioDecimal(string binario)
        {
            int indicePunto;
            int exponente;
            double numeroDecimal = 0;
            bool negativo = false;
            for (int i = 0; i < numero.Length; i++)
            {
                digito = numero.Substring(i, 1);
                if (digito != "0" && digito != "1")
                {
                    break;
                }
                else if (i == numero.Length - 1)
                {
                    verificacion = double.Parse(numero);
                }
            }

            negativo = binario.StartsWith("-");
            binario = (negativo == true) ? binario.Remove(0, 1) : binario;
            indicePunto = binario.IndexOf(',');
            indicePunto = (indicePunto == -1) ? binario.IndexOf('.') : indicePunto;
            indicePunto = (indicePunto == -1) ? binario.Length : indicePunto;
            binario = (indicePunto < binario.Length) ? binario.Remove(indicePunto, 1) : binario;
            exponente = (indicePunto == -1) ? binario.Length - 1 : indicePunto - 1;
            for (int indice = 0; indice < binario.Length; exponente--, indice++)
            {
                if (binario.Substring(indice, 1) == "1")
                {
                    numeroDecimal += Math.Pow(2, exponente);
                }
            }
            if (negativo == true)
            {
                numeroDecimal *= -1;
            }
            return numeroDecimal;
        }*/

        public string DecimalBinario(double numero)
        {
            string binario = "";
            long parteEntera = (long)Math.Abs(numero);
            double parteDecimal = (double)((decimal)Math.Abs(numero) - (decimal)parteEntera);

            binario += (parteEntera == 0) ? "0" : "1";
            binario += (parteDecimal > 0) ? "," : "";
            while (parteEntera > 1)
            {
                binario = binario.Insert(1, (parteEntera % 2).ToString());
                parteEntera /= 2;
            }
            for (int index = 0; index < 3 && parteDecimal > 0; index++)
            {
                parteDecimal *= 2;
                binario += (parteDecimal >= 1) ? "1" : "0";
                parteDecimal = (parteDecimal >= 1) ? parteDecimal - 1 : parteDecimal;
            }
            binario = (numero >= 0) ? binario : binario.Insert(0, "-");
            return binario;
        }

        public string DecimalBinario(string numero)
        {
            return numero;
        }

        #endregion

        #region Validacion

        private double ValidarNumero(string numero)
        {
            double verificacion = 0;
            Double.TryParse(numero, out verificacion);
            return verificacion;
        }

        #endregion

        #endregion
    }
}
