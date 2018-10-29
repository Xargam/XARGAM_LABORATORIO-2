namespace Ejercicio_28
{
	partial class ContadorPalabras
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
			this.rtbTexto = new System.Windows.Forms.RichTextBox();
			this.btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbTexto
			// 
			this.rtbTexto.Location = new System.Drawing.Point(12, 12);
			this.rtbTexto.Name = "rtbTexto";
			this.rtbTexto.Size = new System.Drawing.Size(543, 256);
			this.rtbTexto.TabIndex = 0;
			this.rtbTexto.Text = "";
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(480, 274);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(75, 23);
			this.btn.TabIndex = 1;
			this.btn.Text = "Calcular";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// ContadorPalabras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 309);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.rtbTexto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ContadorPalabras";
			this.Text = "Contador de palabras";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbTexto;
		private System.Windows.Forms.Button btn;
	}
}

