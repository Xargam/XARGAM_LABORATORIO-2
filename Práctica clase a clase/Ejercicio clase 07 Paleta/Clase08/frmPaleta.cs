using Entidades.Clase07;
using System;
using System.Text;
using System.Collections.Generic;
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
			StringBuilder sb = new StringBuilder();
			string[] lineas = this.txtColores.Lines;

			List<string> marcas = new List<string>();
			List<string> colores = new List<string>();
			List<sbyte> cantidades = new List<sbyte>();

			
			for (int i = 0; i < lineas.Length; i++)
			{
				if(i > 0)
				{
					
					/*
					cantidades.Add(0);

					sb.AppendLine(lineas[i]);
					sb.AppendFormat("Marca: {0}   Color: {1}   Cantidad: {2}", marcas[i-1], colores[i-1], cantidades[i-1]);
					sb.Clear();*/
				}
			}
			switch(this.comboBox1.SelectedItem)
			{
				case "Por color (A-Z)":
					this.comboBox1.Text = marcas[0];
					break;
				case "Por marca (A-Z)":
					break;
				case "Por cantidad (Ascendente)":
					break;
				case "Por cantidad (Descendente)":
					break;
			}
		}
	}
}
