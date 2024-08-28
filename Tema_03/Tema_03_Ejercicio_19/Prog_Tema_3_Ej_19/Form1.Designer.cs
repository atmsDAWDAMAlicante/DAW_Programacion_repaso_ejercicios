namespace Prog_Tema_3_Ej_19
	{
	partial class Prog_Tema_3_Ej_19
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(59, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(299, 60);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "! El Factorial";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(118, 293);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(169, 45);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(62, 88);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(299, 39);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce un número";
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(126, 213);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(146, 57);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtNumero.Location = new System.Drawing.Point(149, 145);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 35);
			this.txtNumero.TabIndex = 1;
			// 
			// Prog_Tema_3_Ej_19
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(440, 407);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTitulo);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Prog_Tema_3_Ej_19";
			this.Text = "Prog_Tema_3_Ej_19";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtNumero;
		}
	}

