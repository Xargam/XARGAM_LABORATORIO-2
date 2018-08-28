using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a.valor: dato a validar
b.min y max: rango en el cual deberá estar la variable valor
*/

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool verificacion = false;
            if( valor >= min && valor <= max )
            {
                verificacion = true;
            }
            return verificacion;
        }
    }
}
