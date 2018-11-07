using Ejercicio43Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
a. Agregar una propiedad que haga pública la lista de Vehiculos de Competencia.
b. Crear un test unitario que valide que la lista de vehículos de la competencia esté instanciada
al crear un nuevo objeto.
c. Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance al
querer cargar un AutoF1 en una competencia del tipo MotoCross.
d. Realizar otro test que controle que la excepción CompetenciaNoDisponible no se lance al
querer cargar un objeto del tipo MotoCross en una competencia del tipo MotoCross.
e. Comprobar que al cargar un nuevo vehículo en la competencia esté figure en la lista. Utilizar
el operador + y el ==.
f. Comprobar que al quitar un vehículo existente en la competencia esté ya no figure en la
lista. Utilizar el operador - y el !=.
*/

namespace Ejercicio_46
{
	[TestClass]
	public class ValidacionEjercicio43
	{
		/// <summary>
		/// b. Crear un test unitario que valide que la lista de vehículos de la competencia esté instanciada
		/// al crear un nuevo objeto.
		/// </summary>
		[TestMethod]
		public void ValidarListaVehiculos()
		{
			Competencia competencia = new Competencia(10, 2, Competencia.TipoCompetencia.F1);
			Assert.IsNotNull(competencia.Vehiculos);
		}

		/// <summary>
		/// c. Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance al
		/// querer cargar un AutoF1 en una competencia del tipo MotoCross.
		/// </summary>
		[TestMethod]
		public void ValidarLanzamientoCompetenciaNoDisponibleException()
		{
			Competencia competencia = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
			AutoF1 autoF1 = new AutoF1(45, "ad");
			bool seProdujoLaExcepcion = false;
			try
			{
				if (competencia + autoF1)
				{
					;
				}
			}
			catch (CompetenciaNoDisponibleException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion,"Se deberia haber producido una excepción de tipo CompetenciaNoDisponnibleException al agregar un objeto AutoF1 en una competencia de MotoCross.");
		}

		/// <summary>
		/// d. Realizar otro test que controle que la excepción CompetenciaNoDisponible no se lance al
		/// querer cargar un objeto del tipo MotoCross en una competencia del tipo MotoCross.
		/// </summary>
		[TestMethod]
		public void ValidarCompetenciaNoDisponibleException()
		{
			Competencia competencia = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
			MotoCross motoCross = new MotoCross(45, "ad",50);

			try
			{
				if (competencia + motoCross)
				{
					
				}
			}
			catch (CompetenciaNoDisponibleException)
			{
				Assert.Fail("Se produjo una excepción CompetenciaNoDisponibleException que no debería haber sucedido.");
			}
			
		}

		/// <summary>
		/// e.Comprobar que al cargar un nuevo vehículo en la competencia esté figure en la lista.Utilizar
		/// el operador + y el ==.
		/// </summary>
		[TestMethod]
		public void ValidarCargarVehiculos()
		{
			Competencia competencia = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
			MotoCross motoCross = new MotoCross(45, "ad", 50);
			bool estaElVehiculo = false;

			try
			{
				if (competencia + motoCross && competencia == motoCross)
				{
					estaElVehiculo = true;
				}
			}
			catch (CompetenciaNoDisponibleException)
			{
				Assert.Fail("Se produjo una excepción CompetenciaNoDisponibleException que no debería haber sucedido.");
			}
			Assert.IsTrue(estaElVehiculo, "El vehiculo debería haber sido agregado y encontrado, estaElVehiculo debería haber sido true.");
		}


		/// <summary>
		/// f. Comprobar que al quitar un vehículo existente en la competencia esté ya no figure en la
		/// lista. Utilizar el operador - y el !=.
		/// </summary>
		[TestMethod]
		public void ValidarEliminacionVehiculo()
		{
			Competencia competencia = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
			MotoCross motoCross = new MotoCross(45, "ad", 50);
			bool noEstaElVehiculo = false;

			try
			{
				if (competencia + motoCross) ;
				if (competencia - motoCross && competencia != motoCross)
				{
					noEstaElVehiculo = true;
				}
			}
			catch (CompetenciaNoDisponibleException)
			{
				Assert.Fail("Se produjo una excepción CompetenciaNoDisponibleException que no debería haber sucedido.");
			}
			Assert.IsTrue(noEstaElVehiculo, "El vehiculo debería haber sido agregado y quitado, noEstaElVehiculo debería haber sido true.");
		}


	}
}
