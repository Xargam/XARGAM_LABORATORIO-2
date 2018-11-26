using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_06
{
  public partial class frmTinta : Form
  {
    public frmTinta()
    {
      InitializeComponent();
     
      foreach( ConsoleColor color in Enum.GetValues( typeof(ConsoleColor) ) )
      {
        this.cboColor.Items.Add( color);
      }
      this.cboColor.SelectedItem = ConsoleColor.Black;
      this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;

      foreach ( ElTipoTinta tinta in Enum.GetValues(typeof(ElTipoTinta)))
      {
        this.cboTinta.Items.Add(tinta);
      }
      this.cboTinta.SelectedItem = ElTipoTinta.ConBrillito;
      this.cboTinta.DropDownStyle = ComboBoxStyle.DropDownList;

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
