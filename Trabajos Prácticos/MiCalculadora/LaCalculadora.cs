using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.SelectedItem = "/";
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string binario = numero.DecimalBinario(this.txtNumero1.Text);
            this.lblResultado.Text = binario;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string binario = numero.BinarioDecimal(this.txtNumero2.Text);
            this.lblResultado.Text = binario;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.lblResultado.Text = "0";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
