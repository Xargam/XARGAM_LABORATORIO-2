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
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.Items.Add("Por color (A-Z)");
			this.comboBox1.Items.Add("Por marca (A-Z)");
			this.comboBox1.Items.Add("Por cantidad (Ascendente)");
			this.comboBox1.Items.Add("Por cantidad (Descendente)");
			this.comboBox1.SelectedItem = "Por marca (A-Z)";
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
						this._paleta -= frmTempera.Tempera;
						this.txtColores.Text = (string)this._paleta;
						break;
					}
				}
				indice++;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnOrdenar_Click(object sender, EventArgs e)
		{
			switch(this.comboBox1.SelectedItem)
			{
				case "Por color (A-Z)":
					for (int i = 0; i < 4; i++)
					{
						for (int j = 0; j < 5; j++)
						{
							if( string.Compare(this._paleta[j],,true) this._paleta[j] )
						}
					}
					break;
				case "Por marca (A-Z)":
					break;
				case "Por cantidad (Ascendente)"):
					break;
				case "Por cantidad (Descendente)":
					break;
			}
		}
	}
}
