namespace Prog_Tema_4_Ej_08_
{
    partial class Prog_Tema_4_Ej_08
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
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtNum3 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lbl1Ev = new System.Windows.Forms.Label();
			this.lbl2Ev = new System.Windows.Forms.Label();
			this.lbl3Ev = new System.Windows.Forms.Label();
			this.lblTituloResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNum1
			// 
			this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum1.ForeColor = System.Drawing.Color.SeaGreen;
			this.txtNum1.Location = new System.Drawing.Point(166, 97);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(84, 30);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum2.ForeColor = System.Drawing.Color.SeaGreen;
			this.txtNum2.Location = new System.Drawing.Point(166, 150);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(84, 30);
			this.txtNum2.TabIndex = 2;
			// 
			// txtNum3
			// 
			this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum3.ForeColor = System.Drawing.Color.SeaGreen;
			this.txtNum3.Location = new System.Drawing.Point(166, 203);
			this.txtNum3.Name = "txtNum3";
			this.txtNum3.Size = new System.Drawing.Size(84, 30);
			this.txtNum3.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.Yellow;
			this.btnCalcular.Location = new System.Drawing.Point(90, 264);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(125, 49);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(27, 378);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(152, 32);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(44, 19);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(269, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Nota Media";
			// 
			// lbl1Ev
			// 
			this.lbl1Ev.AutoSize = true;
			this.lbl1Ev.ForeColor = System.Drawing.Color.White;
			this.lbl1Ev.Location = new System.Drawing.Point(56, 101);
			this.lbl1Ev.Name = "lbl1Ev";
			this.lbl1Ev.Size = new System.Drawing.Size(105, 20);
			this.lbl1Ev.TabIndex = 0;
			this.lbl1Ev.Text = "1ª Evaluación";
			// 
			// lbl2Ev
			// 
			this.lbl2Ev.AutoSize = true;
			this.lbl2Ev.ForeColor = System.Drawing.Color.White;
			this.lbl2Ev.Location = new System.Drawing.Point(56, 154);
			this.lbl2Ev.Name = "lbl2Ev";
			this.lbl2Ev.Size = new System.Drawing.Size(105, 20);
			this.lbl2Ev.TabIndex = 0;
			this.lbl2Ev.Text = "2ª Evaluación";
			// 
			// lbl3Ev
			// 
			this.lbl3Ev.AutoSize = true;
			this.lbl3Ev.ForeColor = System.Drawing.Color.White;
			this.lbl3Ev.Location = new System.Drawing.Point(56, 208);
			this.lbl3Ev.Name = "lbl3Ev";
			this.lbl3Ev.Size = new System.Drawing.Size(105, 20);
			this.lbl3Ev.TabIndex = 0;
			this.lbl3Ev.Text = "3ª Evaluación";
			// 
			// lblTituloResultado
			// 
			this.lblTituloResultado.AutoSize = true;
			this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloResultado.ForeColor = System.Drawing.Color.White;
			this.lblTituloResultado.Location = new System.Drawing.Point(26, 333);
			this.lblTituloResultado.Name = "lblTituloResultado";
			this.lblTituloResultado.Size = new System.Drawing.Size(219, 29);
			this.lblTituloResultado.TabIndex = 0;
			this.lblTituloResultado.Text = "La nota media es:";
			// 
			// Prog_Tema_4_Ej_08
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(404, 483);
			this.Controls.Add(this.lblTituloResultado);
			this.Controls.Add(this.lbl3Ev);
			this.Controls.Add(this.lbl2Ev);
			this.Controls.Add(this.lbl1Ev);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNum3);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Name = "Prog_Tema_4_Ej_08";
			this.Text = "Prog_Tema_4_Ej_08";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lbl1Ev;
		private System.Windows.Forms.Label lbl2Ev;
		private System.Windows.Forms.Label lbl3Ev;
		private System.Windows.Forms.Label lblTituloResultado;
		}
}

