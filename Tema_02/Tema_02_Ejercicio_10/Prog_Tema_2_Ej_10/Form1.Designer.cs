namespace Prog_Tema_2_Ej_10
	{
	partial class Prog_Tema_2_Ej_10
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
			this.lblEuros = new System.Windows.Forms.Label();
			this.lblPesetas = new System.Windows.Forms.Label();
			this.txtEuros = new System.Windows.Forms.TextBox();
			this.txtPesetas = new System.Windows.Forms.TextBox();
			this.btnPasaraPesetas = new System.Windows.Forms.Button();
			this.btnPasaraEuros = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(13, 25);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(425, 37);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Conversor de Euros-Pesetas";
			// 
			// lblEuros
			// 
			this.lblEuros.AutoSize = true;
			this.lblEuros.ForeColor = System.Drawing.Color.White;
			this.lblEuros.Location = new System.Drawing.Point(50, 109);
			this.lblEuros.Name = "lblEuros";
			this.lblEuros.Size = new System.Drawing.Size(69, 26);
			this.lblEuros.TabIndex = 0;
			this.lblEuros.Text = "Euros";
			// 
			// lblPesetas
			// 
			this.lblPesetas.AutoSize = true;
			this.lblPesetas.ForeColor = System.Drawing.Color.White;
			this.lblPesetas.Location = new System.Drawing.Point(50, 173);
			this.lblPesetas.Name = "lblPesetas";
			this.lblPesetas.Size = new System.Drawing.Size(91, 26);
			this.lblPesetas.TabIndex = 0;
			this.lblPesetas.Text = "Pesetas";
			// 
			// txtEuros
			// 
			this.txtEuros.Location = new System.Drawing.Point(213, 103);
			this.txtEuros.Name = "txtEuros";
			this.txtEuros.Size = new System.Drawing.Size(191, 32);
			this.txtEuros.TabIndex = 1;
			// 
			// txtPesetas
			// 
			this.txtPesetas.Location = new System.Drawing.Point(213, 170);
			this.txtPesetas.Name = "txtPesetas";
			this.txtPesetas.Size = new System.Drawing.Size(191, 32);
			this.txtPesetas.TabIndex = 2;
			// 
			// btnPasaraPesetas
			// 
			this.btnPasaraPesetas.BackColor = System.Drawing.Color.Pink;
			this.btnPasaraPesetas.Location = new System.Drawing.Point(75, 267);
			this.btnPasaraPesetas.Name = "btnPasaraPesetas";
			this.btnPasaraPesetas.Size = new System.Drawing.Size(320, 49);
			this.btnPasaraPesetas.TabIndex = 3;
			this.btnPasaraPesetas.Text = "Pasar a Pesetas";
			this.btnPasaraPesetas.UseVisualStyleBackColor = false;
			// 
			// btnPasaraEuros
			// 
			this.btnPasaraEuros.BackColor = System.Drawing.Color.Pink;
			this.btnPasaraEuros.Location = new System.Drawing.Point(75, 360);
			this.btnPasaraEuros.Name = "btnPasaraEuros";
			this.btnPasaraEuros.Size = new System.Drawing.Size(320, 49);
			this.btnPasaraEuros.TabIndex = 4;
			this.btnPasaraEuros.Text = "Pasar a Euros";
			this.btnPasaraEuros.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_2_Ej_10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RosyBrown;
			this.ClientSize = new System.Drawing.Size(485, 455);
			this.Controls.Add(this.btnPasaraEuros);
			this.Controls.Add(this.btnPasaraPesetas);
			this.Controls.Add(this.txtPesetas);
			this.Controls.Add(this.txtEuros);
			this.Controls.Add(this.lblPesetas);
			this.Controls.Add(this.lblEuros);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Prog_Tema_2_Ej_10";
			this.Text = "Prog_Tema_2_Ej_10";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblEuros;
		private System.Windows.Forms.Label lblPesetas;
		private System.Windows.Forms.TextBox txtEuros;
		private System.Windows.Forms.TextBox txtPesetas;
		private System.Windows.Forms.Button btnPasaraPesetas;
		private System.Windows.Forms.Button btnPasaraEuros;
		}
	}

