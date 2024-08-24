namespace Prog_Tema_3_Ej_05
{
    partial class Prog_Tema_3_Ej_05
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado2 = new System.Windows.Forms.Label();
			this.txtNumero3 = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblNum3 = new System.Windows.Forms.Label();
			this.lblResultado1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(246, 84);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 26);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(246, 130);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 26);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DeepPink;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.White;
			this.btnAccion.Location = new System.Drawing.Point(201, 228);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(113, 52);
			this.btnAccion.TabIndex = 4;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado2
			// 
			this.lblResultado2.AutoSize = true;
			this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado2.Location = new System.Drawing.Point(21, 362);
			this.lblResultado2.Name = "lblResultado2";
			this.lblResultado2.Size = new System.Drawing.Size(85, 26);
			this.lblResultado2.TabIndex = 0;
			this.lblResultado2.Text = "Detalle:";
			// 
			// txtNumero3
			// 
			this.txtNumero3.Location = new System.Drawing.Point(246, 182);
			this.txtNumero3.Name = "txtNumero3";
			this.txtNumero3.Size = new System.Drawing.Size(100, 26);
			this.txtNumero3.TabIndex = 3;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(102, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(320, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "El mayor de 3";
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Location = new System.Drawing.Point(138, 87);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(82, 20);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Numero 1:";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Location = new System.Drawing.Point(138, 133);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(82, 20);
			this.lblNum2.TabIndex = 0;
			this.lblNum2.Text = "Numero 2:";
			// 
			// lblNum3
			// 
			this.lblNum3.AutoSize = true;
			this.lblNum3.Location = new System.Drawing.Point(138, 185);
			this.lblNum3.Name = "lblNum3";
			this.lblNum3.Size = new System.Drawing.Size(82, 20);
			this.lblNum3.TabIndex = 0;
			this.lblNum3.Text = "Numero 3:";
			// 
			// lblResultado1
			// 
			this.lblResultado1.AutoSize = true;
			this.lblResultado1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado1.Location = new System.Drawing.Point(21, 305);
			this.lblResultado1.Name = "lblResultado1";
			this.lblResultado1.Size = new System.Drawing.Size(108, 26);
			this.lblResultado1.TabIndex = 0;
			this.lblResultado1.Text = "Resultado:";
			// 
			// Prog_Tema_3_Ej_05
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightPink;
			this.ClientSize = new System.Drawing.Size(541, 542);
			this.Controls.Add(this.lblResultado1);
			this.Controls.Add(this.lblNum3);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtNumero3);
			this.Controls.Add(this.lblResultado2);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Name = "Prog_Tema_3_Ej_05";
			this.Text = "Prog_Tema_3_Ej_05";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.TextBox txtNumero3;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblNum3;
		private System.Windows.Forms.Label lblResultado1;
		}
}
