using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmTestDelegados : Form
    {
        private string _imagenPath;
        public FrmTestDelegados()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verif = false;
            foreach (Form item in this.Owner.OwnedForms)
            {
                if(item is FrmDatos)
                {
                    verif = true;
                    break;
                }
            }
            if (verif)
            {
                ((FrmPrincipal)this.Owner).miDelegado.Invoke(this.btnActualizar.Text);
                ((FrmPrincipal)this.Owner).foto.Invoke(this._imagenPath);
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this._imagenPath = openFileDialog1.FileName;

        }
    }
}
