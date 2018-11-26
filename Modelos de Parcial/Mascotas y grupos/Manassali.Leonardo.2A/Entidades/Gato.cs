using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class Gato : Mascota
	{
		#region Constructor
		public Gato(string nombre, string raza) : base(nombre, raza)
		{

		}
		#endregion

		#region Operadores
		public static bool operator !=(Gato obj1, Gato obj2)
		{
			return !(obj1 == obj2);
		}

		public static bool operator ==(Gato obj1, Gato obj2)
		{
			return obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza;
		}
		#endregion
		#region Metodos
		protected override string Ficha()
		{
			return "Gato:\n" + base.DatosCompletos() + "\n";
		}

		public override bool Equals(object obj)
		{
			return (obj is Gato) ? (Gato)obj == this : false;
		}

		public override string ToString()
		{
			return this.Ficha();
		}
		#endregion
	}
}
