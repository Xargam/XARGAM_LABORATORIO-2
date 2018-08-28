using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor
*/

namespace Datos
{
    public static class ValidarRespuesta
    {
        public static bool ValidarSiNo(char c)
        {
            bool verificacion = false;
            c = Char.ToLower(c);
            if( c == 's')
            {
                verificacion = true;
            }
            return verificacion;
        }
    }
}
