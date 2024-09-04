namespace Prog_Tema_4_Ej_05_
{
    partial class Prog_Tema_4_Ej_05
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTituloResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.lblTitulo.Location = new System.Drawing.Point(24, 14);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(377, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ ¿Cuál es el Mayor?";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.txtNumero1.Location = new System.Drawing.Point(58, 81);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(60, 30);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.txtNumero2.Location = new System.Drawing.Point(305, 81);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(60, 30);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.Yellow;
			this.btnAccion.Location = new System.Drawing.Point(151, 72);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(120, 50);
			this.btnAccion.TabIndex = 3;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.lblResultado.Location = new System.Drawing.Point(58, 200);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(161, 32);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado:";
			// 
			// lblTituloResultado
			// 
			this.lblTituloResultado.AutoSize = true;
			this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloResultado.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.lblTituloResultado.Location = new System.Drawing.Point(58, 145);
			this.lblTituloResultado.Name = "lblTituloResultado";
			this.lblTituloResultado.Size = new System.Drawing.Size(179, 29);
			this.lblTituloResultado.TabIndex = 0;
			this.lblTituloResultado.Text = "Y el mayor es:";
			// 
			// Prog_Tema_4_Ej_05
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(437, 269);
			this.Controls.Add(this.lblTituloResultado);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.ForeColor = System.Drawing.Color.Olive;
			this.Name = "Prog_Tema_4_Ej_05";
			this.Text = "Prog_Tema_4_Ej_05";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTituloResultado;
		}
}

