using CentralitaHerencia;
using System;
using System.Windows.Forms;

namespace Ejercicio_41_Form
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
			set => this._tipo = value;
		}

		#endregion

		public FrmMostrar(Centralita centralita)
		{
			InitializeComponent();
			this._centralita = centralita;


		}

		private void FrmMostrar_Activated(object sender, EventArgs e)
		{
			switch ( this._tipo )
			{
				case Llamada.TipoLlamada.Local:
					this.rtxtInfo.Text = string.Format("Costos por llamadas locales: {0}.", this._centralita.GananciasPorLocal);
					break;
				case Llamada.TipoLlamada.Provincial:
					this.rtxtInfo.Text = string.Format("Costos por llamadas provinciales: {0}.", this._centralita.GananciasPorProvincial);
					break;
				case Llamada.TipoLlamada.Todas:
					this.rtxtInfo.Text = string.Format("Costos por llamadas totales: {0}.", this._centralita.GananciasPorTotal);
					break;
			}
		}
	}
}
