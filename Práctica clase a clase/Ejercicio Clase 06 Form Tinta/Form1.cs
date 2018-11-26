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
  public partial class Form1 : Form
  {
    private Pluma pluma;
    private Tinta tinta;

    public Form1()
    {
      InitializeComponent();
    }

    private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTinta menuTinta = new frmTinta();
      menuTinta.Show();
    }

    private void plumaToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
