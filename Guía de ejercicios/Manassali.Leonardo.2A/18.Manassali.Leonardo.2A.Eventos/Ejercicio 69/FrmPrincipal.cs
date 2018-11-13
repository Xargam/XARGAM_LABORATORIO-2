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
    public partial class FrmPrincipal : Form
    {
        #region Atributos
        public DelegadoNombre miDelegado;
        public DelegadoFoto foto;
        public DelegadoAlumno miAlumno;
        #endregion

        #region Constructores
        public FrmPrincipal()
        {
            InitializeComponent();
            this.menuStrip1.BackColor = Color.CadetBlue;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion

        #region Metodos

        #region Testeo
        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados delegados = new FrmTestDelegados();
            delegados.Show(this);
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos datos = new FrmDatos();
            this.miDelegado = new DelegadoNombre(datos.ActualizarNombre);
            this.foto = new DelegadoFoto(datos.ActualizarFoto);
            datos.Show(this);
        }
        #endregion

        #region Alumnos
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno alumnos = new FrmAltaAlumno();
            alumnos.Show(this);
        }
        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosAlumno datos = new FrmDatosAlumno();
            this.miAlumno = new DelegadoAlumno(datos.ActualizarAlumno);
            datos.Show(this);
        }
        #endregion

        #endregion
    }

}
