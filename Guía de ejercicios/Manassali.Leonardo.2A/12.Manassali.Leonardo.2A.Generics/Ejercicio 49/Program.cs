using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_49
{
	class Program
	{
		static void Main(string[] args)
		{
			Competencia<AutoF1> competencia = new Competencia<AutoF1>(4, 2);
			Competencia<MotoCross> competencia2 = new Competencia<MotoCross>(4, 3);
			Competencia<VehiculoDeCarrera> competencia3 = new Competencia<VehiculoDeCarrera>(45,2);
			VehiculoDeCarrera vehiculoDeCarrera1 = new VehiculoDeCarrera(85, "trivago");
			VehiculoDeCarrera vehiculoDeCarrera2 = new VehiculoDeCarrera(86, "trivagou");
			if (competencia3 + vehiculoDeCarrera1) ;
			if (competencia3 + vehiculoDeCarrera2) ;
			if (competencia3 - vehiculoDeCarrera1) ;
			Console.WriteLine(competencia3.MostrarDatos() );

			MotoCross m1 = new MotoCross(5, "a");
			MotoCross m2 = new MotoCross(5, "a");
			MotoCross m3 = new MotoCross(5, "a");
			MotoCross m4 = new MotoCross(5, "a");

			if( competencia2 + m1 );
			if( competencia2 + m2 );
			if( competencia2 + m3 );
			if( competencia2 + m4 );
			if (competencia2 - m1) ; //El - quita instancias iguales, no se puede corregir con los metodos que se tiene en el tp

			Console.WriteLine(competencia2.MostrarDatos());
			Console.ReadKey();
			Console.Clear();


			AutoF1 a1 = new AutoF1(4, "dd");
			AutoF1 a2 = new AutoF1(5, "dc");
			AutoF1 a3 = new AutoF1(6, "db");
			AutoF1 a4 = new AutoF1(7, "da");

			if( competencia + a1);
			if( competencia + a2);
			if( competencia + a3);
			if( competencia + a3);
			if (competencia - a1);

			Console.WriteLine(competencia.MostrarDatos());
			Console.ReadKey();
		}
	}
}
