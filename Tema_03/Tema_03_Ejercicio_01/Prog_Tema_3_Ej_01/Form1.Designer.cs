namespace Prog_Tema_3_Ej_01
{
    partial class Prog_Tema_3_Ej_01
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
			this.txtDato = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDato
			// 
			this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDato.Location = new System.Drawing.Point(143, 126);
			this.txtDato.Name = "txtDato";
			this.txtDato.Size = new System.Drawing.Size(87, 35);
			this.txtDato.TabIndex = 0;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.Brown;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.White;
			this.btnAccion.Location = new System.Drawing.Point(97, 178);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(186, 62);
			this.btnAccion.TabIndex = 1;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(100, 255);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(99, 25);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(61, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(304, 66);
			this.lblTitulo.TabIndex = 3;
			this.lblTitulo.Text = "¿Es el \'2\'?";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(92, 84);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(191, 25);
			this.lblSubtitulo.TabIndex = 4;
			this.lblSubtitulo.Text = "Introduce un número";
			// 
			// Prog_Tema_3_Ej_01
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(408, 349);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtDato);
			this.Name = "Prog_Tema_3_Ej_01";
			this.Text = "Prog_Tema_3_Ej_01";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		}
}

