namespace Prog_Tema_4_Ej_22_
	{
	partial class Prog_Tema_4_Ej_22
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
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnFuncionIterativa = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnFuncionRecursiva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(2, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(473, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Número de dígitos";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(84, 86);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(159, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "del número: ";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.Maroon;
			this.txtNumero.Location = new System.Drawing.Point(249, 86);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(70, 30);
			this.txtNumero.TabIndex = 1;
			// 
			// btnFuncionIterativa
			// 
			this.btnFuncionIterativa.BackColor = System.Drawing.Color.Yellow;
			this.btnFuncionIterativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionIterativa.Location = new System.Drawing.Point(72, 145);
			this.btnFuncionIterativa.Name = "btnFuncionIterativa";
			this.btnFuncionIterativa.Size = new System.Drawing.Size(285, 48);
			this.btnFuncionIterativa.TabIndex = 2;
			this.btnFuncionIterativa.Text = "Función Iterativa";
			this.btnFuncionIterativa.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(84, 296);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// btnFuncionRecursiva
			// 
			this.btnFuncionRecursiva.BackColor = System.Drawing.Color.Yellow;
			this.btnFuncionRecursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionRecursiva.Location = new System.Drawing.Point(72, 214);
			this.btnFuncionRecursiva.Name = "btnFuncionRecursiva";
			this.btnFuncionRecursiva.Size = new System.Drawing.Size(285, 48);
			this.btnFuncionRecursiva.TabIndex = 3;
			this.btnFuncionRecursiva.Text = "Función Recursiva";
			this.btnFuncionRecursiva.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_4_Ej_22
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(484, 357);
			this.Controls.Add(this.btnFuncionRecursiva);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnFuncionIterativa);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_4_Ej_22";
			this.Text = "Prog_Tema_4_Ej_22";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnFuncionIterativa;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnFuncionRecursiva;
		}
	}






