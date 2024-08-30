namespace Prog_Tema_3_Ej_15
	{
	partial class Prog_Tema_3_Ej_15
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
			this.lblElMayor = new System.Windows.Forms.Label();
			this.lblElMenor = new System.Windows.Forms.Label();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblAviso = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(36, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(394, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "El mayor y el menor";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(36, 79);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(488, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce números mediante un InputBox";
			// 
			// lblElMayor
			// 
			this.lblElMayor.AutoSize = true;
			this.lblElMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElMayor.Location = new System.Drawing.Point(36, 193);
			this.lblElMayor.Name = "lblElMayor";
			this.lblElMayor.Size = new System.Drawing.Size(143, 25);
			this.lblElMayor.TabIndex = 0;
			this.lblElMayor.Text = "El mayor es...";
			// 
			// lblElMenor
			// 
			this.lblElMenor.AutoSize = true;
			this.lblElMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElMenor.Location = new System.Drawing.Point(36, 242);
			this.lblElMenor.Name = "lblElMenor";
			this.lblElMenor.Size = new System.Drawing.Size(144, 25);
			this.lblElMenor.TabIndex = 0;
			this.lblElMenor.Text = "El menor es...";
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.Cyan;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.Location = new System.Drawing.Point(120, 122);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(316, 48);
			this.btnAccion.TabIndex = 1;
			this.btnAccion.Text = "Abre el InputBox";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblAviso
			// 
			this.lblAviso.AutoSize = true;
			this.lblAviso.Location = new System.Drawing.Point(36, 292);
			this.lblAviso.Name = "lblAviso";
			this.lblAviso.Size = new System.Drawing.Size(403, 20);
			this.lblAviso.TabIndex = 0;
			this.lblAviso.Text = "Introduce un número negativo para finalizar el programa";
			// 
			// Prog_Tema_3_Ej_15
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(568, 335);
			this.Controls.Add(this.lblAviso);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.lblElMenor);
			this.Controls.Add(this.lblElMayor);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_15";
			this.Text = "Prog_Tema_3_Ej_15";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblElMayor;
		private System.Windows.Forms.Label lblElMenor;
		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblAviso;
		}
	}

