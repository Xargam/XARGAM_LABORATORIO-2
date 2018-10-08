using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
		/// <summary>
		/// Inicializa los componentes escenciales de la calculadora. Establece operadores y configuraciones básicas.
		/// </summary>
        public LaCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.SelectedItem = "+";
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

		/// <summary>
		/// Cierra el formulario (Calculadora).
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		/// <summary>
		/// Convierte un numero decimal a binario mediante la clase número.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
			Numero numero = new Numero();
			this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
        }

		/// <summary>
		/// Convierte un numero binario a decimal mediante la clase número.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
			Numero numero = new Numero();
			this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
		}

		/// <summary>
		/// Reestablece los valores en pantalla.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
			this.Limpiar();
        }

		/// <summary>
		/// Realiza una aritmética operación solicitada por el usuario.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOperar_Click(object sender, EventArgs e)
		{
			double result = LaCalculadora.Operar(this.txtNumero1.Text,this.txtNumero2.Text,this.cmbOperador.Text);
			this.lblResultado.Text = (Double.IsInfinity(result))? "ERROR" : result.ToString();
		}
	
		/// <summary>
		/// Reestablece los valores del Combobox, textBoxes y Label a su valor por defecto.
		/// </summary>
		private void Limpiar()
		{
			this.txtNumero1.Text = "0";
			this.txtNumero2.Text = "0";
			this.lblResultado.Text = "0";
			this.cmbOperador.SelectedItem = "+";
		}

		/// <summary>
		/// Realiza una operación matemática básica según un operador y devuelve el resultado en formato double.
		/// </summary>
		/// <param name="numero1">Operando 1.</param>
		/// <param name="numero2">Operando 2.</param>
		/// <param name="operador">Operando válidos: "*","+","-","/"</param>
		/// <returns></returns>
		private static double Operar( string numero1 , string numero2 , string operador )
		{
			return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
		}
	}
}
