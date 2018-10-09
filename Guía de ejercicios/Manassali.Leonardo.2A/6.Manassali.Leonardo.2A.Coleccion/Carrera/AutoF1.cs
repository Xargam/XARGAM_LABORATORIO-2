using System;
using System.Collections.Generic;
using System.Text;

namespace Carrera
{
	public class AutoF1
	{
		#region Atributos

		private short cantidadCombustible;
		private bool enCompetencia;
		private string escuderia;
		private short numero;
		private short vueltasRestantes;

		#endregion

		public AutoF1(short numero, string escuderia)
		{
			this.cantidadCombustible = 0;
			this.vueltasRestantes = 0;
			this.enCompetencia = false;
			this.numero = numero;
			this.escuderia = escuderia;
		}

		public string MostrarDatos()
		{
			string datos = "Auto Fórmula 1:\nCantidad de combustible: " + this.cantidadCombustible + "\nEn competencia: ";
			datos += (this.enCompetencia) ? "Si" : "No";
			datos += "\nEscuderia: " + this.escuderia + "\nNumero: " + this.numero + "\nVueltas restantes: " + this.vueltasRestantes + "\n\n";
			return datos;
		}

		public static bool operator !=(AutoF1 a1, AutoF1 a2)
		{
			return !(a1 == a2);
		}

		public static bool operator ==(AutoF1 a1, AutoF1 a2)
		{
			return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
		}


		public short GetCantidadCombustible()
		{
			return this.cantidadCombustible;
		}
		public void SetCantidadCombustible(short cantidadCombustible)
		{
			this.cantidadCombustible = cantidadCombustible;
		}

		public short GetVueltasRestantes()
		{
			return this.vueltasRestantes;
		}
		public void SetVueltasRestantes(short vueltasRestantes)
		{
			this.vueltasRestantes = vueltasRestantes;
		}

		public bool GetEnCompetencia()
		{
			return this.enCompetencia;
		}
		public void SetEnCompetencia(bool enCompetencia)
		{
			this.enCompetencia = enCompetencia;
		}
		
	}

}
