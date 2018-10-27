using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
8. Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
trabajadas en el mes de ‗n‘ empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.
*/

namespace Ejercicio_08
{
	public class Program
	{
		public static void Main(string[] args)
		{
			byte quit = 1;
			string nombre;
			int antiguedad;
			int horasTrabajdas;

			float valorHora;
			float sueldo;
			float descuento;

			Console.Title = "Ejercicio 08";

			do
			{
				Console.WriteLine("Ingrese el nombre del empleado:");
				nombre = Console.ReadLine();
				do
				{
					Console.WriteLine("Ingrese el valor hora:");
					valorHora = float.Parse(Console.ReadLine());
					if (valorHora < 1)
					{
						Console.WriteLine("ERROR: valor hora incorrecto.");
					}
				}
				while (valorHora < 1);

				do
				{
					Console.WriteLine("Ingrese antiguedad del empleado (años):");
					antiguedad = int.Parse(Console.ReadLine());
					if (antiguedad < 0)
					{
						Console.WriteLine("ERROR: antiguedad incorrecta.");
					}
				}
				while (antiguedad < 0);

				do
				{
					Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes:");
					horasTrabajdas = int.Parse(Console.ReadLine());
					if (antiguedad < 0)
					{
						Console.WriteLine("ERROR: cantidad de horas trabajadas incorrecta.");
					}
				}
				while (horasTrabajdas < 0);

				//Calculo el total $ del mes.
				sueldo = valorHora * horasTrabajdas;

				//Sumo el pago por antiguedad.
				sueldo += antiguedad * 150;

				//Aplico descuento de 13%.
				descuento = sueldo * 0.13F;

				Console.WriteLine("------Datos del empleado------\n");
				Console.WriteLine("Nombre: {0} .", nombre);
				Console.WriteLine("Antiguedad: {0} .", antiguedad);
				Console.WriteLine("Valor hora: {0} .", valorHora);
				Console.WriteLine("Cobro bruto: {0} .", sueldo);

				sueldo -= descuento;
				Console.WriteLine("Descuentos: {0} .", descuento);
				Console.WriteLine("Cobro neto: {0} .", sueldo);

				Console.WriteLine("Para salir ingrese 0 u otro número continuar.");
				quit = Byte.Parse(Console.ReadLine());
				Console.Clear();
			}
			while (quit != 0);
			Console.Clear();
			Console.Write("Programa terminado.");
			Console.ReadLine();
		}
	}
}
