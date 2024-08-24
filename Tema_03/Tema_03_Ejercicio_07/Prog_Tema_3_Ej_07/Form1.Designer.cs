namespace Prog_Tema_3_Ej_07
{
    partial class Prog_Tema_3_Ej_07
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
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(36, 103);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 26);
			this.txtNumero.TabIndex = 1;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.MistyRose;
			this.btnAccion.Location = new System.Drawing.Point(238, 100);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(100, 36);
			this.btnAccion.TabIndex = 2;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(36, 152);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(21, 20);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "...";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(36, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(302, 29);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Práctica con Switch case";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Location = new System.Drawing.Point(36, 67);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(228, 20);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce un número del 0 al 9:";
			// 
			// Prog_Tema_3_Ej_07
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(399, 206);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNumero);
			this.Name = "Prog_Tema_3_Ej_07";
			this.Text = "Prog_Tema_3_Ej_07";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		}
}

