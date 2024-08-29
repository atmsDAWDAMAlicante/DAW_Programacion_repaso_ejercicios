namespace Prog_Tema_3_Ej_27
	{
	partial class Prog_Tema_3_Ej_27
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Red;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(22, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(427, 59);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Los números primos";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(90, 85);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(233, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce un número:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.Red;
			this.txtNumero.Location = new System.Drawing.Point(329, 82);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(84, 37);
			this.txtNumero.TabIndex = 1;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.LightCoral;
			this.btnCalcular.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(155, 151);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(192, 58);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(87, 242);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(166, 44);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// Prog_Tema_3_Ej_27
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(484, 366);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_27";
			this.Text = "Prog_Tema_3_Ej_27";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		}
	}
