namespace Clase08
{
	partial class FrmPaleta
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtColores = new System.Windows.Forms.TextBox();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnMenos = new System.Windows.Forms.Button();
			this.grpColores = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.grpColores.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtColores
			// 
			this.txtColores.Location = new System.Drawing.Point(6, 19);
			this.txtColores.Multiline = true;
			this.txtColores.Name = "txtColores";
			this.txtColores.ReadOnly = true;
			this.txtColores.Size = new System.Drawing.Size(437, 109);
			this.txtColores.TabIndex = 0;
			this.txtColores.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnMas
			// 
			this.btnMas.Location = new System.Drawing.Point(6, 134);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(75, 23);
			this.btnMas.TabIndex = 1;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
			// 
			// btnMenos
			// 
			this.btnMenos.Location = new System.Drawing.Point(368, 134);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(75, 23);
			this.btnMenos.TabIndex = 2;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			// 
			// grpColores
			// 
			this.grpColores.Controls.Add(this.btnOrdenar);
			this.grpColores.Controls.Add(this.comboBox1);
			this.grpColores.Controls.Add(this.txtColores);
			this.grpColores.Controls.Add(this.btnMas);
			this.grpColores.Controls.Add(this.btnMenos);
			this.grpColores.Location = new System.Drawing.Point(12, 39);
			this.grpColores.Name = "grpColores";
			this.grpColores.Size = new System.Drawing.Size(449, 163);
			this.grpColores.TabIndex = 3;
			this.grpColores.TabStop = false;
			this.grpColores.Text = "Paleta de colores";
			this.grpColores.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(473, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPaletaToolStripMenuItem});
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.inicioToolStripMenuItem.Text = "Inicio";
			// 
			// agregarPaletaToolStripMenuItem
			// 
			this.agregarPaletaToolStripMenuItem.Name = "agregarPaletaToolStripMenuItem";
			this.agregarPaletaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.agregarPaletaToolStripMenuItem.Text = "Agregar Paleta";
			this.agregarPaletaToolStripMenuItem.Click += new System.EventHandler(this.agregarPaletaToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(187, 135);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(153, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(107, 134);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btnOrdenar.TabIndex = 6;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
			// 
			// FrmPaleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 228);
			this.Controls.Add(this.grpColores);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPaleta";
			this.Text = "Paleta de colores";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpColores.ResumeLayout(false);
			this.grpColores.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtColores;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.GroupBox grpColores;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarPaletaToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnOrdenar;
	}
}

