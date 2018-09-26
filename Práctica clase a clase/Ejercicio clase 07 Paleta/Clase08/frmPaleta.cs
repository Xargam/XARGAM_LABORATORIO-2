using Entidades.Clase07;
using System;
using System.Windows.Forms;

namespace Clase08
{
	public partial class FrmPaleta : Form
	{
		private Entidades.Clase07.PaletaColeccion _paleta;

		public FrmPaleta()
		{
			InitializeComponent();
			this._paleta = 5;
			this.grpColores.Text = "Paleta de colores";
			this.txtColores.Multiline = true;
			this.grpColores.Visible = false;
			this.txtColores.Visible = false;
			this.btnMas.Text = "+";
			this.btnMenos.Text = "-";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtColores.Visible = true;
			this.grpColores.Visible = true;
			this.txtColores.Text = (string)this._paleta;
			this.agregarPaletaToolStripMenuItem.Enabled = false;
		}

		private void btnMas_Click(object sender, EventArgs e)
		{
			FrmTempera colores = new FrmTempera();
			if (colores.ShowDialog() == DialogResult.OK )
			{
				this.txtColores.Clear();
				this._paleta += colores.Tempera;
				txtColores.Text += (string)this._paleta;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnMenos_Click(object sender, EventArgs e)
		{
			string seleccionado = this.txtColores.SelectedText;
			int indice = -1;
			FrmTempera frmTempera = new FrmTempera();
		
			foreach (string tempera in this.txtColores.Lines)
			{
				if (seleccionado != string.Empty && seleccionado == tempera && indice > -1)
				{
					if (frmTempera.ShowDialog() == DialogResult.OK)
					{
						if (this._paleta[indice] == frmTempera.Tempera)
						{
							this._paleta[indice] += (sbyte)((-1)*((sbyte)frmTempera.Tempera));
						}
						else
						{
							this._paleta[indice] = null;
						}
						this.txtColores.Clear();
						this.txtColores.Text = (string)this._paleta;
						break;
					}
				}
				indice++;
			}
		}
	}
}
