using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio_59
{

    public class Local : Llamada , IGuardar<Local>
	{
		#region Atributos
		protected float _costo;
        #endregion

        #region Propiedades

        public override float CostoLlamada
		{
			get
			{
                return this.CalcularCosto();
			}
		}

        public string RutaDelArchivo
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public Local() 
        {

        }
        public Local(Llamada llamada , float costo) : this(llamada.NroOrigen, llamada.Duracion , llamada.NroDestino,costo)
		{
		}
		public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
		{
			this._costo = costo;
		}
		#endregion

		#region Metodos
		public override bool Equals(object obj)
		{
			return obj is Local;
		}
		public override string ToString()
		{
			return this.Mostrar();
		}
		protected override string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.Mostrar());
			datos.AppendFormat("Costo: {0}\n", this.CostoLlamada);
			return datos.ToString();
		}
		private float CalcularCosto()
		{
			return this.Duracion * this._costo;
		}

        public bool Guardar()
        {
            XmlTextWriter archivo = new XmlTextWriter(this.RutaDelArchivo,Encoding.UTF8);
            XmlSerializer xml = new XmlSerializer(typeof(Local));
            xml.Serialize(archivo, this );
            archivo.Close();
            return true;
        }

        public Local Leer()
        {
            Local local;
            XmlTextReader archivo = new XmlTextReader(this.RutaDelArchivo);
            XmlSerializer xml = new XmlSerializer(typeof(Local));
            local = (Local)xml.Deserialize(archivo);
            archivo.Close();
            return local;
        }

        #endregion
    }
}
