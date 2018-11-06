using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Archivos;
using Excepciones;

namespace TestsUnitarios
{
	[TestClass]
	public class ValidacionExcepciones
	{
		/// <summary>
		/// Verifica que la excepción AlumnoRepetidoException sea lanzada correctamente tanto en Jornada como en Universidad.
		/// </summary>
		[TestMethod]
		public void VerificarAlumnoRepetidoException()
		{
			try
			{
				Profesor profesor = new Profesor(45, "Pablo Alberto", "Dum", "100", Persona.ENacionalidad.Argentino);
				Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);

				Alumno al1 = new Alumno(10, "Javier", "Piriri", "100", Persona.ENacionalidad.Argentino,Universidad.EClases.Laboratorio);
				Alumno al2 = new Alumno(11, "Javier", "Piriri", "100", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

				jornada += al1;
				jornada += al2;

			}
			catch (Exception e)
			{
				Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException),"Se debería producir únicamente una excepción de tipo AlumnoRepetidoException.");
			}

			try
			{
				Universidad uni = new Universidad();
				
				Alumno al1 = new Alumno(10, "Javier", "Piriri", "10", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
				Alumno al2 = new Alumno(11, "Javier", "Piriri", "100", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
				uni += al1;
				uni += al2;
			}
			catch (Exception)
			{
				Assert.Fail("No debería producirse una excepción.");
			}
			
		}
		/// <summary>
		/// Verifica que la excepción SinProfesorException sea lanzada correctamente.
		/// </summary>
		[TestMethod]
		public void VerificarSinProfesorException()
		{
			Universidad uni = new Universidad();
			bool seProdujoLaExcepcion = false;

			try
			{
				uni += Universidad.EClases.Laboratorio;
			}
			catch (SinProfesorException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion,"Debería haberse producido una excepción SinProfesorException ya que no hay profesores de Laboratorio.");

			seProdujoLaExcepcion = false;

			try
			{
				Profesor profe = uni != Universidad.EClases.Legislacion;
			}
			catch (SinProfesorException )
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Debería haberse producido una excepción SinProfesorException ya que no hay profesores que no den Legislación.");
		}
		/// <summary>
		/// Verifica que la excepción ArchivosException sea lanzada correctamente en las clases.
		/// </summary>
		[TestMethod]
		public void VerificarArchivosException()
		{
			Alumno alumno = new Alumno(10, "Javier", "Piriri", "10", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
			Alumno alumno2 = new Alumno(11, "Javier", "Piriri", "100", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
			Universidad universidad = new Universidad();
			universidad += alumno;
			universidad += alumno2;

			Texto texto = new Texto();
			Xml<Universidad> xml = new Xml<Universidad>();
			bool seProdujoLaExcepcion = false;
			string datos;

			seProdujoLaExcepcion = false;
			try
			{
				texto.Guardar("", "Hotel? Trivago");
			}
			catch (ArchivosException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Debería haberse producido una excepción de tipo ArchivosException, la ruta no es valida.");

			seProdujoLaExcepcion = false;
			try
			{
				texto.Leer("", out string variable);
			}
			catch (ArchivosException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsTrue(seProdujoLaExcepcion, "Debería haberse producido una excepción de tipo ArchivosException, la ruta no es valida.");

			seProdujoLaExcepcion = false;
			try
			{
				xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Uni.xml", universidad);
				xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Uni.xml",out universidad);
				datos = universidad.ToString();
			}
			catch (ArchivosException)
			{
				seProdujoLaExcepcion = true;
			}
			Assert.IsFalse(seProdujoLaExcepcion, "NO Debería haberse producido una excepción de tipo ArchivosException.");
		}
	}
}
