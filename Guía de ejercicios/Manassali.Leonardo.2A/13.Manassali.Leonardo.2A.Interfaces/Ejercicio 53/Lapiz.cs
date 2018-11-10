using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Lapiz : IAcciones
    {
        #region Atributos
        private float _tamanioMina;
        #endregion

        #region Propiedades
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this._tamanioMina;
            }
            set
            {
                this._tamanioMina = value;
            }
        }
        #endregion

        #region Constructor
        public Lapiz(int unidades)
        {
            this._tamanioMina = unidades;
        }

       
        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Lapiz:\r\n" + "Color: " + ((IAcciones)this).Color + "\r\nTinta: " + ((IAcciones)this).UnidadesDeEscritura;
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            string escritura = "";
            while (texto.Length > 0 && (decimal)((IAcciones)this).UnidadesDeEscritura - 0.1M >= 0)
            {
                ((IAcciones)this).UnidadesDeEscritura = (float)((decimal)((IAcciones)this).UnidadesDeEscritura - 0.1M);
                escritura += texto.Substring(0, 1);
                texto = texto.Remove(0, 1);
            }
            return new EscrituraWrapper(escritura, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
