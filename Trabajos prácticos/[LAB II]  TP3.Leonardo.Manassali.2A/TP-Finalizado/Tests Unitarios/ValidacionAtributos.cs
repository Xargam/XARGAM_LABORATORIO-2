using EntidadesAbstractas;
using EntidadesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsUnitarios
{
	[TestClass]
	public class ValidacionAtributos
	{
		/// <summary>
		/// Verifica que los atributos de la clase Alumno no sean nulos inesperadamente.
		/// </summary>
		[TestMethod]
		public void VerificarAtributosNulosAlumnos()
		{
			Alumno a1 = new Alumno(4, "Laura", "Esperanto", "1010", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
			
			//Verificación de atributos del Alumno. No deben ser null ya que fueron correctamente cargados.
			Assert.IsNotNull(a1.Apellido,"Apellido no debería ser nulo.");
			Assert.IsNotNull(a1.Nombre,"Nombre no debería ser nulo.");
			Assert.AreNotEqual(a1.DNI, 0,"DNI no debería ser 0.");

			Alumno a3 = new Alumno(14, "123", "123", "44", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
			//Verifico que atributos erroneos se guarden con null.
			Assert.AreEqual(a3.Apellido,"","Apellido fue mal cargado debería quedar en null.");
			Assert.AreEqual(a3.Nombre,"","Nombre fue mal cargado debería quedar en null.");
		}
		/// <summary>
		/// Verifica que los atributos de la clase Profesor no sean nulos inesperadamente.
		/// </summary>
		[TestMethod]
		public void VerificarAtributosNulosProfesor()
		{
			Profesor p1 = new Profesor(4, "Maria", "Bibin", "1010", Persona.ENacionalidad.Argentino);

			//Verificación de atributos del profesor. No deben ser null ya que fueron correctamente cargados.
			Assert.IsNotNull(p1.Apellido,"Apellido no debería ser nulo.");
			Assert.IsNotNull(p1.Nombre,"Nombre no debería ser nulo.");
			Assert.AreNotEqual(p1.DNI, 0, "DNI no debería ser 0.");

			Profesor p2 = new Profesor(14, "123", "123", "44", Persona.ENacionalidad.Argentino);
			//Verifico que atributos erroneos se guarden con null.
			Assert.AreEqual(p2.Apellido,"", "Apellido fue mal cargado debería quedar en null.");
			Assert.AreEqual(p2.Nombre,"","Nombre fue mal cargado debería quedar en null.");
		}
		/// <summary>
		/// Verifica que los atributos de la clase Jornada no sean nulos inesperadamente.
		/// </summary>
		[TestMethod]
		public void VerificarAtributosNulosJornada()
		{
			Profesor profesor = new Profesor(4, "Maria", "Bibin", "1010", Persona.ENacionalidad.Argentino);
			Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, null);
			Jornada jornada2 = new Jornada(Universidad.EClases.Laboratorio, profesor);

			Assert.IsNotNull(jornada2.Alumnos, "Alumnos jornada2 no debería ser null.");
			Assert.IsNotNull(jornada2.Instructor, "Instructor jornada2 no debería ser null.");

			Assert.IsNotNull(jornada.Alumnos,"Alumnos jornada no debería ser nulo.");
			Assert.IsNull(jornada.Instructor, "Profesor jornada debería ser nulo.");
			try
			{
				string jor = jornada.ToString();
				Console.WriteLine(jornada);
			}
			catch (Exception)
			{
				Assert.Fail("No debería producirse una excepcion si intenta mostrar una jornada con un profesor nulo.");
			}
		}
		/// <summary>
		/// Verifica que los atributos de la clase Universidad no sean nulos inesperadamente.
		/// </summary>
		[TestMethod]
		public void VerificarAtributosNulosUniversidad()
		{
			Universidad uni = new Universidad();
			Assert.IsNotNull(uni.Alumnos, "Alumnos no debería ser null.");
			Assert.IsNotNull(uni.Instructores, "Instructores no debería ser null.");
			Assert.IsNotNull(uni.Jornadas, "Jornadas no debería ser null.");
		}
	}
}
