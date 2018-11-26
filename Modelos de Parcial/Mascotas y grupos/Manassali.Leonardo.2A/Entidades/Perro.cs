namespace Entidades
{
	public class Perro : Mascota
	{
		#region Atributos
		private int _edad;
		private bool _esAlfa;
		#endregion

		#region Propiedades
		public int Edad
		{
			set => this._edad = value;
			get => this._edad;
		}

		public bool EsAlfa
		{
			set => this._esAlfa = value;
			get => this._esAlfa;
		}
		#endregion

		#region Constructor
		public Perro(string nombre, string raza) : base(nombre, raza)
		{
			this._esAlfa = false;
			this._edad = 0;
		}

		public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
		{
			this._edad = edad;
			this._esAlfa = esAlfa;
		}
		#endregion

		#region Sobrecargas

		#region Conversion
		public static explicit operator int(Perro perro)
		{
			return perro.Edad;
		}
		#endregion

		#region Comparacion
		public static bool operator !=(Perro j1, Perro j2)
		{
			return !(j1 == j2);
		}

		public static bool operator ==(Perro j1, Perro j2)
		{
			return j1.Edad == j2.Edad && j1.Raza == j2.Raza && j1.Nombre == j2.Nombre;
		}
		#endregion
		#endregion

		#region Metodos
		protected override string Ficha()
		{
			string ficha = "Perro:\n" + base.DatosCompletos();
			ficha += (this._esAlfa) ? string.Format(", alfa de la manada, edad {0}\n", this.Edad) : string.Format("edad {0}\n", this.Edad);
			return ficha;
		}

		public override bool Equals(object obj1)
		{
			return (obj1 is Perro) ? (Perro)obj1 == this : false;
		}

		public override string ToString()
		{
			return this.Ficha();
		}
		#endregion
	}
}
