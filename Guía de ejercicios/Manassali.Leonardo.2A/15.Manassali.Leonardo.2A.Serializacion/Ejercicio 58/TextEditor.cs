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
using IO;

namespace Ejercicio_56
{
    public partial class TextEditor : Form
    {
        #region Atributos
        private string _lastFilePath;
        private static SaveFileDialog _saveFileMenu;
        private static OpenFileDialog _openFileMenu;
        #endregion

        #region Constructores
        static TextEditor()
        {
            TextEditor._openFileMenu = new OpenFileDialog();
            TextEditor._saveFileMenu = new SaveFileDialog();
        }

        public TextEditor()
        {
            InitializeComponent();
            this._lastFilePath = "";
            //Seteo rich txt box como acoplado
            this.richTextBox1.Dock = DockStyle.Fill;

            //Inicializo status
            this.toolStripStatusLabel1.Text = "0 caracteres";

            //Inicializo accesos directos:
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.guardarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.guardarComoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Mayús+S";

            this.abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            //Inicializo menu de busqueda y apertura de ficheros:
            TextEditor._openFileMenu.Title = "Abrir archivo";
            TextEditor._openFileMenu.RestoreDirectory = true;
            TextEditor._openFileMenu.Multiselect = false;
            TextEditor._openFileMenu.Filter = "txt|*.txt|dat|*.dat";
            TextEditor._openFileMenu.DefaultExt = "*.txt";
            TextEditor._openFileMenu.AddExtension = true;

            //Inicializo menu de busqueda y guardado de ficheros:
            TextEditor._saveFileMenu.Title = "Guardar archivo";
            TextEditor._saveFileMenu.Filter = "txt|*.txt|dat|*.dat";
            TextEditor._saveFileMenu.DefaultExt = "*.txt";
            TextEditor._saveFileMenu.AddExtension = true;
            TextEditor._saveFileMenu.RestoreDirectory = true;
        }
        #endregion

        #region Metodos
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.richTextBox1.TextLength.ToString() + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lectura del archivo.
            PuntoTxt txt = new PuntoTxt();
            PuntoDat dat = new PuntoDat();

            if (TextEditor._openFileMenu.ShowDialog() == DialogResult.OK)
            {
                this._lastFilePath = TextEditor._openFileMenu.FileName;
                try
                {
                    if (this._lastFilePath.EndsWith(".txt"))
                    {
                        this.richTextBox1.Text = txt.Leer(this._lastFilePath);
                    }
                    else
                    {
                        this.richTextBox1.Text = dat.Leer(this._lastFilePath).Contenido;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("FATAL ERROR");
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt txt = new PuntoTxt();
            PuntoDat dat = new PuntoDat();
            string texto = this.richTextBox1.Text.Replace("\n", "\r\n");

            if (TextEditor._saveFileMenu.ShowDialog() == DialogResult.OK)
            {
                this._lastFilePath = TextEditor._saveFileMenu.FileName;
                try
                {
                    if (this._lastFilePath.EndsWith(".txt"))
                    {
                        txt.GuardarComo(this._lastFilePath, texto);
                    }
                    else
                    {
                        dat.Contenido = texto;
                        dat.GuardarComo(this._lastFilePath, dat);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("FATAL ERROR");
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt txt = new PuntoTxt();
            PuntoDat dat = new PuntoDat();
            string texto = this.richTextBox1.Text.Replace("\n", "\r\n");
            try
            {
                if (this._lastFilePath.EndsWith(".txt"))
                {
                    txt.Guardar(this._lastFilePath, texto);
                }
                else
                {
                    dat.Contenido = texto;
                    dat.Guardar(this._lastFilePath, dat);
                }

            }
            catch (ArchivoIncorrectoException)
            {
                this.guardarComoToolStripMenuItem_Click(this.guardarComoToolStripMenuItem, new EventArgs());
            }
            catch(Exception)
            {
                MessageBox.Show("FATAL ERROR");
            }
        } 
        #endregion
    }
}
