namespace Ejercicio_63
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
            this.lblHora = new System.Windows.Forms.Label();
            this.rtbActivarReloj = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(110, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00/00/0000 00:00:00";
            // 
            // rtbActivarReloj
            // 
            this.rtbActivarReloj.Font = new System.Drawing.Font("Vijaya", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbActivarReloj.Location = new System.Drawing.Point(12, 40);
            this.rtbActivarReloj.Name = "rtbActivarReloj";
            this.rtbActivarReloj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbActivarReloj.Size = new System.Drawing.Size(504, 398);
            this.rtbActivarReloj.TabIndex = 1;
            this.rtbActivarReloj.Text = "Haga click aquí para activar el reloj.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.rtbActivarReloj);
            this.Controls.Add(this.lblHora);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.RichTextBox rtbActivarReloj;
    }
}

