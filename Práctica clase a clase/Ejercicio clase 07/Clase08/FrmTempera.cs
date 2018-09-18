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
  public partial class FrmTempera : Form
  {
    #region AtributosPropiedades

    private Tempera _miTempera;
    public Tempera Tempera
    {
      get { return this._miTempera; }
    }

    #endregion

    #region Constructor

    public FrmTempera()
    {
      this.DialogResult = DialogResult.None;
      InitializeComponent();
      foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
      {
        comboBox1.Items.Add(color);
      }
      this.comboBox1.SelectedItem = ConsoleColor.DarkYellow;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public FrmTempera(Tempera tempera) : this()
    {
      this._miTempera = tempera;
    }

    #endregion

    #region Metodos

    private void button2_Click(object sender, EventArgs e)
    {
      this._miTempera = new Tempera(sbyte.Parse(textBox3.Text), (ConsoleColor)this.comboBox1.SelectedItem, this.textBox2.Text);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    #endregion
  }
}
