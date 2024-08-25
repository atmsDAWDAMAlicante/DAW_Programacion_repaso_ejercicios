namespace Prog_Tema_3_Ej_10
	{
	partial class Prog_Tema_3_Ej_10
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
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.txtEuros = new System.Windows.Forms.TextBox();
			this.grpResultado = new System.Windows.Forms.GroupBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.grpResultado.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAccion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.Yellow;
			this.btnAccion.Location = new System.Drawing.Point(207, 80);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(150, 48);
			this.btnAccion.TabIndex = 2;
			this.btnAccion.Text = "Calcular";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(445, 59);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Su cambio (en €uros)";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Yellow;
			this.lblSubtitulo.Location = new System.Drawing.Point(12, 52);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(387, 35);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce una cantidad en euros";
			// 
			// txtEuros
			// 
			this.txtEuros.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuros.ForeColor = System.Drawing.Color.Navy;
			this.txtEuros.Location = new System.Drawing.Point(18, 90);
			this.txtEuros.Name = "txtEuros";
			this.txtEuros.Size = new System.Drawing.Size(170, 42);
			this.txtEuros.TabIndex = 1;
			// 
			// grpResultado
			// 
			this.grpResultado.Controls.Add(this.lblResultado);
			this.grpResultado.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpResultado.ForeColor = System.Drawing.Color.Yellow;
			this.grpResultado.Location = new System.Drawing.Point(12, 130);
			this.grpResultado.Name = "grpResultado";
			this.grpResultado.Size = new System.Drawing.Size(346, 433);
			this.grpResultado.TabIndex = 0;
			this.grpResultado.TabStop = false;
			this.grpResultado.Text = "Su cambio:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Yellow;
			this.lblResultado.Location = new System.Drawing.Point(7, 38);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(98, 35);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "(euros)";
			// 
			// Prog_Tema_3_Ej_10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(390, 575);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.grpResultado);
			this.Controls.Add(this.txtEuros);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnAccion);
			this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Prog_Tema_3_Ej_10";
			this.Text = "Prog_Tema_3_Ej_10";
			this.grpResultado.ResumeLayout(false);
			this.grpResultado.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtEuros;
		private System.Windows.Forms.GroupBox grpResultado;
		private System.Windows.Forms.Label lblResultado;
		}
	}

