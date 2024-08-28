namespace Prog_Tema_3_Ej_16
	{
	partial class Prog_Tema_3_Ej_16
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
			this.lblPulsaIntro = new System.Windows.Forms.Label();
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.lblIntroducidos = new System.Windows.Forms.Label();
			this.lblExplicacion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(20, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(513, 59);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Σ ¡introduce y suma!";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(37, 155);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(174, 28);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce números";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(227, 230);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(114, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado.";
			// 
			// lblPulsaIntro
			// 
			this.lblPulsaIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPulsaIntro.Location = new System.Drawing.Point(365, 155);
			this.lblPulsaIntro.Name = "lblPulsaIntro";
			this.lblPulsaIntro.Size = new System.Drawing.Size(150, 28);
			this.lblPulsaIntro.TabIndex = 0;
			this.lblPulsaIntro.Text = "y pulsa Intro";
			// 
			// txtNumeros
			// 
			this.txtNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeros.Location = new System.Drawing.Point(235, 152);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(120, 30);
			this.txtNumeros.TabIndex = 1;
			// 
			// lblIntroducidos
			// 
			this.lblIntroducidos.AutoSize = true;
			this.lblIntroducidos.Location = new System.Drawing.Point(18, 201);
			this.lblIntroducidos.Name = "lblIntroducidos";
			this.lblIntroducidos.Size = new System.Drawing.Size(21, 20);
			this.lblIntroducidos.TabIndex = 0;
			this.lblIntroducidos.Text = "...";
			// 
			// lblExplicacion
			// 
			this.lblExplicacion.AutoSize = true;
			this.lblExplicacion.Location = new System.Drawing.Point(105, 84);
			this.lblExplicacion.Name = "lblExplicacion";
			this.lblExplicacion.Size = new System.Drawing.Size(353, 40);
			this.lblExplicacion.TabIndex = 0;
			this.lblExplicacion.Text = "- en el rango del 0 al 9: se irán sumando\n- fuera de ese rango: se interrumpirá e" +
    "l programa";
			// 
			// Prog_Tema_3_Ej_16
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(565, 292);
			this.Controls.Add(this.lblExplicacion);
			this.Controls.Add(this.lblIntroducidos);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.lblPulsaIntro);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_16";
			this.Text = "Prog_Tema_3_Ej_16";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblPulsaIntro;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label lblIntroducidos;
		private System.Windows.Forms.Label lblExplicacion;
		}
	}