using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Ejercicio_40_Form
{
	public partial class FrmMostrar : Form
	{
		#region Atributos
		private Llamada.TipoLlamada _tipo;
		private Centralita _centralita;
		#endregion

		#region Propiedades
		public Llamada.TipoLlamada TipoLlamada
		{
			set
			{
				this._tipo = value;
			}
		}

		#endregion
		public FrmMostrar(Centralita centralita)
		{
			InitializeComponent();
			this._centralita = centralita;
			
			
		}

		private void FrmMostrar_Activated(object sender, EventArgs e)
		{
			switch (this._tipo)
			{
				case Llamada.TipoLlamada.Local:
					this.rtxtInfo.Text = string.Format("Ganacias por llamadas locales: {0}.", this._centralita.GananciasPorLocal);
					break;
				case Llamada.TipoLlamada.Provincial:
					this.rtxtInfo.Text = string.Format("Ganacias por llamadas provinciales: {0}.", this._centralita.GananciasPorProvincial);
					break;
				case Llamada.TipoLlamada.Todas:
					this.rtxtInfo.Text = string.Format("Ganacias por llamadas totales: {0}.", this._centralita.GananciasPorTotal);
					break;
			}
		}
	}
}
