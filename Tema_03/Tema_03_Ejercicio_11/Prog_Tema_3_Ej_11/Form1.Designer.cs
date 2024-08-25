namespace Prog_Tema_3_Ej_11
	{
	partial class Prog_Tema_3_Ej_11
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
			this.lblHoras = new System.Windows.Forms.Label();
			this.lblMinutos = new System.Windows.Forms.Label();
			this.lblSegundos = new System.Windows.Forms.Label();
			this.lblTitResultado = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnAccion = new System.Windows.Forms.Button();
			this.txtHoras = new System.Windows.Forms.TextBox();
			this.txtMinutos = new System.Windows.Forms.TextBox();
			this.txtSegundos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
			this.lblTitulo.Location = new System.Drawing.Point(38, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(347, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Viaje al Futuro";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.NavajoWhite;
			this.lblSubtitulo.Location = new System.Drawing.Point(12, 74);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(372, 37);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "... un segundo después";
			// 
			// lblHoras
			// 
			this.lblHoras.AutoSize = true;
			this.lblHoras.Location = new System.Drawing.Point(25, 127);
			this.lblHoras.Name = "lblHoras";
			this.lblHoras.Size = new System.Drawing.Size(133, 20);
			this.lblHoras.TabIndex = 0;
			this.lblHoras.Text = "Introduce la hora:";
			// 
			// lblMinutos
			// 
			this.lblMinutos.AutoSize = true;
			this.lblMinutos.Location = new System.Drawing.Point(25, 170);
			this.lblMinutos.Name = "lblMinutos";
			this.lblMinutos.Size = new System.Drawing.Size(165, 20);
			this.lblMinutos.TabIndex = 0;
			this.lblMinutos.Text = "Introduce los minutos:";
			// 
			// lblSegundos
			// 
			this.lblSegundos.AutoSize = true;
			this.lblSegundos.Location = new System.Drawing.Point(25, 213);
			this.lblSegundos.Name = "lblSegundos";
			this.lblSegundos.Size = new System.Drawing.Size(179, 20);
			this.lblSegundos.TabIndex = 0;
			this.lblSegundos.Text = "Introduce los segundos:";
			// 
			// lblTitResultado
			// 
			this.lblTitResultado.AutoSize = true;
			this.lblTitResultado.Location = new System.Drawing.Point(97, 351);
			this.lblTitResultado.Name = "lblTitResultado";
			this.lblTitResultado.Size = new System.Drawing.Size(240, 20);
			this.lblTitResultado.TabIndex = 0;
			this.lblTitResultado.Text = "Dentro de un segundo serán las:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Yellow;
			this.lblResultado.Location = new System.Drawing.Point(23, 386);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(389, 37);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "... dentro de un segundo";
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DarkOrange;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.Location = new System.Drawing.Point(146, 272);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(144, 59);
			this.btnAccion.TabIndex = 4;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// txtHoras
			// 
			this.txtHoras.Location = new System.Drawing.Point(204, 120);
			this.txtHoras.Name = "txtHoras";
			this.txtHoras.Size = new System.Drawing.Size(100, 26);
			this.txtHoras.TabIndex = 1;
			// 
			// txtMinutos
			// 
			this.txtMinutos.Location = new System.Drawing.Point(204, 163);
			this.txtMinutos.Name = "txtMinutos";
			this.txtMinutos.Size = new System.Drawing.Size(100, 26);
			this.txtMinutos.TabIndex = 2;
			// 
			// txtSegundos
			// 
			this.txtSegundos.Location = new System.Drawing.Point(204, 206);
			this.txtSegundos.Name = "txtSegundos";
			this.txtSegundos.Size = new System.Drawing.Size(100, 26);
			this.txtSegundos.TabIndex = 3;
			// 
			// Prog_Tema_3_Ej_11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(441, 545);
			this.Controls.Add(this.txtSegundos);
			this.Controls.Add(this.txtMinutos);
			this.Controls.Add(this.txtHoras);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTitResultado);
			this.Controls.Add(this.lblSegundos);
			this.Controls.Add(this.lblMinutos);
			this.Controls.Add(this.lblHoras);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_11";
			this.Text = "Prog_Tema_3_Ej_11";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblHoras;
		private System.Windows.Forms.Label lblMinutos;
		private System.Windows.Forms.Label lblSegundos;
		private System.Windows.Forms.Label lblTitResultado;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.TextBox txtHoras;
		private System.Windows.Forms.TextBox txtMinutos;
		private System.Windows.Forms.TextBox txtSegundos;
		}
	}

