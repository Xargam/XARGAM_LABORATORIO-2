using EntidadesAbstractas;
using EntidadesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Excepciones;

namespace TestsUnitarios
{
	[TestClass]
	public class ValidacionDatosNumericos
	{
		/// <summary>
		/// Verifica que al cargar un DNI (Dato numérico cargado como string) a un objeto el rango del mismo se valide correctamente.
		/// </summary>
		[TestMethod]
		public void VerificarDniRango()
		{
			bool seProdujoLaExcepcion = false;
			Alumno alumno300 = null;
			try
			{
				alumno300 = new Alumno(44, "Marcelo", "Vara", "4545", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
			}
			catch (NacionalidadInvalidaException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Se debería haber producido una excepción de tipo NacionalidadInvalidaException, dni fuera de rango.");
			Assert.IsNull(alumno300,"Se produjo una excepción en momento de instanciado , el objeto debería ser nulo.");

			seProdujoLaExcepcion = false;
			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara", "90000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
			}
			catch (Exception)
			{
				Assert.Fail("Ninguna excepción debería haber aparecido.");
			}

			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara", "1", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
			}
			catch (Exception)
			{
				Assert.Fail("Ninguna excepción debería haber aparecido.");
			}

			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara", "0", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
			}
			catch (NacionalidadInvalidaException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion,"Debería haberse generado una excepcion de tipo NacionalidadInválidaException, dni fuera de rango.");

		}
		/// <summary>
		/// Verifica que al cargar un DNI (Dato numérico cargado como string) en un objeto Persona no numérico , nulo o demasiado extenso se haga la validación correcta.
		/// </summary>
		[TestMethod]
		public void VerificarDniErroneo()
		{
			bool seProdujoLaExcepcion = false;
			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara", "hgfhfhfhf", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
			}
			catch (DniInvalidoException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Se debería haber producido una excepción de tipo DniInvalidoException, dni no numérico.");

			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara", "91000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
			}
			catch (Exception)
			{
				Assert.Fail("Ninguna excepción debería haber aparecido.");
			}

			try
			{
				Alumno alumno = new Alumno(44, "Marcelo", "Vara",null, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
			}
			catch (DniInvalidoException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Debería haberse generado una excepcion de tipo DniInvalidoException , el dni tiene un error de formato.");

		}
	}
}
