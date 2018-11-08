using System;

namespace Ejercicio_52
{
    public interface IAcciones
    {
        #region Propiedades
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }
        #endregion

        #region Metodos
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);
        #endregion
    }
}
