using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrera;

namespace Ejercicio_30
{
	public class Program
	{
		static void Main(string[] args)
		{
			AutoF1 autoF1 = new AutoF1(1,"da");
			AutoF1 autoF2 = new AutoF1(3,"dc");
			AutoF1 autoF3 = new AutoF1(4,"dd");
			AutoF1 autoF4 = new AutoF1(5,"de");
			Competencia competencia = new Competencia(10, 3);
			if (competencia + autoF1 )
			{
				if( (competencia + autoF2) )
				{
					if ((competencia + autoF3))
					{
						if(!(competencia + autoF4))
							Console.WriteLine(competencia.MostrarDatos());
					}
						
				}
			}
			Console.ReadLine();
		}
	}
}
