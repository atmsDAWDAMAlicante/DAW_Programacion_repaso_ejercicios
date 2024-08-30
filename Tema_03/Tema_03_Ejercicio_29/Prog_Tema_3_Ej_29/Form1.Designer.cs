namespace Prog_Tema_3_Ej_29
	{
	partial class Prog_Tema_3_Ej_29
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
			this.btnMostrar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.grpPizarra = new System.Windows.Forms.GroupBox();
			this.grpPizarra.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(24, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(495, 32);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Serie: 1 - 1/2 + 1/3 - 1/4........(+ -) 1/n";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(62, 54);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(291, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el número \'n\': ";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(371, 55);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(70, 31);
			this.txtNumero.TabIndex = 1;
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.ForeColor = System.Drawing.Color.Black;
			this.btnMostrar.Location = new System.Drawing.Point(183, 105);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(192, 58);
			this.btnMostrar.TabIndex = 2;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(32, 35);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(137, 28);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// grpPizarra
			// 
			this.grpPizarra.Controls.Add(this.lblResultado);
			this.grpPizarra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPizarra.Location = new System.Drawing.Point(24, 182);
			this.grpPizarra.Name = "grpPizarra";
			this.grpPizarra.Size = new System.Drawing.Size(495, 276);
			this.grpPizarra.TabIndex = 0;
			this.grpPizarra.TabStop = false;
			this.grpPizarra.Text = "Pizarra";
			// 
			// Prog_Tema_3_Ej_29
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(574, 478);
			this.Controls.Add(this.grpPizarra);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_29";
			this.Text = "Prog_Tema_3_Ej_29";
			this.grpPizarra.ResumeLayout(false);
			this.grpPizarra.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.GroupBox grpPizarra;
		}
	}
