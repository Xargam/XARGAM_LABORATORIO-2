namespace MiCalculadora
{
	partial class LaCalculadora
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConvertirADecimal = new System.Windows.Forms.Button();
			this.btnConvertirABinario = new System.Windows.Forms.Button();
			this.btnOperar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConvertirADecimal
			// 
			this.btnConvertirADecimal.Location = new System.Drawing.Point(252, 227);
			this.btnConvertirADecimal.Name = "btnConvertirADecimal";
			this.btnConvertirADecimal.Size = new System.Drawing.Size(191, 43);
			this.btnConvertirADecimal.TabIndex = 0;
			this.btnConvertirADecimal.Text = "Convertir a decimal";
			this.btnConvertirADecimal.UseVisualStyleBackColor = true;
			// 
			// btnConvertirABinario
			// 
			this.btnConvertirABinario.Location = new System.Drawing.Point(12, 227);
			this.btnConvertirABinario.Name = "btnConvertirABinario";
			this.btnConvertirABinario.Size = new System.Drawing.Size(191, 43);
			this.btnConvertirABinario.TabIndex = 1;
			this.btnConvertirABinario.Text = "Convertir a binario";
			this.btnConvertirABinario.UseVisualStyleBackColor = true;
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(12, 174);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(126, 37);
			this.btnOperar.TabIndex = 2;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(165, 174);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(126, 37);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(317, 174);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(126, 37);
			this.btnCerrar.TabIndex = 4;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.Location = new System.Drawing.Point(12, 93);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(126, 53);
			this.txtNumero1.TabIndex = 5;
			this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.Location = new System.Drawing.Point(317, 93);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(126, 53);
			this.txtNumero2.TabIndex = 6;
			this.txtNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// cmbOperador
			// 
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.ItemHeight = 13;
			this.cmbOperador.Location = new System.Drawing.Point(170, 93);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(121, 21);
			this.cmbOperador.TabIndex = 7;
			this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(210, 34);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(35, 13);
			this.lblResultado.TabIndex = 8;
			this.lblResultado.Text = "label1";
			this.lblResultado.Click += new System.EventHandler(this.label1_Click);
			// 
			// LaCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 282);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.btnConvertirABinario);
			this.Controls.Add(this.btnConvertirADecimal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LaCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Leonardo Manassali de 2ºA";
			this.Load += new System.EventHandler(this.MiCalculadora_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConvertirADecimal;
		private System.Windows.Forms.Button btnConvertirABinario;
		private System.Windows.Forms.Button btnOperar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.ComboBox cmbOperador;
		private System.Windows.Forms.Label lblResultado;
	}
}