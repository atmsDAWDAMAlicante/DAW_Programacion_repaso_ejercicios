namespace Prog_Tema_4_Ej_04
{
    partial class Prog_Tema_4_Ej_04
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.txtNumeroReal = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTituloResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Purple;
			this.lblTitulo.Location = new System.Drawing.Point(71, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(286, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Real/Absoluto";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Purple;
			this.lblSubtitulo.Location = new System.Drawing.Point(63, 67);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(280, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce un número real";
			// 
			// txtNumeroReal
			// 
			this.txtNumeroReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroReal.ForeColor = System.Drawing.Color.Purple;
			this.txtNumeroReal.Location = new System.Drawing.Point(81, 111);
			this.txtNumeroReal.Name = "txtNumeroReal";
			this.txtNumeroReal.Size = new System.Drawing.Size(65, 30);
			this.txtNumeroReal.TabIndex = 1;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Purple;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.MistyRose;
			this.btnCalcular.Location = new System.Drawing.Point(163, 99);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(134, 50);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Purple;
			this.lblResultado.Location = new System.Drawing.Point(63, 205);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(108, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblTituloResultado
			// 
			this.lblTituloResultado.AutoSize = true;
			this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloResultado.ForeColor = System.Drawing.Color.Purple;
			this.lblTituloResultado.Location = new System.Drawing.Point(63, 161);
			this.lblTituloResultado.Name = "lblTituloResultado";
			this.lblTituloResultado.Size = new System.Drawing.Size(209, 25);
			this.lblTituloResultado.TabIndex = 0;
			this.lblTituloResultado.Text = "Y su valor absoltuo es:";
			// 
			// Prog_Tema_4_Ej_04
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(409, 262);
			this.Controls.Add(this.lblTituloResultado);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNumeroReal);
			this.Controls.Add(this.lblSubtitulo);
			this.Name = "Prog_Tema_4_Ej_04";
			this.Text = "Prog_Tema_4_Ej_04";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtNumeroReal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblTituloResultado;
		}
}

