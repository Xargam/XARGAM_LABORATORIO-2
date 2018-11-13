using System;
using System.Windows.Forms;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        #region Constructores
        public Form1()
        {
            InitializeComponent();
            this.rtbActivarReloj.Click += this.clickRichTxtBox;
            this.rtbActivarReloj.Text = "Haga click aquí para activar el reloj.";
        }
        #endregion

        #region Metodos
        private void AsignarHora()
        {
            do
            {
                this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                for (int i = 0; i < 10000000; i++)
                {

                }

            } while (true);
            
        }
        private void clickRichTxtBox(object sender, EventArgs e)
        {
            this.AsignarHora();
        }

        #endregion
    }
}
