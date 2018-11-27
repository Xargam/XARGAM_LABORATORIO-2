using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructor
        /// <summary>
        /// Inicializa una instancia de FormCalculadora , establece los operadores para el comboBox , el operador por
        /// defecto y modo DropDownList a fin de evitar que se utilicen operadores erroneos.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.SelectedItem = "+";
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Reestablece los textBox , el comboBox y el label de resultado a sus valores de inicio.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.cmbOperador.SelectedItem = "+";
            this.lblResultado.Text = "0";
        }
        /// <summary>
        /// Realiza una operación artimética a partir de cadenas de caracteres que representan dos operandos y un operador.
        /// Devuelve el resultado en formato double.
        /// </summary>
        /// <param name="numero1">Operando 1.</param>
        /// <param name="numero2">Operando 2.</param>
        /// <param name="operador">Operador aritmético.</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = double.NaN;
            if (double.TryParse(numero1,out double num1) && double.TryParse(numero2, out double num2))
            {
                resultado = Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
            }
            return resultado;
        }
        /// <summary>
        /// Cierra al formulario cuando se hace click en el botón cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Cuando se hace click en el botón limpiar, restablece los valores numéricos de la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Realiza una operación cuando se hace click en el botón operar y muestra el resultado en el label resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(this.txtNumero1.Text,this.txtNumero2.Text,this.cmbOperador.Text);
            this.lblResultado.Text = ( double.IsNaN(resultado))? "Valor invalido" : resultado.ToString();
        }
        /// <summary>
        /// Intenta convertir a binario el número decimal que se encuentre en el label "resultado".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().DecimalBinario(this.lblResultado.Text);
        }
        /// <summary>
        /// Intenta convertir a decimal el numero binario que se encuentre en label "resultado".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().BinarioDecimal(this.lblResultado.Text);
        }

        #endregion
    }
}
