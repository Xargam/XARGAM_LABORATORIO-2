namespace Ejercicio_23
{
	partial class ConversorDinero
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
			this.txtEuro = new System.Windows.Forms.TextBox();
			this.txtDolar = new System.Windows.Forms.TextBox();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.lblEuro = new System.Windows.Forms.Label();
			this.lblDolar = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.btnEuro = new System.Windows.Forms.Button();
			this.btnDolar = new System.Windows.Forms.Button();
			this.btnPeso = new System.Windows.Forms.Button();
			this.lblEuro2 = new System.Windows.Forms.Label();
			this.lblDolar2 = new System.Windows.Forms.Label();
			this.lblPeso2 = new System.Windows.Forms.Label();
			this.txtEuroEuro = new System.Windows.Forms.TextBox();
			this.txtEuroDolar = new System.Windows.Forms.TextBox();
			this.txtEuroPeso = new System.Windows.Forms.TextBox();
			this.txtDolarEuro = new System.Windows.Forms.TextBox();
			this.txtDolarDolar = new System.Windows.Forms.TextBox();
			this.txtDolarPeso = new System.Windows.Forms.TextBox();
			this.txtPesoEuro = new System.Windows.Forms.TextBox();
			this.txtPesoDolar = new System.Windows.Forms.TextBox();
			this.txtPesoPeso = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtEuro
			// 
			this.txtEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuro.Location = new System.Drawing.Point(107, 45);
			this.txtEuro.Name = "txtEuro";
			this.txtEuro.Size = new System.Drawing.Size(160, 38);
			this.txtEuro.TabIndex = 0;
			this.txtEuro.Text = "0";
			// 
			// txtDolar
			// 
			this.txtDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDolar.Location = new System.Drawing.Point(107, 106);
			this.txtDolar.Name = "txtDolar";
			this.txtDolar.Size = new System.Drawing.Size(160, 38);
			this.txtDolar.TabIndex = 1;
			this.txtDolar.Text = "0";
			// 
			// txtPeso
			// 
			this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPeso.Location = new System.Drawing.Point(108, 170);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(160, 38);
			this.txtPeso.TabIndex = 2;
			this.txtPeso.Text = "0";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEuro.Location = new System.Drawing.Point(12, 47);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(61, 29);
			this.lblEuro.TabIndex = 3;
			this.lblEuro.Text = "Euro";
			// 
			// lblDolar
			// 
			this.lblDolar.AutoSize = true;
			this.lblDolar.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDolar.Location = new System.Drawing.Point(12, 109);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.Size = new System.Drawing.Size(71, 29);
			this.lblDolar.TabIndex = 4;
			this.lblDolar.Text = "Dólar";
			// 
			// lblPeso
			// 
			this.lblPeso.AutoSize = true;
			this.lblPeso.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso.Location = new System.Drawing.Point(12, 176);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(68, 29);
			this.lblPeso.TabIndex = 5;
			this.lblPeso.Text = "Pesos";
			// 
			// btnEuro
			// 
			this.btnEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEuro.Location = new System.Drawing.Point(280, 45);
			this.btnEuro.Name = "btnEuro";
			this.btnEuro.Size = new System.Drawing.Size(86, 38);
			this.btnEuro.TabIndex = 6;
			this.btnEuro.Text = "->";
			this.btnEuro.UseVisualStyleBackColor = true;
			this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
			// 
			// btnDolar
			// 
			this.btnDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDolar.Location = new System.Drawing.Point(280, 106);
			this.btnDolar.Name = "btnDolar";
			this.btnDolar.Size = new System.Drawing.Size(86, 38);
			this.btnDolar.TabIndex = 7;
			this.btnDolar.Text = "->";
			this.btnDolar.UseVisualStyleBackColor = true;
			this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
			// 
			// btnPeso
			// 
			this.btnPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPeso.Location = new System.Drawing.Point(280, 170);
			this.btnPeso.Name = "btnPeso";
			this.btnPeso.Size = new System.Drawing.Size(86, 38);
			this.btnPeso.TabIndex = 8;
			this.btnPeso.Text = "->";
			this.btnPeso.UseVisualStyleBackColor = true;
			this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
			// 
			// lblEuro2
			// 
			this.lblEuro2.AutoSize = true;
			this.lblEuro2.BackColor = System.Drawing.Color.Transparent;
			this.lblEuro2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEuro2.Location = new System.Drawing.Point(416, 13);
			this.lblEuro2.Name = "lblEuro2";
			this.lblEuro2.Size = new System.Drawing.Size(61, 29);
			this.lblEuro2.TabIndex = 9;
			this.lblEuro2.Text = "Euro";
			// 
			// lblDolar2
			// 
			this.lblDolar2.AutoSize = true;
			this.lblDolar2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDolar2.Location = new System.Drawing.Point(543, 13);
			this.lblDolar2.Name = "lblDolar2";
			this.lblDolar2.Size = new System.Drawing.Size(71, 29);
			this.lblDolar2.TabIndex = 10;
			this.lblDolar2.Text = "Dólar";
			// 
			// lblPeso2
			// 
			this.lblPeso2.AutoSize = true;
			this.lblPeso2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso2.Location = new System.Drawing.Point(682, 13);
			this.lblPeso2.Name = "lblPeso2";
			this.lblPeso2.Size = new System.Drawing.Size(68, 29);
			this.lblPeso2.TabIndex = 11;
			this.lblPeso2.Text = "Pesos";
			// 
			// txtEuroEuro
			// 
			this.txtEuroEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEuroEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuroEuro.Location = new System.Drawing.Point(382, 45);
			this.txtEuroEuro.Name = "txtEuroEuro";
			this.txtEuroEuro.ReadOnly = true;
			this.txtEuroEuro.Size = new System.Drawing.Size(129, 38);
			this.txtEuroEuro.TabIndex = 12;
			this.txtEuroEuro.Text = "0,00";
			// 
			// txtEuroDolar
			// 
			this.txtEuroDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEuroDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuroDolar.Location = new System.Drawing.Point(519, 45);
			this.txtEuroDolar.Name = "txtEuroDolar";
			this.txtEuroDolar.ReadOnly = true;
			this.txtEuroDolar.Size = new System.Drawing.Size(129, 38);
			this.txtEuroDolar.TabIndex = 13;
			this.txtEuroDolar.Text = "0,00";
			// 
			// txtEuroPeso
			// 
			this.txtEuroPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEuroPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuroPeso.Location = new System.Drawing.Point(655, 45);
			this.txtEuroPeso.Name = "txtEuroPeso";
			this.txtEuroPeso.ReadOnly = true;
			this.txtEuroPeso.Size = new System.Drawing.Size(129, 38);
			this.txtEuroPeso.TabIndex = 14;
			this.txtEuroPeso.Text = "0,00";
			// 
			// txtDolarEuro
			// 
			this.txtDolarEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDolarEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDolarEuro.Location = new System.Drawing.Point(382, 107);
			this.txtDolarEuro.Name = "txtDolarEuro";
			this.txtDolarEuro.ReadOnly = true;
			this.txtDolarEuro.Size = new System.Drawing.Size(129, 38);
			this.txtDolarEuro.TabIndex = 15;
			this.txtDolarEuro.Text = "0,00";
			// 
			// txtDolarDolar
			// 
			this.txtDolarDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDolarDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDolarDolar.Location = new System.Drawing.Point(519, 107);
			this.txtDolarDolar.Name = "txtDolarDolar";
			this.txtDolarDolar.ReadOnly = true;
			this.txtDolarDolar.Size = new System.Drawing.Size(129, 38);
			this.txtDolarDolar.TabIndex = 16;
			this.txtDolarDolar.Text = "0,00";
			// 
			// txtDolarPeso
			// 
			this.txtDolarPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDolarPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDolarPeso.Location = new System.Drawing.Point(655, 107);
			this.txtDolarPeso.Name = "txtDolarPeso";
			this.txtDolarPeso.ReadOnly = true;
			this.txtDolarPeso.Size = new System.Drawing.Size(129, 38);
			this.txtDolarPeso.TabIndex = 17;
			this.txtDolarPeso.Text = "0,00";
			// 
			// txtPesoEuro
			// 
			this.txtPesoEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPesoEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoEuro.Location = new System.Drawing.Point(382, 167);
			this.txtPesoEuro.Name = "txtPesoEuro";
			this.txtPesoEuro.ReadOnly = true;
			this.txtPesoEuro.Size = new System.Drawing.Size(129, 38);
			this.txtPesoEuro.TabIndex = 18;
			this.txtPesoEuro.Text = "0,00";
			// 
			// txtPesoDolar
			// 
			this.txtPesoDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPesoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoDolar.Location = new System.Drawing.Point(519, 167);
			this.txtPesoDolar.Name = "txtPesoDolar";
			this.txtPesoDolar.ReadOnly = true;
			this.txtPesoDolar.Size = new System.Drawing.Size(129, 38);
			this.txtPesoDolar.TabIndex = 19;
			this.txtPesoDolar.Text = "0,00";
			// 
			// txtPesoPeso
			// 
			this.txtPesoPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPesoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoPeso.Location = new System.Drawing.Point(654, 167);
			this.txtPesoPeso.Name = "txtPesoPeso";
			this.txtPesoPeso.ReadOnly = true;
			this.txtPesoPeso.Size = new System.Drawing.Size(129, 38);
			this.txtPesoPeso.TabIndex = 20;
			this.txtPesoPeso.Text = "0,00";
			// 
			// ConversorDinero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(800, 219);
			this.Controls.Add(this.txtPesoPeso);
			this.Controls.Add(this.txtPesoDolar);
			this.Controls.Add(this.txtPesoEuro);
			this.Controls.Add(this.txtDolarPeso);
			this.Controls.Add(this.txtDolarDolar);
			this.Controls.Add(this.txtDolarEuro);
			this.Controls.Add(this.txtEuroPeso);
			this.Controls.Add(this.txtEuroDolar);
			this.Controls.Add(this.txtEuroEuro);
			this.Controls.Add(this.lblPeso2);
			this.Controls.Add(this.lblDolar2);
			this.Controls.Add(this.lblEuro2);
			this.Controls.Add(this.btnPeso);
			this.Controls.Add(this.btnDolar);
			this.Controls.Add(this.btnEuro);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblDolar);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.txtDolar);
			this.Controls.Add(this.txtEuro);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ConversorDinero";
			this.Text = "Conversor dinero";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEuro;
		private System.Windows.Forms.TextBox txtDolar;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.Label lblDolar;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Button btnEuro;
		private System.Windows.Forms.Button btnDolar;
		private System.Windows.Forms.Button btnPeso;
		private System.Windows.Forms.Label lblEuro2;
		private System.Windows.Forms.Label lblDolar2;
		private System.Windows.Forms.Label lblPeso2;
		private System.Windows.Forms.TextBox txtEuroEuro;
		private System.Windows.Forms.TextBox txtEuroDolar;
		private System.Windows.Forms.TextBox txtEuroPeso;
		private System.Windows.Forms.TextBox txtDolarEuro;
		private System.Windows.Forms.TextBox txtDolarDolar;
		private System.Windows.Forms.TextBox txtDolarPeso;
		private System.Windows.Forms.TextBox txtPesoEuro;
		private System.Windows.Forms.TextBox txtPesoDolar;
		private System.Windows.Forms.TextBox txtPesoPeso;
	}
}

