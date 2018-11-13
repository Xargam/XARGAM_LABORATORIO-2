using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClase
{
  public partial class FrnPrincipal : Form
  {
    public FrnPrincipal()
    {
      InitializeComponent();
      this.button1.Click += new EventHandler(this.MiManejadorClick);
      this.button1.Click += new EventHandler(this.MiManejadorCentral);
      /*this.button1.Click += new EventHandler(this.MiManejadorClick);
      this.button1.Click += new EventHandler(this.CambiarFondo);
      this.button2.Click += new EventHandler(this.MiManejadorClick);
      this.textBox1.Click += new EventHandler(this.MiManejadorClick);
      this.Click += new EventHandler(this.MiOtroManejadorClick);*/
    }

    public void MiOtroManejadorClick(object obj, EventArgs evento)
    {
      /*this.button2.Click -= new EventHandler(this.MiManejadorClick);
      this.button1.Click += new EventHandler(this.MiManejadorClick);*/
    }

    public void CambiarFondo(object obj, EventArgs evento)
    {
      ((Control)obj).BackColor = Color.Coral;
    }

    public void MiManejadorCentral(object obj, EventArgs evento)
    {
      if (obj.Equals(this.button1))
      {
        this.button1.Click -= new EventHandler(this.MiManejadorClick);
        this.button1.Click -= new EventHandler(this.MiManejadorCentral);
        this.button2.Click += new EventHandler(this.MiManejadorClick);
        this.button2.Click += new EventHandler(this.MiManejadorCentral);
      }
      else if(obj.Equals(this.button2))
      {
        this.button2.Click -= new EventHandler(this.MiManejadorClick);
        this.button2.Click -= new EventHandler(this.MiManejadorCentral);
        this.textBox1.Click += new EventHandler(this.MiManejadorClick);
        this.textBox1.Click += new EventHandler(this.MiManejadorCentral);
      }
      else if (obj.Equals(this.textBox1))
      {
        this.textBox1.Click -= new EventHandler(this.MiManejadorClick);
        this.textBox1.Click -= new EventHandler(this.MiManejadorCentral);
        this.button1.Click += new EventHandler(this.MiManejadorClick);
        this.button1.Click += new EventHandler(this.MiManejadorCentral);
      }          
    }

    public void MiManejadorClick(object obj, EventArgs evento)
    {
      Clipboard.SetText("hotel? trivago?");
      MessageBox.Show( ((Control)obj).Name);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Clipboard.SetText("jajajaj");
      //Clipboard.("jajajaj");
      //this.button1.Click -= new EventHandler(this.MiManejadorClick);
      //this.button1.Click -= new EventHandler(this.CambiarFondo);
      //this.button2.Click -= new EventHandler(this.MiManejadorClick);
      //this.textBox1.Click -= new EventHandler(this.MiManejadorClick);
      //this.Click -= new EventHandler(this.MiOtroManejadorClick);
    }

  }
}
