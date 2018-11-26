namespace VistaForm
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
			this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.lblDivisionCurso = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAnioCurso = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gpbDatosCurso.SuspendLayout();
			this.gpbDatosAlumno.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbDatosCurso
			// 
			this.gpbDatosCurso.Controls.Add(this.lblAnioCurso);
			this.gpbDatosCurso.Controls.Add(this.label5);
			this.gpbDatosCurso.Controls.Add(this.lblDocumento);
			this.gpbDatosCurso.Controls.Add(this.lblApellido);
			this.gpbDatosCurso.Controls.Add(this.lblNombre);
			this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
			this.gpbDatosCurso.Controls.Add(this.btnMostrar);
			this.gpbDatosCurso.Controls.Add(this.btnCrear);
			this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
			this.gpbDatosCurso.Name = "gpbDatosCurso";
			this.gpbDatosCurso.Size = new System.Drawing.Size(371, 224);
			this.gpbDatosCurso.TabIndex = 0;
			this.gpbDatosCurso.TabStop = false;
			this.gpbDatosCurso.Text = "Datos Curso";
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(6, 178);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(91, 40);
			this.btnCrear.TabIndex = 0;
			this.btnCrear.Text = "Crear Curso";
			this.btnCrear.UseVisualStyleBackColor = true;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(274, 178);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(91, 40);
			this.btnMostrar.TabIndex = 1;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			// 
			// gpbDatosAlumno
			// 
			this.gpbDatosAlumno.Controls.Add(this.label1);
			this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
			this.gpbDatosAlumno.Location = new System.Drawing.Point(389, 12);
			this.gpbDatosAlumno.Name = "gpbDatosAlumno";
			this.gpbDatosAlumno.Size = new System.Drawing.Size(399, 224);
			this.gpbDatosAlumno.TabIndex = 2;
			this.gpbDatosAlumno.TabStop = false;
			this.gpbDatosAlumno.Text = "Datos Alumno";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(302, 178);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(91, 40);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// lblDivisionCurso
			// 
			this.lblDivisionCurso.AutoSize = true;
			this.lblDivisionCurso.Location = new System.Drawing.Point(6, 48);
			this.lblDivisionCurso.Name = "lblDivisionCurso";
			this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
			this.lblDivisionCurso.TabIndex = 2;
			this.lblDivisionCurso.Text = "Division";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(6, 72);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(6, 96);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(44, 13);
			this.lblApellido.TabIndex = 4;
			this.lblApellido.Text = "Apellido";
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.Location = new System.Drawing.Point(6, 122);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(26, 13);
			this.lblDocumento.TabIndex = 5;
			this.lblDocumento.Text = "DNI";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "label5";
			// 
			// lblAnioCurso
			// 
			this.lblAnioCurso.AutoSize = true;
			this.lblAnioCurso.Location = new System.Drawing.Point(6, 26);
			this.lblAnioCurso.Name = "lblAnioCurso";
			this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
			this.lblAnioCurso.TabIndex = 7;
			this.lblAnioCurso.Text = "Año";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nombre";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gpbDatosAlumno);
			this.Controls.Add(this.gpbDatosCurso);
			this.Name = "Form1";
			this.Text = "Vista del curso";
			this.gpbDatosCurso.ResumeLayout(false);
			this.gpbDatosCurso.PerformLayout();
			this.gpbDatosAlumno.ResumeLayout(false);
			this.gpbDatosAlumno.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gpbDatosCurso;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblAnioCurso;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblDocumento;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblDivisionCurso;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.GroupBox gpbDatosAlumno;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label1;
	}
}

