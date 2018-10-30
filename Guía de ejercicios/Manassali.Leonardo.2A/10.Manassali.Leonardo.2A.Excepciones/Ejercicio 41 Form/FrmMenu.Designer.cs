namespace Ejercicio_41_Form
{
	partial class FrmMenu
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
			if ( disposing && (components != null) )
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnGenerarLlamada = new System.Windows.Forms.Button();
			this.btnFacturacionTotal = new System.Windows.Forms.Button();
			this.btnFacturacionLocal = new System.Windows.Forms.Button();
			this.btnFacturacionProvincial = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGenerarLlamada
			// 
			this.btnGenerarLlamada.Location = new System.Drawing.Point(12, 24);
			this.btnGenerarLlamada.Name = "btnGenerarLlamada";
			this.btnGenerarLlamada.Size = new System.Drawing.Size(234, 48);
			this.btnGenerarLlamada.TabIndex = 0;
			this.btnGenerarLlamada.Text = "Generar Llamada";
			this.btnGenerarLlamada.UseVisualStyleBackColor = true;
			this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
			// 
			// btnFacturacionTotal
			// 
			this.btnFacturacionTotal.Location = new System.Drawing.Point(12, 78);
			this.btnFacturacionTotal.Name = "btnFacturacionTotal";
			this.btnFacturacionTotal.Size = new System.Drawing.Size(234, 48);
			this.btnFacturacionTotal.TabIndex = 1;
			this.btnFacturacionTotal.Text = "Facturación Total";
			this.btnFacturacionTotal.UseVisualStyleBackColor = true;
			this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
			// 
			// btnFacturacionLocal
			// 
			this.btnFacturacionLocal.Location = new System.Drawing.Point(12, 132);
			this.btnFacturacionLocal.Name = "btnFacturacionLocal";
			this.btnFacturacionLocal.Size = new System.Drawing.Size(234, 48);
			this.btnFacturacionLocal.TabIndex = 2;
			this.btnFacturacionLocal.Text = "Facturación Local";
			this.btnFacturacionLocal.UseVisualStyleBackColor = true;
			this.btnFacturacionLocal.Click += new System.EventHandler(this.btnFacturacionLocal_Click);
			// 
			// btnFacturacionProvincial
			// 
			this.btnFacturacionProvincial.Location = new System.Drawing.Point(12, 186);
			this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
			this.btnFacturacionProvincial.Size = new System.Drawing.Size(234, 48);
			this.btnFacturacionProvincial.TabIndex = 3;
			this.btnFacturacionProvincial.Text = "Facturación Provincial";
			this.btnFacturacionProvincial.UseVisualStyleBackColor = true;
			this.btnFacturacionProvincial.Click += new System.EventHandler(this.btnFacturacionProvincial_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(12, 240);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(234, 48);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 308);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnFacturacionProvincial);
			this.Controls.Add(this.btnFacturacionLocal);
			this.Controls.Add(this.btnFacturacionTotal);
			this.Controls.Add(this.btnGenerarLlamada);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Central telefónica";
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnGenerarLlamada;
		private System.Windows.Forms.Button btnFacturacionTotal;
		private System.Windows.Forms.Button btnFacturacionLocal;
		private System.Windows.Forms.Button btnFacturacionProvincial;
		private System.Windows.Forms.Button btnSalir;
	}
}