using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio_69
{
    public partial class FrmAltaAlumno : Form
    {
        private string _imagenPath;
        public FrmAltaAlumno()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.txtFoto.DoubleClick += new EventHandler(this.txtFotoClick);
        }

        private void txtFotoClick(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this._imagenPath = this.openFileDialog1.FileName;
            this.txtFoto.Text = this._imagenPath;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            bool verif = false;
            foreach (Form item in this.Owner.OwnedForms)
            {
                if (item is FrmDatosAlumno)
                {
                    verif = true;
                    break;
                }
            }
            if (verif)
            {
                try
                {
                    Alumno alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), this._imagenPath);
                    ((FrmPrincipal)this.Owner).miAlumno.Invoke(alumno);
                }
                catch (Exception)
                {

                }
                
            }
            
        }

    }
}
