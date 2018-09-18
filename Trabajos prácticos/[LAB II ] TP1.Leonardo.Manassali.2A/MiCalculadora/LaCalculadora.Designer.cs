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
			this.BtnConvertirABinario = new System.Windows.Forms.Button();
			this.BtnCerrar = new System.Windows.Forms.Button();
			this.BtnConvertirADecimal = new System.Windows.Forms.Button();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnOperar = new System.Windows.Forms.Button();
			this.CmbOperador = new System.Windows.Forms.ComboBox();
			this.LblResultado = new System.Windows.Forms.Label();
			this.TxtNumero2 = new System.Windows.Forms.TextBox();
			this.TxtNumero1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnConvertirABinario
			// 
			this.BtnConvertirABinario.Location = new System.Drawing.Point(14, 209);
			this.BtnConvertirABinario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.BtnConvertirABinario.Name = "BtnConvertirABinario";
			this.BtnConvertirABinario.Size = new System.Drawing.Size(294, 58);
			this.BtnConvertirABinario.TabIndex = 0;
			this.BtnConvertirABinario.Text = "Convertir a Binario";
			this.BtnConvertirABinario.UseVisualStyleBackColor = true;
			this.BtnConvertirABinario.Click += new System.EventHandler(this.BtnConvertirABinario_Click);
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.Location = new System.Drawing.Point(14, 147);
			this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(231, 45);
			this.BtnCerrar.TabIndex = 1;
			this.BtnCerrar.Text = "Cerrar";
			this.BtnCerrar.UseVisualStyleBackColor = true;
			this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
			// 
			// BtnConvertirADecimal
			// 
			this.BtnConvertirADecimal.Location = new System.Drawing.Point(318, 209);
			this.BtnConvertirADecimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.BtnConvertirADecimal.Name = "BtnConvertirADecimal";
			this.BtnConvertirADecimal.Size = new System.Drawing.Size(293, 58);
			this.BtnConvertirADecimal.TabIndex = 2;
			this.BtnConvertirADecimal.Text = "Convertir a Decimal";
			this.BtnConvertirADecimal.UseVisualStyleBackColor = true;
			this.BtnConvertirADecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Location = new System.Drawing.Point(254, 147);
			this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(118, 45);
			this.BtnLimpiar.TabIndex = 3;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// BtnOperar
			// 
			this.BtnOperar.Location = new System.Drawing.Point(380, 147);
			this.BtnOperar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.BtnOperar.Name = "BtnOperar";
			this.BtnOperar.Size = new System.Drawing.Size(231, 45);
			this.BtnOperar.TabIndex = 4;
			this.BtnOperar.Text = "Operar";
			this.BtnOperar.UseVisualStyleBackColor = true;
			this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
			// 
			// CmbOperador
			// 
			this.CmbOperador.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CmbOperador.FormattingEnabled = true;
			this.CmbOperador.Location = new System.Drawing.Point(254, 70);
			this.CmbOperador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.CmbOperador.Name = "CmbOperador";
			this.CmbOperador.Size = new System.Drawing.Size(118, 43);
			this.CmbOperador.TabIndex = 5;
			// 
			// LblResultado
			// 
			this.LblResultado.AutoEllipsis = true;
			this.LblResultado.BackColor = System.Drawing.SystemColors.ControlText;
			this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultado.Font = new System.Drawing.Font("Goudy Stout", 17.5F);
			this.LblResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LblResultado.Location = new System.Drawing.Point(14, 9);
			this.LblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblResultado.Name = "LblResultado";
			this.LblResultado.Size = new System.Drawing.Size(597, 34);
			this.LblResultado.TabIndex = 6;
			this.LblResultado.Text = "0";
			this.LblResultado.Click += new System.EventHandler(this.LblResultado_Click);
			// 
			// TxtNumero2
			// 
			this.TxtNumero2.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNumero2.Location = new System.Drawing.Point(380, 70);
			this.TxtNumero2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.TxtNumero2.Name = "TxtNumero2";
			this.TxtNumero2.Size = new System.Drawing.Size(231, 45);
			this.TxtNumero2.TabIndex = 7;
			this.TxtNumero2.Text = "0";
			this.TxtNumero2.TextChanged += new System.EventHandler(this.TxtNumero2_TextChanged);
			// 
			// TxtNumero1
			// 
			this.TxtNumero1.Font = new System.Drawing.Font("Toledo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNumero1.Location = new System.Drawing.Point(14, 70);
			this.TxtNumero1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.TxtNumero1.Name = "TxtNumero1";
			this.TxtNumero1.Size = new System.Drawing.Size(231, 45);
			this.TxtNumero1.TabIndex = 8;
			this.TxtNumero1.Text = "0";
			this.TxtNumero1.TextChanged += new System.EventHandler(this.TxtNumero1_TextChanged);
			// 
			// LaCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 281);
			this.Controls.Add(this.TxtNumero1);
			this.Controls.Add(this.TxtNumero2);
			this.Controls.Add(this.LblResultado);
			this.Controls.Add(this.CmbOperador);
			this.Controls.Add(this.BtnOperar);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.BtnConvertirADecimal);
			this.Controls.Add(this.BtnCerrar);
			this.Controls.Add(this.BtnConvertirABinario);
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

        private System.Windows.Forms.Button BtnConvertirABinario;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertirADecimal;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.ComboBox CmbOperador;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.TextBox TxtNumero1;
    }
}