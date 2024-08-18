namespace Prog_Tema_2_Ej_07
	{
	partial class Prog_Tema_2_Ej_07
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
			this.lblExplicacion = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(26, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(317, 34);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Altura de un individuo";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Location = new System.Drawing.Point(26, 58);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(286, 26);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce la altura de un individuo:";
			// 
			// lblExplicacion
			// 
			this.lblExplicacion.AutoSize = true;
			this.lblExplicacion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplicacion.Location = new System.Drawing.Point(27, 92);
			this.lblExplicacion.Name = "lblExplicacion";
			this.lblExplicacion.Size = new System.Drawing.Size(181, 19);
			this.lblExplicacion.TabIndex = 0;
			this.lblExplicacion.Text = "Formato: número entero";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(31, 136);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(177, 33);
			this.txtNumero.TabIndex = 1;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DarkRed;
			this.btnAccion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.Yellow;
			this.btnAccion.Location = new System.Drawing.Point(31, 196);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(177, 36);
			this.btnAccion.TabIndex = 2;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(26, 257);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(118, 31);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado.";
			// 
			// Prog_Tema_2_Ej_07
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(345, 399);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblExplicacion);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Prog_Tema_2_Ej_07";
			this.Text = "Prog_Tema_2_Ej_07";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblExplicacion;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblResultado;
		}
	}

