using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
17. Crear la clase Bolígrafo a partir del siguiente diagrama:
a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
retornarán el valor del mismo).
c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
f. El método Pintar(int, out string) restará la tinta gastada, sin poder quedar el nivel en
negativo, avisando si pudo pintar (nivel de tinta mayor a 0). También informará mediante el
out string tantos "*" como haya podido "gastar" del nivel de tinta. O sea, si nivel de tinta es
10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
g. Utilizar todos los métodos en el Main.
h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
bolígrafo.
*/

namespace Entidades
{
    public class Boligrafo
    {
        #region Atributos

        public short tinta;
        public ConsoleColor color;
        const short cantidadTintaMaxima = 100;

        #endregion

        #region Metodos

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta( short tinta )
        {
            if (tinta <= 100 && tinta >= 0)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void Mostrar(string asteriscos)
        {
            Console.BackgroundColor = this.color;
            Console.WriteLine(asteriscos);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool verify;
            short tintaActual;
            short pintarAsteriscos;

            dibujo = "";
            tintaActual = (short) (this.GetTinta() - gasto);
            this.SetTinta( tintaActual );
            verify = (tintaActual >= 0 ) ? true : false;
            pintarAsteriscos = (tintaActual >= 0) ? gasto : this.GetTinta() ;

            for (int asteriscos = 0; asteriscos < pintarAsteriscos ; asteriscos++)
            {
                dibujo += '*';
            }

            this.Mostrar(dibujo);

            return verify;
        }

        #endregion
    }
}
