namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Realiza una de las cuatro operaciones aritméticas entre dos objetos Numero y devuelve el resultado como double.
        /// Si el operador (+ , - , * , /) es erróneo devuelve NaN.
        /// </summary>
        /// <param name="num1">Operando 1.</param>
        /// <param name="num2">Operando 2.</param>
        /// <param name="operador">Operador aritmético en formato string.</param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = double.NaN;
            if (Calculadora.ValidarOperador(operador) == "OK")
            {
                switch (operador)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                }
            }
            return resultado;
        }
        /// <summary>
        /// Verifica que un string contenga un operador aritmético válido para una de las cuatro operaciones básicas:
        /// (+,-,*,/) y retorna "OK". En caso de error devuelve "+" .
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            return (operador != "+" && operador != "-" && operador != "*" && operador != "/")? "+" : "OK" ;
        }
        #endregion
    }
}
