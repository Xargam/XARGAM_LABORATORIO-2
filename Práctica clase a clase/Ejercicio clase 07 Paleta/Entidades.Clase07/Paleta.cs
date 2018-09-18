namespace Entidades.Clase07
{
	public class Paleta
	{
		#region Atributos

		private Tempera[] _colores;
		private int _cantMaximaElementos;

		#endregion

		#region Indexador

		public Tempera this[int indice]
		{
			set
			{
				if (indice >= 0 && indice < this._cantMaximaElementos)
				{
					this._colores[indice] = value;
				}
			}
			get
			{
				Tempera tempera = null;
				if (indice >= 0 && indice < this._cantMaximaElementos)
				{
					tempera = this._colores[indice];
				}
				return tempera;
			}
		}

		#endregion

		#region Constructor

		private Paleta() : this(5)
		{
		}

		private Paleta(int cantMaximaElementos)
		{
			this._cantMaximaElementos = cantMaximaElementos;
			this._colores = new Tempera[this._cantMaximaElementos];
		}

		#endregion

		#region Sobrecargas

		#region Conversion

		public static implicit operator Paleta(int colores)
		{
			return new Paleta(colores);
		}

		public static explicit operator string(Paleta paleta)
		{
			return paleta.Mostrar();
		}

		#endregion

		#region Comparacion
		public static bool operator ==(Paleta paleta, Tempera tempera)
		{
			bool verify = false;

			for (int i = 0; i < paleta._colores.Length; i++)
			{
				if (paleta._colores.GetValue(i) != null)
				{
					if (paleta._colores[i] == tempera)
					{
						verify = true;
					}
				}
			}
			return verify;
		}

		public static bool operator !=(Paleta paleta, Tempera tempera)
		{
			return !(paleta == tempera);
		}

		#endregion

		#region SumaResta

		public static Paleta operator -(Paleta paleta, Tempera tempera)
		{
			int temperaIndex = paleta.ObtenerIndice(tempera);
			sbyte resta = (sbyte)((sbyte)paleta._colores[temperaIndex] - (sbyte)tempera);

			if (temperaIndex > -1)
			{
				paleta._colores[temperaIndex] = (resta <= 0) ? null : paleta._colores[temperaIndex] + (sbyte)((sbyte)(tempera) * -1);
			}
			return paleta;
		}


		public static Paleta operator +(Paleta paleta, Tempera tempera)
		{
			int temperaIndex;

			if (paleta == tempera)
			{
				temperaIndex = paleta.ObtenerIndice(tempera);
				paleta._colores[temperaIndex] += tempera;
			}
			else
			{
				temperaIndex = paleta.ObtenerIndice();
				if (temperaIndex > -1)
				{
					paleta._colores[temperaIndex] = tempera;
				}

			}
			return paleta;
		}

		#endregion

		#endregion

		#region Metodos

		private string Mostrar()
		{
			string datos = "Cantidad de elementos: " + this._cantMaximaElementos.ToString() + "\r\n";
			for (int i = 0; i < this._colores.Length; i++)
			{
				if (this._colores.GetValue(i) != null)
				{
					datos += this._colores[i] + "\r\n";
				}
			}
			return datos;
		}

		private int ObtenerIndice()
		{
			int verify = -1;

			for (int i = 0; i < this._colores.Length; i++)
			{
				if (this._colores.GetValue(i) == null)
				{
					verify = i;
					break;
				}
			}

			return verify;
		}

		private int ObtenerIndice(Tempera tempera)
		{
			int index = -1;

			for (int i = 0; i < this._colores.Length; i++)
			{
				if (this._colores.GetValue(i) != null)
				{
					if (this._colores[i] == tempera)
					{
						index = i;
					}
				}
			}
			return index;
		}

		#endregion
	}
}
