using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Ejercicio_40_Form
{
	public partial class FrmLlamador : Form
	{
		#region Atributos
		private Centralita _centralita;
		#endregion

		#region Propiedades
		public Centralita Centralita
		{
			get
			{
				return this._centralita;
			}
		}
		#endregion

		#region Constructor
		public FrmLlamador(Centralita centralita)
		{
			InitializeComponent();
			this.cmbFranja.Enabled = false;
			this._centralita = centralita;
			this.DialogResult = DialogResult.None;
			this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
		} 
		#endregion

		private void FrmLlamador_Load(object sender, EventArgs e)
		{

		}

		private void txtNroOrigen_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.cmbFranja.Enabled = false;
			this.txtNroDestino.Text = "Nro Destino";
			this.txtNroOrigen.Text = "Nro Origen";
		}

		private void btnLlamar_Click(object sender, EventArgs e)
		{
			Provincial.Franja franja;
			if (!Object.Equals(this.txtNroDestino, null) && !Object.Equals(this.txtNroOrigen, null) && Enum.TryParse<Provincial.Franja>(this.cmbFranja.Text, out franja))
			{
				if (this.txtNroDestino.Text[0] == '#')
				{
					Provincial provincial = new Provincial(this.txtNroOrigen.Text, franja, new Random().Next(1, 51), this.txtNroDestino.Text);
					this._centralita += provincial;
					MessageBox.Show(string.Format("Llamado realizado.\n{0}",provincial.ToString()));
				}
				else
				{
					Local local = new Local(this.txtNroOrigen.Text, new Random().Next(1, 51), this.txtNroDestino.Text, (new Random().Next(5, 57)) / 10F);
					this._centralita += local;
					MessageBox.Show(string.Format("Llamado realizado.\n{0}", local.ToString()));
				}
				
			}
			else
			{
				MessageBox.Show("Se ha producido un error.");

			}
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "9";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "*";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			this.txtNroDestino.Text += "0";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			this.InicializarNroDestino();
			if(this.txtNroDestino.Text == string.Empty)
			{
				this.cmbFranja.Enabled = true;
			}
			this.txtNroDestino.Text += "#";
		}

		private void InicializarNroDestino()
		{
			if (this.txtNroDestino.Text == "Nro Destino")
			{
				this.txtNroDestino.Text = "";
			}
		}
	}
}
