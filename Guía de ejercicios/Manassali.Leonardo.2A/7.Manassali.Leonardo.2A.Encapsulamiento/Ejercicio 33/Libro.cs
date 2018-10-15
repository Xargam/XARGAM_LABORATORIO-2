using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
	public class Libro
	{
		#region Atributos
		private List<string> _paginas;
		#endregion

		#region Constructor
		public Libro()
		{
			this._paginas = new List<string>();
		}

		#endregion

		#region Propiedades
		public string this[int i]
		{
			get
			{
				string pagina = "";
				if( i >= 0 && i < this._paginas.Count )
				{
					pagina = this._paginas[i];
				}
				return pagina;
			}
			set
			{
				if( i >= this._paginas.Count)
				{
					this._paginas.Add(value);
				}
				else
				{
					this._paginas[i] = value;
				}
			}
		}
		#endregion
	}
}
