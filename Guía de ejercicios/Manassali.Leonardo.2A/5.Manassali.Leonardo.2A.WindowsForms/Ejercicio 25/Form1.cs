using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numero;

namespace Ejercicio_25
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBinarioDecimalbtnBinarioDecimal_Click(object sender, EventArgs e)
		{
			this.txtDecimal.Text = (Conversor.BinarioDecimal(this.txtBinarioDecimal.Text)).ToString();
		}

		private void btnDecimalBinario_Click(object sender, EventArgs e)
		{
			double numeroDecimal;
			if( Double.TryParse(this.txtDecimalBinario.Text,out numeroDecimal ))
			{
				this.txtBinario.Text = Conversor.DecimalBinario(numeroDecimal).ToString();
			}
			
		}

		private void txtBinario_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
