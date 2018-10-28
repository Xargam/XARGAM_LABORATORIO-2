using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
17. Crear la clase Bolígrafo a partir del siguiente diagrama:
a.La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
b.Generar los métodos GetColor y GetTinta para los correspondientes atributos(sólo
retornarán el valor del mismo).
c.Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
i.tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo
(gastar tinta)
ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
0 y menor o igual a cantidadTintaMaxima.
d.Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
e.En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
f.El método Pintar(int, out string) restará la tinta gastada(reutilizar código SetTinta), sin
poder quedar el nivel en negativo, avisando si pudo pintar(nivel de tinta mayor a 0).
También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
tinta.O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
10 "***".
g.Utilizar todos los métodos en el Main.
h.Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
bolígrafo.
Nota: Crear el constructor que crea conveniente. La clase Boligrafo y el Program deben estar en
namespaces distintos.
*/

namespace Entidades
{
	public class Boligrafo
	{
		#region Atributos

		const short cantidadTintaMaxima = 100;
		private ConsoleColor _color;
		private short _tinta;

		#endregion

		#region Constructor

		public Boligrafo( short tinta , ConsoleColor color )
		{
			this.SetTinta(tinta);
			this._color = color;
		}

		#endregion

		#region Metodos

		public short GetTinta()
		{
			return this._tinta;
		}

		public ConsoleColor GetColor()
		{
			return this._color;
		}

		private void SetTinta(short tinta)
		{
			short nuevoNivelTinta = (short)(this.GetTinta() + tinta);

			if ( nuevoNivelTinta < 0)
			{
				this._tinta = 0;
			}
			else if (nuevoNivelTinta > cantidadTintaMaxima)
			{
				this._tinta = cantidadTintaMaxima;
			}
			else
			{
				this._tinta += tinta;
			}
			
		}

		public void Recargar()
		{
			this.SetTinta(cantidadTintaMaxima);
		}

		public bool Pintar(int gasto, out string dibujo)
		{
			bool verify = (this.GetTinta() - gasto >= 0);

			dibujo = "";
			for (int i = 0; i < gasto && this.GetTinta() > 0; i++)
			{
				if( i == 0)
				{
					Console.BackgroundColor = GetColor();
				}
				dibujo += '*';
				this.SetTinta(-1);
			}
			return verify;
		} 

		#endregion


	}
}
