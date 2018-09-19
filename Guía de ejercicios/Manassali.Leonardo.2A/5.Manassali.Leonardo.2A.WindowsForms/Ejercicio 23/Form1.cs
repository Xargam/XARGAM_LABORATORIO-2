using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio_23
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			Euro euro = new Euro(1, 0.85741F);
			Peso peso = new Peso(1, 39.7036F);
			InitializeComponent();
		}

		private void btnPeso_Click(object sender, EventArgs e)
		{
			double billetes;
			Peso pesos;
			if (double.TryParse(txtPeso.Text, out billetes) && billetes > 0)
			{
				pesos = billetes;
				this.txtPesoPeso.Text = pesos.GetCantidad().ToString("0.00");
				this.txtPesoDolar.Text = ((Dolar)pesos).GetCantidad().ToString("0.00");
				this.txtPesoEuro.Text = ((Euro)pesos).GetCantidad().ToString("0.00");
			}
		}

		private void btnDolar_Click(object sender, EventArgs e)
		{
			double billetes;
			Dolar dolares;
			if (double.TryParse(txtDolar.Text, out billetes) && billetes > 0)
			{
				dolares = billetes;
				this.txtDolarDolar.Text = dolares.GetCantidad().ToString("0.00");
				this.txtDolarEuro.Text = ((Euro)dolares).GetCantidad().ToString("0.00");
				this.txtDolarPeso.Text = ((Peso)dolares).GetCantidad().ToString("0.00");
			}
		}

		private void btnEuro_Click(object sender, EventArgs e)
		{
			double billetes;
			Euro euros;
			if (Double.TryParse(txtEuro.Text, out billetes) && billetes > 0)
			{
				euros = billetes;
				this.txtEuroEuro.Text = euros.GetCantidad().ToString("0.00");
				this.txtEuroDolar.Text = ((Dolar)euros).GetCantidad().ToString("0.00");
				this.txtEuroPeso.Text = ((Peso)euros).GetCantidad().ToString("0.00");
			}
		}

		private void lblPeso_Click(object sender, EventArgs e)
		{

		}

		private void lblDolar_Click(object sender, EventArgs e)
		{

		}

		private void lblEuro_Click(object sender, EventArgs e)
		{

		}

		private void txtPeso_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtDolar_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtEuro_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtEuroEuro_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
