using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
  public partial class FrmPrincipal : Form
  {
    public actualizarNombreDelegado _miDelegado;

    public FrmPrincipal()
    {
      InitializeComponent();
      this.testDelegadosToolStripMenuItem.Click += new EventHandler(this.TestDelegadosClick);
    }

    private void TestDelegadosClick(object sender, EventArgs evento)
    {
      FrmTestDelegados delegados = new FrmTestDelegados();
      delegados.Show(this);
    }

    private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmDatos datos = new FrmDatos();
      this._miDelegado += datos.ActualizarNombre;
      datos.Show(this);
    }
  }
}
