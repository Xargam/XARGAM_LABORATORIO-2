using System;

namespace Entidades
{
    public class Numero
    {
        #region Atributos y propidades

        private double _numero;
        private string SetNumero
        {
            set
            {
                double numero = this.ValidarNumero(value);
                if (numero != 0)
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
            return (n2._numero != 0) ? n1._numero / n2._numero : Double.NaN;
        }

        #endregion

        #region Metodos

        #region Conversion numerica

        public string BinarioDecimal(string binario)
        {
            string numero = (binario.Length == 0)? "Valor invalido" : "0";
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    numero = "Valor invalido";
                    break;
                }
            }
            if (numero != "Valor invalido")
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    numero = (binario.Substring(i, 1) == "1") ? (Double.Parse(numero) + Math.Pow(2, binario.Length - i - 1)).ToString() : numero;
                    
                    if (!int.TryParse(numero,out int unused))
                    {
                        numero = "Valor invalido";
                        break;
                    }
                }
            }
            return numero;
        }

        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        public string DecimalBinario(string numero)
        {
            string binario = "Valor invalido";
            int numeroDecimal;
            if (int.TryParse(numero, out numeroDecimal) && numeroDecimal >= 0)
            {
                binario = (numeroDecimal == 0) ? "0" : "1";
                while (numeroDecimal > 1)
                {
                    binario = binario.Insert(1, (numeroDecimal % 2).ToString());
                    numeroDecimal /= 2;
                }
            }
            return binario;
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
