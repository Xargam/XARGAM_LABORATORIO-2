using System;

/*
7. Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
*/

namespace Ejercicio_07
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int dia;
			int mes;
			int año;
			TimeSpan diasVividos;
			DateTime fechaNacimiento;
			DateTime fechaActual;

			Console.Title = "Ejercicio 07";

			Console.WriteLine("--Ingrese su fecha de nacimiento--\n");
			Console.Write("Día: ");
			dia = int.Parse(Console.ReadLine());
			Console.Write("Mes: ");
			mes = int.Parse(Console.ReadLine());
			Console.Write("Año: ");
			año = int.Parse(Console.ReadLine());

			fechaNacimiento = new DateTime(año, mes, dia);
			fechaActual = DateTime.Now;

			if (fechaNacimiento.CompareTo(DateTime.Now) < 0 && fechaNacimiento.Year > 0)
			{
				diasVividos = fechaActual - fechaNacimiento;
				Console.WriteLine("Usted vivio {0} dias.", (Int64)diasVividos.TotalDays);
			}
			else
			{
				Console.WriteLine("No ingreso una fecha valida.");
			}
			Console.ReadLine();
		}
	}
}
