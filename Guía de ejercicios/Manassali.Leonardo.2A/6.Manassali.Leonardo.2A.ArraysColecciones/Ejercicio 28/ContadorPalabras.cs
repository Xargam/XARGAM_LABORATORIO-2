using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System;

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
			Dictionary<string, int> diccionario = new Dictionary<string, int>();
			string texto = this.rtbTexto.Text;
			string[] keys;
			int[] values;

			if ( texto != "" )
			{
				//Elimino espacios de mas.
				texto = texto.Trim();
				while (texto.Contains("  "))
				{
					texto = texto.Replace("  ", " ");
				}
				//Recorro las palabras y determino el valor de su contador
				foreach (string palabra in texto.Split())
				{
					if (diccionario.ContainsKey(palabra))
					{
						diccionario[palabra]++;
					}
					else
					{
						diccionario.Add(palabra, 1);
					}

				}

				keys = new string[diccionario.Count];
				values = new int[diccionario.Count];
				diccionario.Keys.CopyTo(keys, 0);
				diccionario.Values.CopyTo(values, 0);
				diccionario.Clear();

				Array.Sort(values, keys);
				Array.Reverse(values);
				Array.Reverse(keys);

				texto = "TOP 3 - Palabras más repetidas\n";
				texto += "Palabra | Repeticiones\n";
				for (int i = 0; i < values.Length; i++)
				{
					diccionario.Add(keys[i], values[i]);
					if(i < 3)
					{
						texto += string.Format("{0}\t      {1}\n", keys[i], diccionario[keys[i]]);
					}
				}
				MessageBox.Show(texto);
			}
		}
		#endregion
	}
}
