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
            this.CmbOperador.Items.Add("+");
            this.CmbOperador.Items.Add("-");
            this.CmbOperador.Items.Add("/");
            this.CmbOperador.Items.Add("*");
            this.CmbOperador.SelectedItem = "+";
            this.CmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
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
            string binario = numero.DecimalBinario(this.TxtNumero1.Text);
            this.LblResultado.Text = binario;
        }

        private void LblResultado_Click(object sender, EventArgs e)
        {
        }

		/// <summary>
		/// Convierte un numero binario a decimal mediante la clase número.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string binario = numero.BinarioDecimal(this.TxtNumero2.Text);
            this.LblResultado.Text = binario;
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

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {
        }

		/// <summary>
		/// Realiza una aritmética operación solicitada por el usuario.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOperar_Click(object sender, EventArgs e)
		{
			double result = LaCalculadora.Operar(this.TxtNumero1.Text,this.TxtNumero2.Text,this.CmbOperador.Text);
			this.LblResultado.Text = result.ToString();
		}
	
		/// <summary>
		/// Reestablece los valores del Combobox, textBoxes y Label a su valor por defecto.
		/// </summary>
		private void Limpiar()
		{
			this.TxtNumero1.Text = "0";
			this.TxtNumero2.Text = "0";
			this.LblResultado.Text = "0";
			this.CmbOperador.SelectedItem = "+";
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
