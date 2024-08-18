namespace Prog_Tema_2_Ej_08
	{
	partial class Prog_Tema_2_Ej_08
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
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblNum3 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtNum3 = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
			this.lblTitulo.Location = new System.Drawing.Point(25, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(245, 32);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Suma y Producto";
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum1.Location = new System.Drawing.Point(27, 81);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(91, 20);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Número 1:";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum2.Location = new System.Drawing.Point(27, 140);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(91, 20);
			this.lblNum2.TabIndex = 0;
			this.lblNum2.Text = "Número 2:";
			// 
			// lblNum3
			// 
			this.lblNum3.AutoSize = true;
			this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum3.Location = new System.Drawing.Point(27, 194);
			this.lblNum3.Name = "lblNum3";
			this.lblNum3.Size = new System.Drawing.Size(91, 20);
			this.lblNum3.TabIndex = 0;
			this.lblNum3.Text = "Número 3:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(131, 78);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 26);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(131, 133);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 26);
			this.txtNum2.TabIndex = 2;
			// 
			// txtNum3
			// 
			this.txtNum3.Location = new System.Drawing.Point(131, 191);
			this.txtNum3.Name = "txtNum3";
			this.txtNum3.Size = new System.Drawing.Size(100, 26);
			this.txtNum3.TabIndex = 3;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.Location = new System.Drawing.Point(301, 61);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(181, 43);
			this.btnAccion.TabIndex = 4;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(297, 133);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(96, 20);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado:\n";
			// 
			// Prog_Tema_2_Ej_08
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(536, 257);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNum3);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.lblNum3);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblTitulo);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Prog_Tema_2_Ej_08";
			this.Text = "Prog_Tema_2_Ej_08";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblNum3;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum3;
		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblResultado;
		}
	}

