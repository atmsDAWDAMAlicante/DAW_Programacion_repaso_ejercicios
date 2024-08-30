namespace Prog_Tema_3_Ej_28
	{
	partial class Prog_Tema_3_Ej_28
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
			this.btnMostrar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(25, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(415, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Pr*duct* usando s+mas";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(61, 79);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(204, 20);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce dos números: ";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.Location = new System.Drawing.Point(274, 72);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(60, 30);
			this.txtNumero1.TabIndex = 1;
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.Orchid;
			this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.ForeColor = System.Drawing.Color.White;
			this.btnMostrar.Location = new System.Drawing.Point(128, 119);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(192, 58);
			this.btnMostrar.TabIndex = 3;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(25, 196);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.Location = new System.Drawing.Point(348, 72);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(60, 30);
			this.txtNumero2.TabIndex = 2;
			// 
			// Prog_Tema_3_Ej_28
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(484, 426);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_28";
			this.Text = "Prog_Tema_3_Ej_28";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero2;
		}
	}
