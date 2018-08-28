using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
7. Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
*/

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;

            int diaActual;
            int mesActual;
            int añoActual;
            int diasVividos = 0;

            bool fecha = false;
            DateTime Time = new DateTime();

            Console.Title = "Ejercicio 07";

            

            do
            {
                Console.WriteLine("Ingrese su fecha de nacimiento:");
                Console.Write("Día: ");
                dia = int.Parse(Console.ReadLine());

                Console.Write("Mes: ");
                mes = int.Parse(Console.ReadLine());

                Console.Write("Año: ");
                año = int.Parse(Console.ReadLine());

                Time = DateTime.Now;
                diaActual = Time.Day;
                mesActual = Time.Month;
                añoActual = Time.Year;

                if( añoActual < año )
                {
                    fecha = false;
                }
                else if( añoActual == año )
                {
                    fecha = !(mes > mesActual);
                    if( mes == mesActual )
                    {
                        fecha = !(dia > diaActual);
                    }
                }
                else
                {
                    fecha = !(año < 1 || mes > 12 || mes < 1 || dia > DateTime.DaysInMonth(año, mes) || dia < 1);
                } 

                if(fecha == false )
                {
                    Console.WriteLine("La fecha ingresada no existe o es demasiado antigua.\n ");
                }
            }
            while( fecha == false );

            if( año < añoActual )
            {
                //Sumo los dias restantes del mes de nacimiento.
                diasVividos += (DateTime.DaysInMonth(año, mes) - dia);

                //Sumo los dias del año de nacimiento.
                for (int i = mes + 1; i <= 12; i++)
                {
                    diasVividos += DateTime.DaysInMonth(año, i);
                }

                //Cuento los dias del segundo año de vida hasta el anteúltimo.
                for (int i = año + 1; i < añoActual; i++)
                {
                    diasVividos += 365;
                    if (DateTime.IsLeapYear(i))
                    {
                        diasVividos++;
                    }
                }
                //Sumo los días del año actual
                for (int mesComp = 1; mesComp <= mesActual; mesComp++)
                {
                    if (mesComp == mesActual)
                    {
                        diasVividos += diaActual;
                        break;
                    }
                    diasVividos += DateTime.DaysInMonth(añoActual, mesComp);
                }
            }
            else
            {
                if( mes == mesActual )
                {
                    diasVividos = diaActual - dia;
                }
                else
                {
                    diasVividos += (DateTime.DaysInMonth(año, mes) - dia);
                    for (int i = mes+1; i <= mesActual; i++)
                    {
                        if (i == mesActual)
                        {
                            diasVividos += diaActual;
                            break;
                        }
                        diasVividos += DateTime.DaysInMonth(añoActual, i);
                    }

                }
                
            }

            Console.WriteLine("Usted ha vivido {0} días.", diasVividos);
            Console.ReadLine();
        }
    }
}
