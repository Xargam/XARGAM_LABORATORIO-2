using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase07;

namespace Clase08
{
  public partial class Form1 : Form
  {
    private Paleta _paleta;


    public Form1()
    {
      InitializeComponent();
      this._paleta = 5;
      this.groupBox1.Text = "Paleta de colores";
      this.textBox1.Multiline = true;
      this.groupBox1.Visible = false;
      this.button1.Text = "+";
      this.button2.Text = "-";
      
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.groupBox1.Visible = true;
      this.agregarPaletaToolStripMenuItem.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      FrmTempera colores = new FrmTempera();
      DialogResult dialogResult = ShowDialog();

      if( dialogResult == DialogResult.OK )
      {
        this._paleta += colores.Tempera;
        textBox1.Text += (string)this._paleta;
      }
      
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
  }
}
