using System;
using System.Text;

/*
16. Crear la clase Alumno de acuerdo al siguiente diagrama:
a.Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main.Colocarle
nombre, apellido y legajo a cada uno de ellos.
b.Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado".
*/

namespace Ejercicio_16
{
	public class Alumno
	{
		#region Atributos

		private byte _nota1;
		private byte _nota2;
		private float _notaFinal;

		public string nombre;
		public string apellido;
		public int legajo;

		#endregion

		#region Metodos

		public void CalcularFinal()
		{
			this._notaFinal = -1;
			if (this._nota1 >= 4 && this._nota2 >= 4)
			{
				Random random = new Random();
				this._notaFinal = random.Next(1,11);
			}
		}

		public void Estudiar(byte nota1, byte nota2)
		{
			if( nota1 >= 1 && nota1 <= 10 )
			{
				this._nota1 = nota1;
			}
			if ( nota2 >= 1 && nota2 <= 10 )
			{
				this._nota2 = nota2;
			}
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder();

			this.CalcularFinal();
			datos.AppendLine("----");
			datos.AppendFormat("Legajo: {0}\r\n", this.legajo);
			datos.AppendFormat("Nombre: {0}\r\n", this.nombre);
			datos.AppendFormat("Apellido: {0}\r\n", this.apellido);
			datos.AppendFormat("Nota 1: {0}\r\n", this._nota1);
			datos.AppendFormat("Nota 2: {0}\r\n", this._nota2);
			datos.AppendFormat("Nota final: {0}",(this._notaFinal == -1)? "Alumno desaprobado." : this._notaFinal.ToString() );
			return datos.ToString();
		}

		#endregion

	}
}
