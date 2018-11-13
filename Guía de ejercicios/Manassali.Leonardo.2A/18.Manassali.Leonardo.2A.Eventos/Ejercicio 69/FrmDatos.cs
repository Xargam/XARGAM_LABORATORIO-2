using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void ActualizarNombre(string nombre)
        {
            this.lblActualizable.Text = nombre;
        }

        public void ActualizarFoto(string nombre)
        {
            this.pictureBox1.ImageLocation = nombre;
        }


    }
}
