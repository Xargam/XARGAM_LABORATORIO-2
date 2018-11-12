using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    public class Persona
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        #endregion

        #region Propiedades
        //No se puede serializar atributos privados por lo que necesito estas propieades.
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
        #endregion

        #region Constructor
        public Persona()
        {
        } 
        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("Nombre: {0} - Apellido: {1}\n", this._nombre, this._apellido);
        }
        public static bool Guardar(Persona persona)
        {
            XmlTextWriter archivo = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Persona.xml", Encoding.UTF8);
            XmlSerializer xml = new XmlSerializer(typeof(Persona));
            xml.Serialize(archivo, persona);
            archivo.Close();
            return true;
        }

        public static Persona Leer()
        {
            
            XmlTextReader archivo = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Persona.xml");
            XmlSerializer xml = new XmlSerializer(typeof(Persona));
            Persona persona = (Persona)xml.Deserialize(archivo);
            archivo.Close();
            return persona;
        }
        #endregion
    }
}
