using System;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class FormPersona : Form
    {
        #region Atributos
        private Persona _persona;
        private event DelegadoString _personaCreada;
        #endregion

        #region Constructores
        public FormPersona()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void Persona_Load(object sender, EventArgs e)
        {
            this._personaCreada += new DelegadoString(FormPersona.NotificarCambio);
        }


        private static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string mensaje = "La persona se actualizó";
            if (object.Equals(this._persona , null))
            {
                mensaje = "Se ha creado la persona.";
                this.btnCrear.Text = "Actualizar";
            }
            else if(this._persona.Apellido == this.txtApellido.Text && this._persona.Nombre == this.txtNombre.Text)
            {
                mensaje = "La persona fue recargada sin alteraciones.";
            }
            Persona persona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
            this._personaCreada(mensaje + "\r\n" + persona.Mostrar());
            this._persona = persona;

        }
        #endregion
    }
}
