using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void CajonDelegado(object objeto, EventArgs evento);

    public class Cajon<T> : ISerializable
    {
        public int _capacidad;
        public List<T> _frutas;
        public float _precioUnitario;

        #region contructores
        public Cajon()
        {
            this._frutas = new List<T>();
        }
        public Cajon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio)
            : this(capacidad)
        {
            this._precioUnitario = precio;
        }
        #endregion

        public List<T> Frutas { get { return this._frutas; } }

        public float PrecioTotal 
        {
            get
            {
                if (this._precioUnitario * this.Frutas.Count > 25)
                {
                    this.EventoPrecio += new CajonDelegado(Manejador);
                    this.EventoPrecio(this,new EventArgs());
                }
                return this._precioUnitario * this.Frutas.Count;
            }
        }

        public string RutaArchivo
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
            set
            {
                this.RutaArchivo = value;
            }
        }

        public bool DeserealizarXML()
        {
            try
            {
                Cajon<T> nuevo = new Cajon<T>();
                TextReader lectura = new StreamReader(this.RutaArchivo + "Archivo.xml");
                XmlSerializer deserializador = new XmlSerializer(typeof(Cajon<T>));
                nuevo=(Cajon<T>)deserializador.Deserialize(lectura);
                lectura.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public bool SerializarXML()
        {
            
            try
            {
                TextWriter escritor = new StreamWriter(this.RutaArchivo + "Archivo.xml");                              
                XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));
                serializador.Serialize(escritor, this);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            Cajon<T> retorno = c;
            if (f is Fruta && retorno.Frutas.Count < retorno._capacidad)
            {
                retorno.Frutas.Add(f);
            }
            else
            {
                if (retorno.Frutas.Count >= retorno._capacidad)
                {
                    throw new CajonLlenoException("El cajon esta lleno");
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cajon:");
            sb.AppendLine("Capacidad Maxima: "+ this._capacidad);
            sb.AppendLine("Precio por unidad: " + this._precioUnitario+"\n");
            foreach (T f in this.Frutas)
            {
                sb.AppendLine(f.ToString());
            }
            sb.AppendLine("Precio Total: " + this.PrecioTotal+"\n");
            return sb.ToString();
        }

        public event CajonDelegado EventoPrecio;

        public static void Manejador(object objeto, EventArgs evento)
        {
            StreamWriter escritor = new StreamWriter(((Cajon<T>)objeto).RutaArchivo+ "Archivo.txt");
            escritor.WriteLine("Precio total: "+((Cajon<T>)objeto)._capacidad*((Cajon<T>)objeto)._precioUnitario);
            escritor.WriteLine("Horario"+DateTime.Now);
            escritor.Close();
        }
    }

    
}
