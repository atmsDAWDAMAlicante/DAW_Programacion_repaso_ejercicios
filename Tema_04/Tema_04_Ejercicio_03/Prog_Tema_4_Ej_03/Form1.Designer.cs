namespace Prog_Tema_4_Ej_03
{
    partial class Prog_Tema_4_Ej_03
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.lblXigual = new System.Windows.Forms.Label();
			this.lblYigual = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(9, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(377, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Intercambio x = y";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(6, 74);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(350, 50);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce dos números y haz click para\nque cambien de valor las variables";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(113, 137);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(50, 26);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(112, 190);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(50, 26);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnCambiar
			// 
			this.btnCambiar.BackColor = System.Drawing.Color.Wheat;
			this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCambiar.Location = new System.Drawing.Point(191, 156);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(111, 40);
			this.btnCambiar.TabIndex = 3;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseVisualStyleBackColor = false;
			this.btnCambiar.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblXigual
			// 
			this.lblXigual.AutoSize = true;
			this.lblXigual.Location = new System.Drawing.Point(74, 140);
			this.lblXigual.Name = "lblXigual";
			this.lblXigual.Size = new System.Drawing.Size(33, 20);
			this.lblXigual.TabIndex = 0;
			this.lblXigual.Text = "x = ";
			// 
			// lblYigual
			// 
			this.lblYigual.AutoSize = true;
			this.lblYigual.Location = new System.Drawing.Point(74, 194);
			this.lblYigual.Name = "lblYigual";
			this.lblYigual.Size = new System.Drawing.Size(33, 20);
			this.lblYigual.TabIndex = 0;
			this.lblYigual.Text = "y = ";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(25, 249);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(138, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado:";
			// 
			// Prog_Tema_4_Ej_03
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(394, 333);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblYigual);
			this.Controls.Add(this.lblXigual);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Name = "Prog_Tema_4_Ej_03";
			this.Text = "Prog_Tema_4_Ej_03";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblXigual;
        private System.Windows.Forms.Label lblYigual;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblResultado;
		}
}

