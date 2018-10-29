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
	public partial class ConversorNumerico : Form
	{
		#region Constructor
		public ConversorNumerico()
		{
			InitializeComponent();
		} 
		#endregion

		#region Metodos
		private void btnBinarioDecimalbtnBinarioDecimal_Click(object sender, EventArgs e)
		{
			this.txtDecimal.Text = Conversor.BinarioDecimal(this.txtBinarioDecimal.Text).ToString();
		}
		private void btnDecimalBinario_Click(object sender, EventArgs e)
		{
			string binario = "NeuN";
			if ( double.TryParse(this.txtDecimalBinario.Text, out double numeroDecimal) )
			{
				binario = Conversor.DecimalBinario(numeroDecimal);
			}
			this.txtBinario.Text = binario;
		} 
		#endregion
	}
}
