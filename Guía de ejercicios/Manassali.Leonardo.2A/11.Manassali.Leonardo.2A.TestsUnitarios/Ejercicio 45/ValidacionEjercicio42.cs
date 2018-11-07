using Ejercicio42Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Ejercicio_45
{
	/// <summary>
	/// Tomar el ejercicio 42:
	/// a.Realizar un test unitario para cada método y/o constructor.
	/// b.Cada test deberá validar que el método lance la excepción que le corresponde.
	/// </summary>
	[TestClass]
	public class ValidacionEjercicio42
	{

		[TestMethod]
		public void ValidarMetodoEstaticoDivision0()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				Program.MiMetodo();
			}
			catch (DivideByZeroException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "La excepción de division por 0 esperada no surgió.");
		}

		[TestMethod]
		public void ValidarConstructorDeInstancia1Division0()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				MiClase obj = new MiClase(4, 'e');
			}
			catch (DivideByZeroException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "La excepción de division por 0 esperada no surgió.");
		}

		[TestMethod]
		public void ValidarConstructorDeInstancia2UnaExcepcion()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				MiClase2 obj = new MiClase2(4, 'e');
			}
			catch (UnaExepcion)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "La excepción UnaExcepcion esperada no surgió.");
		}

		[TestMethod]
		public void ValidarMetodoDeInstanciaMiExcepcion()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				MiClase3 miClase3 = new MiClase3();
				miClase3.MetodoDeInstancia();
			}
			catch (MiExcepcion)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "La excepción MiExcepcion esperada no surgió.");
		}

		[TestMethod]
		public void ValidarMainExceptionAtrapadaMostrada()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				Program.MainFunctionAdapted();
			}
			catch (Exception)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsFalse(seProdujoLaExcepcion, "La excepción Exception debería haber sido controlada y surgió de todas formas.");
		}
	}
}
