using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_68
{
    public delegate void DelegadoString(string msg);
    
    public class Persona
    {
        #region Atributos
        private string _apellido;
        private string _nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre , string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            return this.Nombre + " - " + this.Apellido + "\n";
        }
        #endregion
    }
}
