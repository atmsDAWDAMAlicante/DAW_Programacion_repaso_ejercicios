namespace Prog_Tema_3_Ej_22
	{
	partial class Prog_Tema_3_Ej_22
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnComprobar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(20, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(556, 60);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Repuestos - Defectuosos";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(22, 81);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(489, 26);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el número de serie para comprobarlo:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(22, 191);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(134, 32);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(28, 133);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 44);
			this.txtNumero.TabIndex = 1;
			// 
			// btnComprobar
			// 
			this.btnComprobar.BackColor = System.Drawing.Color.Coral;
			this.btnComprobar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComprobar.Location = new System.Drawing.Point(179, 125);
			this.btnComprobar.Name = "btnComprobar";
			this.btnComprobar.Size = new System.Drawing.Size(193, 51);
			this.btnComprobar.TabIndex = 2;
			this.btnComprobar.Text = "Comprobar";
			this.btnComprobar.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_3_Ej_22
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(400, 290);
			this.Controls.Add(this.btnComprobar);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Prog_Tema_3_Ej_22";
			this.Text = "Prog_Tema_3_Ej_22";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnComprobar;
		}
	}

