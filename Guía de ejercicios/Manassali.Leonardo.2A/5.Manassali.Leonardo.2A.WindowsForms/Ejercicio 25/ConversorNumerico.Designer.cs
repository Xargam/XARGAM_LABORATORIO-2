namespace Ejercicio_25
{
	partial class ConversorNumerico
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
			this.txtBinarioDecimal = new System.Windows.Forms.TextBox();
			this.txtDecimalBinario = new System.Windows.Forms.TextBox();
			this.lblDecimalBinario = new System.Windows.Forms.Label();
			this.lblBinarioDecimal = new System.Windows.Forms.Label();
			this.btnBinarioDecimalbtnBinarioDecimal = new System.Windows.Forms.Button();
			this.btnDecimalBinario = new System.Windows.Forms.Button();
			this.txtDecimal = new System.Windows.Forms.TextBox();
			this.txtBinario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBinarioDecimal
			// 
			this.txtBinarioDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBinarioDecimal.Location = new System.Drawing.Point(135, 26);
			this.txtBinarioDecimal.Name = "txtBinarioDecimal";
			this.txtBinarioDecimal.Size = new System.Drawing.Size(100, 20);
			this.txtBinarioDecimal.TabIndex = 0;
			this.txtBinarioDecimal.Text = "0";
			// 
			// txtDecimalBinario
			// 
			this.txtDecimalBinario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDecimalBinario.Location = new System.Drawing.Point(135, 61);
			this.txtDecimalBinario.Name = "txtDecimalBinario";
			this.txtDecimalBinario.Size = new System.Drawing.Size(100, 20);
			this.txtDecimalBinario.TabIndex = 1;
			this.txtDecimalBinario.Text = "0";
			// 
			// lblDecimalBinario
			// 
			this.lblDecimalBinario.AutoSize = true;
			this.lblDecimalBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDecimalBinario.Location = new System.Drawing.Point(13, 61);
			this.lblDecimalBinario.Name = "lblDecimalBinario";
			this.lblDecimalBinario.Size = new System.Drawing.Size(117, 17);
			this.lblDecimalBinario.TabIndex = 2;
			this.lblDecimalBinario.Text = "Decimal a binario";
			// 
			// lblBinarioDecimal
			// 
			this.lblBinarioDecimal.AutoSize = true;
			this.lblBinarioDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBinarioDecimal.Location = new System.Drawing.Point(13, 26);
			this.lblBinarioDecimal.Name = "lblBinarioDecimal";
			this.lblBinarioDecimal.Size = new System.Drawing.Size(116, 17);
			this.lblBinarioDecimal.TabIndex = 3;
			this.lblBinarioDecimal.Text = "Binario a decimal";
			// 
			// btnBinarioDecimalbtnBinarioDecimal
			// 
			this.btnBinarioDecimalbtnBinarioDecimal.Location = new System.Drawing.Point(241, 26);
			this.btnBinarioDecimalbtnBinarioDecimal.Name = "btnBinarioDecimalbtnBinarioDecimal";
			this.btnBinarioDecimalbtnBinarioDecimal.Size = new System.Drawing.Size(49, 23);
			this.btnBinarioDecimalbtnBinarioDecimal.TabIndex = 4;
			this.btnBinarioDecimalbtnBinarioDecimal.Text = "->";
			this.btnBinarioDecimalbtnBinarioDecimal.UseVisualStyleBackColor = true;
			this.btnBinarioDecimalbtnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimalbtnBinarioDecimal_Click);
			// 
			// btnDecimalBinario
			// 
			this.btnDecimalBinario.Location = new System.Drawing.Point(241, 59);
			this.btnDecimalBinario.Name = "btnDecimalBinario";
			this.btnDecimalBinario.Size = new System.Drawing.Size(49, 23);
			this.btnDecimalBinario.TabIndex = 5;
			this.btnDecimalBinario.Text = "->";
			this.btnDecimalBinario.UseVisualStyleBackColor = true;
			this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
			// 
			// txtDecimal
			// 
			this.txtDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDecimal.Location = new System.Drawing.Point(296, 28);
			this.txtDecimal.Name = "txtDecimal";
			this.txtDecimal.ReadOnly = true;
			this.txtDecimal.Size = new System.Drawing.Size(178, 20);
			this.txtDecimal.TabIndex = 6;
			this.txtDecimal.Text = "0";
			// 
			// txtBinario
			// 
			this.txtBinario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBinario.Location = new System.Drawing.Point(296, 59);
			this.txtBinario.Name = "txtBinario";
			this.txtBinario.ReadOnly = true;
			this.txtBinario.Size = new System.Drawing.Size(178, 20);
			this.txtBinario.TabIndex = 7;
			this.txtBinario.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 116);
			this.Controls.Add(this.txtBinario);
			this.Controls.Add(this.txtDecimal);
			this.Controls.Add(this.btnDecimalBinario);
			this.Controls.Add(this.btnBinarioDecimalbtnBinarioDecimal);
			this.Controls.Add(this.lblBinarioDecimal);
			this.Controls.Add(this.lblDecimalBinario);
			this.Controls.Add(this.txtDecimalBinario);
			this.Controls.Add(this.txtBinarioDecimal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Conversor Numérico";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBinarioDecimal;
		private System.Windows.Forms.TextBox txtDecimalBinario;
		private System.Windows.Forms.Label lblDecimalBinario;
		private System.Windows.Forms.Label lblBinarioDecimal;
		private System.Windows.Forms.Button btnBinarioDecimalbtnBinarioDecimal;
		private System.Windows.Forms.Button btnDecimalBinario;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.TextBox txtBinario;
	}
}

