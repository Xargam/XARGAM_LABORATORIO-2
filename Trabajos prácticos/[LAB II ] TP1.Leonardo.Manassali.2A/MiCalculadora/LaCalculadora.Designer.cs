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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaCalculadora));
			this.btnConvertirABinario = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnConvertirADecimal = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnOperar = new System.Windows.Forms.Button();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnConvertirABinario
			// 
			this.btnConvertirABinario.Location = new System.Drawing.Point(14, 212);
			this.btnConvertirABinario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnConvertirABinario.Name = "btnConvertirABinario";
			this.btnConvertirABinario.Size = new System.Drawing.Size(231, 56);
			this.btnConvertirABinario.TabIndex = 0;
			this.btnConvertirABinario.Text = "Convertir a Binario";
			this.btnConvertirABinario.UseVisualStyleBackColor = true;
			this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(14, 160);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(159, 45);
			this.btnCerrar.TabIndex = 1;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnConvertirADecimal
			// 
			this.btnConvertirADecimal.Location = new System.Drawing.Point(275, 212);
			this.btnConvertirADecimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnConvertirADecimal.Name = "btnConvertirADecimal";
			this.btnConvertirADecimal.Size = new System.Drawing.Size(231, 56);
			this.btnConvertirADecimal.TabIndex = 2;
			this.btnConvertirADecimal.Text = "Convertir a Decimal";
			this.btnConvertirADecimal.UseVisualStyleBackColor = true;
			this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(181, 160);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(159, 45);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(348, 160);
			this.btnOperar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(159, 45);
			this.btnOperar.TabIndex = 4;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
			// 
			// cmbOperador
			// 
			this.cmbOperador.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Location = new System.Drawing.Point(210, 84);
			this.cmbOperador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(102, 43);
			this.cmbOperador.TabIndex = 5;
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.SystemColors.ControlText;
			this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblResultado.Font = new System.Drawing.Font("Goudy Stout", 15F);
			this.lblResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblResultado.Location = new System.Drawing.Point(14, 9);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(492, 59);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "0";
			this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.Location = new System.Drawing.Point(348, 85);
			this.txtNumero2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(158, 45);
			this.txtNumero2.TabIndex = 7;
			this.txtNumero2.Text = "0";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.Location = new System.Drawing.Point(14, 84);
			this.txtNumero1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(159, 45);
			this.txtNumero1.TabIndex = 8;
			this.txtNumero1.Text = "0";
			this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
			// 
			// LaCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 281);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnConvertirADecimal);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnConvertirABinario);
			this.Font = new System.Drawing.Font("Toledo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LaCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Leonardo Manassali del curso 2ºA";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
    }
}