using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaLibreria
{
	public class Centralita : IGuardar<string>
	{
		#region Atributos
		private List<Llamada> _listaDeLlamadas;
		protected string _razonSocial;
		#endregion

		#region Propiedades
		public float GananciasPorLocal
		{
			get
			{
				return this.CalcularGanancia(Llamada.TipoLlamada.Local);
			}
		}
		public float GananciasPorProvincial
		{
			get
			{
				return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
			}
		}
		public float GananciasPorTotal
		{
			get
			{
				return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
			}
		}
		public List<Llamada> Llamadas
		{
			get
			{
				return this._listaDeLlamadas;
			}
		}

        public string RutaDelArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Constructor
        public Centralita()
		{
			this._listaDeLlamadas = new List<Llamada>();
		}
		public Centralita(string nombreEmpresa) : this()
		{
			this._razonSocial = nombreEmpresa;
		}
		#endregion

		#region Operadores

		#region Aritmetica
		public static Centralita operator +(Centralita c , Llamada nuevaLlamada)
		{
			if( c != nuevaLlamada)
			{
				c.AgregarLlamada(nuevaLlamada);
			}
			else
			{
				throw new CentralitaException("Se intento agregar un elemento clonado a lista.", nuevaLlamada.GetType().Name, "public static Centralita operator +(Centralita,Llamada){...}");
			}
			return c;
		}
		#endregion

		#region Comparacion
		public static bool operator ==(Centralita c, Llamada llamada)
		{
			bool verificacion = false;
			foreach (Llamada item in c.Llamadas)
			{
				if (item == llamada)
				{
					verificacion = true;
					break;
				}
			}
			return verificacion;
		}
		public static bool operator !=(Centralita c, Llamada llamada)
		{
			return !(c == llamada);
		} 
		#endregion

		#endregion

		#region Metodos
		private void AgregarLlamada(Llamada nuevaLlamada)
		{
			this.Llamadas.Add(nuevaLlamada);
		}
		public override string ToString()
		{
			return this.Mostrar();
		}
		private string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendFormat("Razon social: {0}\n", this._razonSocial);
			datos.AppendFormat("Ganancia total: {0}\n", this.GananciasPorTotal);
			datos.AppendFormat("Ganancia locales: {0}\n", this.GananciasPorLocal);
			datos.AppendFormat("Ganancia provinciales: {0}\n\n", this.GananciasPorProvincial);
			foreach (Llamada item in this.Llamadas)
			{
				datos.AppendLine(item.ToString());
			}
			return datos.ToString();
		}
		public void OrdenarLlamadas()
		{
			this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
		}
		private float CalcularGanancia(Llamada.TipoLlamada tipo)
		{
			float precio = 0;
			float precioLocalTotal = 0;
			float precioProvincialTotal = 0;

			foreach (Llamada item in this.Llamadas)
			{
				if( item is Local)
				{
					precioLocalTotal += item.CostoLlamada;
				}
				else if( item is Provincial )
				{
					precioProvincialTotal += item.CostoLlamada;
				}
			}

			switch (tipo)
			{
				case Llamada.TipoLlamada.Local:
					precio = precioLocalTotal;
					break;
				case Llamada.TipoLlamada.Provincial:
					precio = precioProvincialTotal;
					break;
				case Llamada.TipoLlamada.Todas:
					precio = precioLocalTotal + precioProvincialTotal;
					break;
			}
			return precio;
		}

        public bool Guardar()
        {
            this.ToString();
            return true;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
