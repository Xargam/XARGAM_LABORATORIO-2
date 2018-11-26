using System.Collections.Generic;

namespace Entidades
{
	public class Grupo
	{
		#region Atributos
		private List<Mascota> _manada;
		private string _nombre;
		private static TipoManada _tipo;
		#endregion

		#region Propiedades
		public TipoManada Tipo
		{
			set => Grupo._tipo = value;
		}
		#endregion

		#region Constructor
		static Grupo()
		{
			Grupo._tipo = TipoManada.Unica;
		}

		private Grupo()
		{
			this._manada = new List<Mascota>();
		}

		public Grupo(string nombre) : this()
		{
			this._nombre = nombre;
		}

		public Grupo(string nombre, TipoManada tipo) : this(nombre)
		{
			Grupo._tipo = tipo;
		}
		#endregion

		#region Operadores

		#region Conversion
		public static implicit operator string(Grupo e)
		{
			string datos = "**" + e._nombre + " " + Grupo._tipo.ToString() + "**\nIntegrantes:\n";
			foreach (Mascota item in e._manada)
			{
				datos += item.ToString();
			}
			return datos;
		}
		#endregion

		#region Comparacion
		public static bool operator !=(Grupo e, Mascota j)
		{
			return !(e == j);
		}

		public static bool operator ==(Grupo e, Mascota j)
		{
			bool verificacion = false;

			foreach(Mascota mascota in e._manada)
			{
				if (object.Equals(mascota,j))
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		#endregion

		#region Aritmetica
		public static Grupo operator +(Grupo e, Mascota j)
		{
			if (e != j)
			{
				e._manada.Add(j);
			}
			return e;
		}

		public static Grupo operator -(Grupo e, Mascota j)
		{
			int indice = 0;

			foreach (Mascota mascota in e._manada)
			{
				if(object.Equals(mascota, j))
				{
					e._manada.RemoveAt(indice);
					break;
				}
				indice++;
			}

			return e;
		}
		#endregion
		#endregion
	}
}
