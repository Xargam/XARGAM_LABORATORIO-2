namespace Ejercicio_24
{
	partial class Form1
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
			this.txtFahrenheit = new System.Windows.Forms.TextBox();
			this.txtCelsius = new System.Windows.Forms.TextBox();
			this.txtKelvin = new System.Windows.Forms.TextBox();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			this.lblCelcius = new System.Windows.Forms.Label();
			this.lblKelvin = new System.Windows.Forms.Label();
			this.btnFahrenheit = new System.Windows.Forms.Button();
			this.btnCelcius = new System.Windows.Forms.Button();
			this.btnKelvin = new System.Windows.Forms.Button();
			this.lblFahrenheit2 = new System.Windows.Forms.Label();
			this.lblCelcius2 = new System.Windows.Forms.Label();
			this.lblKelvin2 = new System.Windows.Forms.Label();
			this.txtFahrenheitFahrenheit = new System.Windows.Forms.TextBox();
			this.txtFahrenheitCelsius = new System.Windows.Forms.TextBox();
			this.txtFahrenheitKelvin = new System.Windows.Forms.TextBox();
			this.txtCelsiusFahrenheit = new System.Windows.Forms.TextBox();
			this.txtCelsiusCelcius = new System.Windows.Forms.TextBox();
			this.txtCelsiusKelvin = new System.Windows.Forms.TextBox();
			this.txtKelvinFahrenheit = new System.Windows.Forms.TextBox();
			this.txtKelvinCelsius = new System.Windows.Forms.TextBox();
			this.txtKelvinKelvin = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtFahrenheit
			// 
			this.txtFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFahrenheit.Location = new System.Drawing.Point(142, 45);
			this.txtFahrenheit.Name = "txtFahrenheit";
			this.txtFahrenheit.Size = new System.Drawing.Size(125, 38);
			this.txtFahrenheit.TabIndex = 0;
			this.txtFahrenheit.Text = "0";
			this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
			// 
			// txtCelsius
			// 
			this.txtCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelsius.Location = new System.Drawing.Point(142, 106);
			this.txtCelsius.Name = "txtCelsius";
			this.txtCelsius.Size = new System.Drawing.Size(125, 38);
			this.txtCelsius.TabIndex = 1;
			this.txtCelsius.Text = "0";
			this.txtCelsius.TextChanged += new System.EventHandler(this.txtDolar_TextChanged);
			// 
			// txtKelvin
			// 
			this.txtKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKelvin.Location = new System.Drawing.Point(142, 170);
			this.txtKelvin.Name = "txtKelvin";
			this.txtKelvin.Size = new System.Drawing.Size(126, 38);
			this.txtKelvin.TabIndex = 2;
			this.txtKelvin.Text = "0";
			this.txtKelvin.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.AutoSize = true;
			this.lblFahrenheit.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFahrenheit.Location = new System.Drawing.Point(12, 47);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(124, 29);
			this.lblFahrenheit.TabIndex = 3;
			this.lblFahrenheit.Text = "Fahrenheit";
			this.lblFahrenheit.Click += new System.EventHandler(this.lblEuro_Click);
			// 
			// lblCelcius
			// 
			this.lblCelcius.AutoSize = true;
			this.lblCelcius.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelcius.Location = new System.Drawing.Point(12, 109);
			this.lblCelcius.Name = "lblCelcius";
			this.lblCelcius.Size = new System.Drawing.Size(82, 29);
			this.lblCelcius.TabIndex = 4;
			this.lblCelcius.Text = "Celsius";
			this.lblCelcius.Click += new System.EventHandler(this.lblDolar_Click);
			// 
			// lblKelvin
			// 
			this.lblKelvin.AutoSize = true;
			this.lblKelvin.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKelvin.Location = new System.Drawing.Point(12, 176);
			this.lblKelvin.Name = "lblKelvin";
			this.lblKelvin.Size = new System.Drawing.Size(78, 29);
			this.lblKelvin.TabIndex = 5;
			this.lblKelvin.Text = "Kelvin";
			this.lblKelvin.Click += new System.EventHandler(this.lblPeso_Click);
			// 
			// btnFahrenheit
			// 
			this.btnFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFahrenheit.Location = new System.Drawing.Point(280, 45);
			this.btnFahrenheit.Name = "btnFahrenheit";
			this.btnFahrenheit.Size = new System.Drawing.Size(86, 38);
			this.btnFahrenheit.TabIndex = 6;
			this.btnFahrenheit.Text = "->";
			this.btnFahrenheit.UseVisualStyleBackColor = true;
			this.btnFahrenheit.Click += new System.EventHandler(this.btnEuro_Click);
			// 
			// btnCelcius
			// 
			this.btnCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCelcius.Location = new System.Drawing.Point(280, 106);
			this.btnCelcius.Name = "btnCelcius";
			this.btnCelcius.Size = new System.Drawing.Size(86, 38);
			this.btnCelcius.TabIndex = 7;
			this.btnCelcius.Text = "->";
			this.btnCelcius.UseVisualStyleBackColor = true;
			this.btnCelcius.Click += new System.EventHandler(this.btnDolar_Click);
			// 
			// btnKelvin
			// 
			this.btnKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKelvin.Location = new System.Drawing.Point(280, 170);
			this.btnKelvin.Name = "btnKelvin";
			this.btnKelvin.Size = new System.Drawing.Size(86, 38);
			this.btnKelvin.TabIndex = 8;
			this.btnKelvin.Text = "->";
			this.btnKelvin.UseVisualStyleBackColor = true;
			this.btnKelvin.Click += new System.EventHandler(this.btnPeso_Click);
			// 
			// lblFahrenheit2
			// 
			this.lblFahrenheit2.AutoSize = true;
			this.lblFahrenheit2.BackColor = System.Drawing.Color.Transparent;
			this.lblFahrenheit2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFahrenheit2.Location = new System.Drawing.Point(387, 13);
			this.lblFahrenheit2.Name = "lblFahrenheit2";
			this.lblFahrenheit2.Size = new System.Drawing.Size(124, 29);
			this.lblFahrenheit2.TabIndex = 9;
			this.lblFahrenheit2.Text = "Fahrenheit";
			// 
			// lblCelcius2
			// 
			this.lblCelcius2.AutoSize = true;
			this.lblCelcius2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelcius2.Location = new System.Drawing.Point(543, 13);
			this.lblCelcius2.Name = "lblCelcius2";
			this.lblCelcius2.Size = new System.Drawing.Size(84, 29);
			this.lblCelcius2.TabIndex = 10;
			this.lblCelcius2.Text = "Celcius";
			this.lblCelcius2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblKelvin2
			// 
			this.lblKelvin2.AutoSize = true;
			this.lblKelvin2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKelvin2.Location = new System.Drawing.Point(682, 13);
			this.lblKelvin2.Name = "lblKelvin2";
			this.lblKelvin2.Size = new System.Drawing.Size(78, 29);
			this.lblKelvin2.TabIndex = 11;
			this.lblKelvin2.Text = "Kelvin";
			// 
			// txtFahrenheitFahrenheit
			// 
			this.txtFahrenheitFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFahrenheitFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFahrenheitFahrenheit.Location = new System.Drawing.Point(382, 45);
			this.txtFahrenheitFahrenheit.Name = "txtFahrenheitFahrenheit";
			this.txtFahrenheitFahrenheit.ReadOnly = true;
			this.txtFahrenheitFahrenheit.Size = new System.Drawing.Size(129, 38);
			this.txtFahrenheitFahrenheit.TabIndex = 12;
			this.txtFahrenheitFahrenheit.Text = "0";
			this.txtFahrenheitFahrenheit.TextChanged += new System.EventHandler(this.txtEuroEuro_TextChanged);
			// 
			// txtFahrenheitCelsius
			// 
			this.txtFahrenheitCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFahrenheitCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFahrenheitCelsius.Location = new System.Drawing.Point(519, 45);
			this.txtFahrenheitCelsius.Name = "txtFahrenheitCelsius";
			this.txtFahrenheitCelsius.ReadOnly = true;
			this.txtFahrenheitCelsius.Size = new System.Drawing.Size(129, 38);
			this.txtFahrenheitCelsius.TabIndex = 13;
			this.txtFahrenheitCelsius.Text = "0";
			// 
			// txtFahrenheitKelvin
			// 
			this.txtFahrenheitKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFahrenheitKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFahrenheitKelvin.Location = new System.Drawing.Point(655, 45);
			this.txtFahrenheitKelvin.Name = "txtFahrenheitKelvin";
			this.txtFahrenheitKelvin.ReadOnly = true;
			this.txtFahrenheitKelvin.Size = new System.Drawing.Size(129, 38);
			this.txtFahrenheitKelvin.TabIndex = 14;
			this.txtFahrenheitKelvin.Text = "0";
			// 
			// txtCelsiusFahrenheit
			// 
			this.txtCelsiusFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCelsiusFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelsiusFahrenheit.Location = new System.Drawing.Point(382, 107);
			this.txtCelsiusFahrenheit.Name = "txtCelsiusFahrenheit";
			this.txtCelsiusFahrenheit.ReadOnly = true;
			this.txtCelsiusFahrenheit.Size = new System.Drawing.Size(129, 38);
			this.txtCelsiusFahrenheit.TabIndex = 15;
			this.txtCelsiusFahrenheit.Text = "0";
			// 
			// txtCelsiusCelcius
			// 
			this.txtCelsiusCelcius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCelsiusCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelsiusCelcius.Location = new System.Drawing.Point(519, 107);
			this.txtCelsiusCelcius.Name = "txtCelsiusCelcius";
			this.txtCelsiusCelcius.ReadOnly = true;
			this.txtCelsiusCelcius.Size = new System.Drawing.Size(129, 38);
			this.txtCelsiusCelcius.TabIndex = 16;
			this.txtCelsiusCelcius.Text = "0";
			// 
			// txtCelsiusKelvin
			// 
			this.txtCelsiusKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCelsiusKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelsiusKelvin.Location = new System.Drawing.Point(655, 107);
			this.txtCelsiusKelvin.Name = "txtCelsiusKelvin";
			this.txtCelsiusKelvin.ReadOnly = true;
			this.txtCelsiusKelvin.Size = new System.Drawing.Size(129, 38);
			this.txtCelsiusKelvin.TabIndex = 17;
			this.txtCelsiusKelvin.Text = "0";
			// 
			// txtKelvinFahrenheit
			// 
			this.txtKelvinFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtKelvinFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKelvinFahrenheit.Location = new System.Drawing.Point(382, 167);
			this.txtKelvinFahrenheit.Name = "txtKelvinFahrenheit";
			this.txtKelvinFahrenheit.ReadOnly = true;
			this.txtKelvinFahrenheit.Size = new System.Drawing.Size(129, 38);
			this.txtKelvinFahrenheit.TabIndex = 18;
			this.txtKelvinFahrenheit.Text = "0";
			// 
			// txtKelvinCelsius
			// 
			this.txtKelvinCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtKelvinCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKelvinCelsius.Location = new System.Drawing.Point(519, 167);
			this.txtKelvinCelsius.Name = "txtKelvinCelsius";
			this.txtKelvinCelsius.ReadOnly = true;
			this.txtKelvinCelsius.Size = new System.Drawing.Size(129, 38);
			this.txtKelvinCelsius.TabIndex = 19;
			this.txtKelvinCelsius.Text = "0";
			// 
			// txtKelvinKelvin
			// 
			this.txtKelvinKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtKelvinKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKelvinKelvin.Location = new System.Drawing.Point(654, 167);
			this.txtKelvinKelvin.Name = "txtKelvinKelvin";
			this.txtKelvinKelvin.ReadOnly = true;
			this.txtKelvinKelvin.Size = new System.Drawing.Size(129, 38);
			this.txtKelvinKelvin.TabIndex = 20;
			this.txtKelvinKelvin.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(800, 219);
			this.Controls.Add(this.txtKelvinKelvin);
			this.Controls.Add(this.txtKelvinCelsius);
			this.Controls.Add(this.txtKelvinFahrenheit);
			this.Controls.Add(this.txtCelsiusKelvin);
			this.Controls.Add(this.txtCelsiusCelcius);
			this.Controls.Add(this.txtCelsiusFahrenheit);
			this.Controls.Add(this.txtFahrenheitKelvin);
			this.Controls.Add(this.txtFahrenheitCelsius);
			this.Controls.Add(this.txtFahrenheitFahrenheit);
			this.Controls.Add(this.lblKelvin2);
			this.Controls.Add(this.lblCelcius2);
			this.Controls.Add(this.lblFahrenheit2);
			this.Controls.Add(this.btnKelvin);
			this.Controls.Add(this.btnCelcius);
			this.Controls.Add(this.btnFahrenheit);
			this.Controls.Add(this.lblKelvin);
			this.Controls.Add(this.lblCelcius);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.txtKelvin);
			this.Controls.Add(this.txtCelsius);
			this.Controls.Add(this.txtFahrenheit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Conversor de grados";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFahrenheit;
		private System.Windows.Forms.TextBox txtCelsius;
		private System.Windows.Forms.TextBox txtKelvin;
		private System.Windows.Forms.Label lblFahrenheit;
		private System.Windows.Forms.Label lblCelcius;
		private System.Windows.Forms.Label lblKelvin;
		private System.Windows.Forms.Button btnFahrenheit;
		private System.Windows.Forms.Button btnCelcius;
		private System.Windows.Forms.Button btnKelvin;
		private System.Windows.Forms.Label lblFahrenheit2;
		private System.Windows.Forms.Label lblCelcius2;
		private System.Windows.Forms.Label lblKelvin2;
		private System.Windows.Forms.TextBox txtFahrenheitFahrenheit;
		private System.Windows.Forms.TextBox txtFahrenheitCelsius;
		private System.Windows.Forms.TextBox txtFahrenheitKelvin;
		private System.Windows.Forms.TextBox txtCelsiusFahrenheit;
		private System.Windows.Forms.TextBox txtCelsiusCelcius;
		private System.Windows.Forms.TextBox txtCelsiusKelvin;
		private System.Windows.Forms.TextBox txtKelvinFahrenheit;
		private System.Windows.Forms.TextBox txtKelvinCelsius;
		private System.Windows.Forms.TextBox txtKelvinKelvin;
	}
}

