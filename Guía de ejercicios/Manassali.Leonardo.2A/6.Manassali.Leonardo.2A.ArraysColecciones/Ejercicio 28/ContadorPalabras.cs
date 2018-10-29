using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Text;

/*
28. Generar un WindowsForm con un RichTextBox y un botón, con el siguiente formato:
Utilizar Diccionarios(Dictionary<string, int>) para realizar un contador de palabras, recorriend el texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador. Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra. Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
*/

namespace Ejercicio_28
{
	public partial class ContadorPalabras : Form
	{
		#region Constructor
		public ContadorPalabras()
		{
			InitializeComponent();
		}
		#endregion

		#region Metodos
		private void btn_Click(object sender, System.EventArgs e)
		{
			int maxValue = 0;
			string maxValueKey = "";

			List<string> claves = new List<string>();
			List<string> clavesOrdenadas = new List<string>();
			Dictionary<string, int> diccionarioOrdenado = new Dictionary<string, int>();
			Dictionary<string, int> diccionario = new Dictionary<string, int>();
			string texto = this.rtbTexto.Text;
			StringBuilder datos = new StringBuilder();

			//Elimino espacios de mas.
			texto = texto.Trim();
			while ( texto.Contains("  ") )
			{
				texto = texto.Replace("  ", " ");
			}
			//Recorro las palabras y determino el valor de su contador
			foreach ( string palabra in texto.Split() )
			{
				if ( palabra != "" )
				{
					if ( diccionario.ContainsKey(palabra) )
					{
						diccionario[palabra]++;
					}
					else
					{
						diccionario.Add(palabra, 1);
						//Guardo la palabra en lista para poder recorrer el diccionario.
						claves.Add(palabra);
					}
				}
			}
			while ( diccionario.Count > 0 )
			{
				//Recorro el diccionario determinando el valor mas grande con su clave asociada
				foreach ( string item in claves )
				{
					if ( diccionario[item] > maxValue )
					{
						maxValue = diccionario[item];
						maxValueKey = item;
					}
				}
				//Elimino de lista para que dicha clave no se reconsidere como una posible
				claves.Remove(maxValueKey);
				//Agrego a las claves ordenadas la palabra asociada al valor mas grande
				clavesOrdenadas.Add(maxValueKey);
				//Elimino la clave y el valor del diccionario para que el contador de elementos baje
				diccionario.Remove(maxValueKey);
				//Agrego el valor y la clave a un diccionario ordenado de manera descendente
				diccionarioOrdenado.Add(maxValueKey, maxValue);
				maxValue = 0;
			}

			//Recorro el diccionario ordenado y almaceno su contenido para mostrarlo
			datos.AppendLine("Palabra | Cantidad");
			for ( int i = 0 ; i < 3 ; i++ )
			{
				datos.AppendLine(string.Format("{0}\t   {1}", clavesOrdenadas[i], diccionarioOrdenado[clavesOrdenadas[i]]));
			}
			MessageBox.Show(datos.ToString());
		} 
		#endregion
	}
}
