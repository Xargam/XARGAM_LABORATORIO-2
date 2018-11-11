using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class TextEditor : Form
    {
        private string _lastFilePath;

        public TextEditor()
        {
            InitializeComponent();
            //Seteo rich txt box como acoplado
            this.richTextBox1.Dock = DockStyle.Fill;
            //Inicializo status
            this.toolStripStatusLabel1.Text = "0 caracteres";
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.guardarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.guardarComoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Mayús+S";

            this.abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.richTextBox1.TextLength.ToString() + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileMenu = new OpenFileDialog();

            //Seteo preferido de propiedades.
            openFileMenu.Title = "Abrir archivo";
            openFileMenu.RestoreDirectory = true;
            openFileMenu.Multiselect = false;
            openFileMenu.Filter = "txt| *.txt";
            openFileMenu.DefaultExt = "*.txt";
            openFileMenu.AddExtension = true;

            //Lectura del archivo.
            if ( openFileMenu.ShowDialog() == DialogResult.OK)
            {
                this._lastFilePath = openFileMenu.FileName;
                StreamReader archivo = new StreamReader(this._lastFilePath);
                this.richTextBox1.Text = archivo.ReadToEnd();
                archivo.Close();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileMenu = new SaveFileDialog();
            saveFileMenu.Title = "Guardar archivo";
            saveFileMenu.Filter = "txt| *.txt";
            saveFileMenu.DefaultExt = "*.txt";
            saveFileMenu.AddExtension = true;
            saveFileMenu.RestoreDirectory = true;

            if (saveFileMenu.ShowDialog() == DialogResult.OK)
            {
                this._lastFilePath = saveFileMenu.FileName;
                StreamWriter archivo = new StreamWriter(this._lastFilePath);
                archivo.WriteLine(this.richTextBox1.Text.Replace("\n", "\r\n"));
                archivo.Close();
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(this._lastFilePath) )
            {
                this.guardarComoToolStripMenuItem_Click(this.guardarComoToolStripMenuItem,new EventArgs());
            }
            else
            {
                StreamWriter archivo = new StreamWriter(this._lastFilePath);
                archivo.WriteLine(this.richTextBox1.Text.Replace("\n", "\r\n"));
                archivo.Close();
            }
            
        }
    }
}
