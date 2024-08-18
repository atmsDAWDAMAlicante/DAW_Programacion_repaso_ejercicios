namespace Prog_Tema_2_Ej_14
	{
	partial class Prog_Tema_2_Ej_14
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnMayorQue = new System.Windows.Forms.Button();
			this.btnMenorQue = new System.Windows.Forms.Button();
			this.btnIgualA = new System.Windows.Forms.Button();
			this.btnDistintoA = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(520, 52);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Operadores relacionales";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(220, 288);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(82, 20);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Location = new System.Drawing.Point(29, 107);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(82, 20);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Número 1:";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Location = new System.Drawing.Point(317, 107);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(82, 20);
			this.lblNum2.TabIndex = 0;
			this.lblNum2.Text = "Número 2:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(120, 103);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 26);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(405, 103);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 26);
			this.txtNum2.TabIndex = 2;
			// 
			// btnMayorQue
			// 
			this.btnMayorQue.Location = new System.Drawing.Point(33, 185);
			this.btnMayorQue.Name = "btnMayorQue";
			this.btnMayorQue.Size = new System.Drawing.Size(75, 75);
			this.btnMayorQue.TabIndex = 3;
			this.btnMayorQue.Text = ">";
			this.btnMayorQue.UseVisualStyleBackColor = true;
			// 
			// btnMenorQue
			// 
			this.btnMenorQue.Location = new System.Drawing.Point(145, 185);
			this.btnMenorQue.Name = "btnMenorQue";
			this.btnMenorQue.Size = new System.Drawing.Size(75, 75);
			this.btnMenorQue.TabIndex = 4;
			this.btnMenorQue.Text = "<";
			this.btnMenorQue.UseVisualStyleBackColor = true;
			// 
			// btnIgualA
			// 
			this.btnIgualA.Location = new System.Drawing.Point(299, 185);
			this.btnIgualA.Name = "btnIgualA";
			this.btnIgualA.Size = new System.Drawing.Size(75, 75);
			this.btnIgualA.TabIndex = 5;
			this.btnIgualA.Text = "==";
			this.btnIgualA.UseVisualStyleBackColor = true;
			// 
			// btnDistintoA
			// 
			this.btnDistintoA.Location = new System.Drawing.Point(430, 185);
			this.btnDistintoA.Name = "btnDistintoA";
			this.btnDistintoA.Size = new System.Drawing.Size(75, 75);
			this.btnDistintoA.TabIndex = 6;
			this.btnDistintoA.Text = "!=";
			this.btnDistintoA.UseVisualStyleBackColor = true;
			// 
			// Prog_Tema_2_Ej_14
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 325);
			this.Controls.Add(this.btnDistintoA);
			this.Controls.Add(this.btnIgualA);
			this.Controls.Add(this.btnMenorQue);
			this.Controls.Add(this.btnMayorQue);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_2_Ej_14";
			this.Text = "Prog_Tema_2_Ej_14";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Button btnMayorQue;
		private System.Windows.Forms.Button btnMenorQue;
		private System.Windows.Forms.Button btnIgualA;
		private System.Windows.Forms.Button btnDistintoA;
		}
	}

