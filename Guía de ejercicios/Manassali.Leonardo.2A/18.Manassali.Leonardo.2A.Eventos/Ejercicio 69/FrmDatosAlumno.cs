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
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            this.pictureBox1.ImageLocation = alumno.RutaDeLaFoto;
            base.txtNombre.Text = alumno.Nombre;
            base.txtApellido.Text = alumno.Apellido;
            base.txtDni.Text = alumno.Dni.ToString();
            base.txtFoto.Text = alumno.RutaDeLaFoto;
        }
    }
}
