namespace Prog_Tema_3_Ej_21
	{
	partial class Prog_Tema_3_Ej_21
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
			this.btnMostrar = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Black;
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(491, 56);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Repetición de series";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Black;
			this.lblSubtitulo.Location = new System.Drawing.Point(12, 76);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(585, 64);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el número (max. 15) de repeticiones\nde las series del 1 al 10:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(292, 173);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(97, 21);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.DarkGreen;
			this.btnMostrar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.ForeColor = System.Drawing.Color.Gold;
			this.btnMostrar.Location = new System.Drawing.Point(100, 160);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(160, 50);
			this.btnMostrar.TabIndex = 2;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = false;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.ForestGreen;
			this.txtNumero.Location = new System.Drawing.Point(22, 164);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(50, 35);
			this.txtNumero.TabIndex = 1;
			// 
			// Prog_Tema_3_Ej_21
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(631, 548);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_21";
			this.Text = "Prog_Tema_3_Ej_21";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.TextBox txtNumero;
		}
	}

