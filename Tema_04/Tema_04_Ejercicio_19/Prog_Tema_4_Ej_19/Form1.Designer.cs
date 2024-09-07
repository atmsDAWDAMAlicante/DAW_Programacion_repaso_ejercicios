namespace Prog_Tema_4_Ej_19_
	{
	partial class Prog_Tema_4_Ej_19
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
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.btnFuncionIterativa = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnFuncionRecursiva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(411, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Cálculo ! Factorial";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(130, 361);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(169, 45);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(74, 88);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(299, 39);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce un número";
			// 
			// btnFuncionIterativa
			// 
			this.btnFuncionIterativa.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnFuncionIterativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionIterativa.Location = new System.Drawing.Point(87, 206);
			this.btnFuncionIterativa.Name = "btnFuncionIterativa";
			this.btnFuncionIterativa.Size = new System.Drawing.Size(252, 57);
			this.btnFuncionIterativa.TabIndex = 2;
			this.btnFuncionIterativa.Text = "Función Iterativa";
			this.btnFuncionIterativa.UseVisualStyleBackColor = false;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtNumero.Location = new System.Drawing.Point(161, 145);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 35);
			this.txtNumero.TabIndex = 1;
			// 
			// btnFuncionRecursiva
			// 
			this.btnFuncionRecursiva.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnFuncionRecursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionRecursiva.Location = new System.Drawing.Point(87, 282);
			this.btnFuncionRecursiva.Name = "btnFuncionRecursiva";
			this.btnFuncionRecursiva.Size = new System.Drawing.Size(255, 57);
			this.btnFuncionRecursiva.TabIndex = 3;
			this.btnFuncionRecursiva.Text = "Función Recursiva";
			this.btnFuncionRecursiva.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_4_Ej_19
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(440, 436);
			this.Controls.Add(this.btnFuncionRecursiva);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.btnFuncionIterativa);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTitulo);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Prog_Tema_4_Ej_19";
			this.Text = "Prog_Tema_4_Ej_19";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Button btnFuncionIterativa;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnFuncionRecursiva;
		}
	}








