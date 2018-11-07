using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaLibreria;

namespace Ejercicio_44
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// a. Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al
		/// crear un nuevo objeto del tipo Centralita.
		/// </summary>
		[TestMethod]
		public void ValidarListaLlamadas()
		{
			Centralita centralita = new Centralita("Telefonica");
			Assert.IsNotNull(centralita.Llamadas,"La lista de llamadas de Centralita es null. Se produjo un error en el constructor de Centralita.");
		}

		/// <summary>
		/// b. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
		/// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
		/// destino de una llamada Local ya existente.
		/// </summary>
		[TestMethod]
		public void ValidarLlamadasLocalesRepetidas()
		{
			CentralitaException exception = null;
			Centralita centralita = new Centralita("Telefonica");
			Local llamada1 = new Local("40204020",50, "44",444);
			Local llamada2 = new Local("40204020",5, "44",550);

			try
			{
				centralita += llamada1;
				centralita += llamada2;
			}
			catch (CentralitaException e)
			{
				exception = e;
			}
			Assert.IsNotNull(exception,"Se intento intento agregar llamadas locales con igual numero de origen y destino y no se produjo CentralitaException.");
		}

		/// <summary>
		/// c. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
		/// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Provincial ya existente.
		/// </summary>
		[TestMethod]
		public void ValidarLlamadasProvincialesRepetidas()
		{
			CentralitaException exception = null;
			Centralita centralita = new Centralita("Telefonica");
			Provincial llamada1 = new Provincial("40204020", Provincial.Franja.Franja_1 , 444,"44");
			Provincial llamada2 = new Provincial("40204020", Provincial.Franja.Franja_3 , 25,"44");

			try
			{
				centralita += llamada1;
				centralita += llamada2;
			}
			catch (CentralitaException e)
			{
				exception = e;
			}
			Assert.IsNotNull(exception,"Se intento intento agregar llamadas provinciales con igual numero de origen y destino y no se produjo CentralitaException.");
		}

		/// <summary>
		/// d. Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
		/// los mismos datos de origen y destino.Luego comparar cada uno de estos cuatro objetos contra los demás,
		/// debiendo ser iguales solamente las instancias de Local y de Provincial entre sí.
		/// </summary>
		[TestMethod]
		public void ValidarIgualdadEntreClasesLlamada()
		{
			Local llamada1 = new Local("40204020", 50, "44", 444);
			Local llamada2 = new Local("40204020", 5, "44", 550);
			Provincial llamada3 = new Provincial("40204020", Provincial.Franja.Franja_1, 4, "44");
			Provincial llamada4 = new Provincial("40204020", Provincial.Franja.Franja_3, 25, "44");

			//Comparo llamada 1
			Assert.IsTrue(llamada1 == llamada2, "Dos instancias de llamada local con los mismos datos en origen y destino deberían ser iguales.");
			Assert.IsFalse(llamada1 == llamada3,"Una llamada provincial no debería ser igual a una local por más que tengan los mismos datos en origen y destino.");
			Assert.IsFalse(llamada1 == llamada4, "Una llamada provincial no debería ser igual a una local por más que tengan los mismos datos en origen y destino");

			//Comparo llamada 2
			Assert.IsFalse(llamada2 == llamada3, "Una llamada provincial no debería ser igual a una local por más que tengan los mismos datos en origen y destino");
			Assert.IsFalse(llamada2 == llamada4, "Una llamada provincial no debería ser igual a una local por más que tengan los mismos datos en origen y destino");

			//Comparo llamada 3
			Assert.IsTrue(llamada3 == llamada4, "Dos instancias de llamada provincial con los mismos datos en origen y destino deberían ser iguales.");

		}

	}
}
