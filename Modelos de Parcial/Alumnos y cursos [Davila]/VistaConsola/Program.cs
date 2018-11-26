using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Genero un nuevo curso
			Curso curso = new Curso(2, Divisiones.A, new Profesor("Fede", "Davila", "12345678", new DateTime(2015, 03, 20) ));

			// Genero alumnos ...
			Alumno a1 = new Alumno("Juan", "Lopez", "22-3333-2", 2, Divisiones.A);
			Alumno a2 = new Alumno("Jose", "Martinez", "23-3343-6", 2, Divisiones.B);
			Alumno a3 = new Alumno("Maria", "Gutierrez", "22-3333-2", 2, Divisiones.A);
			Alumno a4 = new Alumno("Marta", "Rodriguez", "23-3343-6", 2, Divisiones.A);
			Alumno a5 = new Alumno("Marta", "Rodriguez", "233343126", 2, Divisiones.A);

			// ... Y los agrego al curso

			curso += a1;
			curso += a2;
			curso += a3;
			curso += a4;
			curso += a5;

			// Imprimo los datos del curso

			Console.WriteLine((string)curso);
			Console.ReadKey();

		}
	}
}
