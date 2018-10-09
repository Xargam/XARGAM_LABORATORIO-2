using System.Collections.Generic;
using System.Windows.Forms;

/*
28. Generar un WindowsForm con un RichTextBox y un botón, con el siguiente formato:
Utilizar Diccionarios(Dictionary<string, int>) para realizar un contador de palabras, recorriend el texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador. Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra. Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
*/

namespace Ejercicio_28
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Click(object sender, System.EventArgs e)
		{
			Dictionary<string, int> diccionario = new Dictionary<string, int>();
			int value = 0;
			string texto = this.richTextBox1.Text;
			texto = texto.Trim();
			while (texto.Contains("  "))
			{
				texto = texto.Replace("  ", " ");
			}
			foreach (string palabra in texto.Split())
			{
				if (palabra != "")
				{
					value++;
					if (diccionario.ContainsKey(palabra))
					{
						diccionario[palabra]++;
					}
					else
					{
						diccionario.Add(palabra, 1);
					}
				}
			}
			diccionario.
			foreach (string palabra in texto.Split())
			{
				
			}

			diccionario.

			MessageBox.Show(value.ToString());

		}
	}
}
