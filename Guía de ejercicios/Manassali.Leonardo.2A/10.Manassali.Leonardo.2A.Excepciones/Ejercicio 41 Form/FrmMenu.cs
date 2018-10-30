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

namespace Ejercicio_41_Form
{
	public partial class FrmMenu : Form
	{
		public Centralita centralita;

		public FrmMenu()
		{
			InitializeComponent();
			this.centralita = new Centralita();

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnFacturacionProvincial_Click(object sender, EventArgs e)
		{
			FrmMostrar mostrar = new FrmMostrar(this.centralita);
			mostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
			mostrar.ShowDialog();
		}

		private void btnFacturacionLocal_Click(object sender, EventArgs e)
		{
			FrmMostrar mostrar = new FrmMostrar(this.centralita);
			mostrar.TipoLlamada = Llamada.TipoLlamada.Local;
			mostrar.ShowDialog();
		}

		private void btnFacturacionTotal_Click(object sender, EventArgs e)
		{
			FrmMostrar mostrar = new FrmMostrar(this.centralita);
			mostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
			mostrar.ShowDialog();
		}

		private void btnGenerarLlamada_Click(object sender, EventArgs e)
		{
			FrmLlamador llamador = new FrmLlamador(this.centralita);
			llamador.ShowDialog();
			this.centralita = llamador.Centralita;
		}
	}
}
