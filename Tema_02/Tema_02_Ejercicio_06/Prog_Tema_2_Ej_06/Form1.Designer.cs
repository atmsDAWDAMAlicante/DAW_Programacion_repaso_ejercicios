namespace Prog_Tema_2_Ej_06
	{
	partial class Prog_Tema_2_Ej_06
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
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblDivisor = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtDivisor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.Yellow;
			this.btnAccion.Location = new System.Drawing.Point(265, 34);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(104, 46);
			this.btnAccion.TabIndex = 3;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(51, 24);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(83, 24);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Número:";
			// 
			// lblDivisor
			// 
			this.lblDivisor.AutoSize = true;
			this.lblDivisor.Location = new System.Drawing.Point(51, 77);
			this.lblDivisor.Name = "lblDivisor";
			this.lblDivisor.Size = new System.Drawing.Size(72, 24);
			this.lblDivisor.TabIndex = 0;
			this.lblDivisor.Text = "Divisor:";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(133, 18);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 26);
			this.txtNumero.TabIndex = 1;
			// 
			// txtDivisor
			// 
			this.txtDivisor.Location = new System.Drawing.Point(133, 71);
			this.txtDivisor.Name = "txtDivisor";
			this.txtDivisor.Size = new System.Drawing.Size(100, 26);
			this.txtDivisor.TabIndex = 2;
			// 
			// Prog_Tema_2_Ej_06
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(453, 127);
			this.Controls.Add(this.txtDivisor);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblDivisor);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.btnAccion);
			this.Name = "Prog_Tema_2_Ej_06";
			this.Text = "Prog_Tema_2_Ej_06";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblDivisor;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtDivisor;
		}
	}

