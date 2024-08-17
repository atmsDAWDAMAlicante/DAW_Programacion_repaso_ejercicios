namespace Prog_Tema_1_Ej_01
	{
	partial class Prog_Tema_1_Ej_01
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
			this.btnBoton1 = new System.Windows.Forms.Button();
			this.btnBoton2 = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBoton1
			// 
			this.btnBoton1.Location = new System.Drawing.Point(97, 121);
			this.btnBoton1.Name = "btnBoton1";
			this.btnBoton1.Size = new System.Drawing.Size(131, 60);
			this.btnBoton1.TabIndex = 0;
			this.btnBoton1.Text = "Botón 1º";
			this.btnBoton1.UseVisualStyleBackColor = true;
			this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
			// 
			// btnBoton2
			// 
			this.btnBoton2.Location = new System.Drawing.Point(308, 121);
			this.btnBoton2.Name = "btnBoton2";
			this.btnBoton2.Size = new System.Drawing.Size(131, 60);
			this.btnBoton2.TabIndex = 1;
			this.btnBoton2.Text = "Botón 2º";
			this.btnBoton2.UseVisualStyleBackColor = true;
			this.btnBoton2.Click += new System.EventHandler(this.btnBoton2_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(88, 35);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(371, 51);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "¡Pulsa un botón!";
			// 
			// Prog_Tema_1_Ej_01
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(546, 235);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnBoton2);
			this.Controls.Add(this.btnBoton1);
			this.Name = "Prog_Tema_1_Ej_01";
			this.Text = "Prog_Tema_1_Ej_01";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnBoton1;
		private System.Windows.Forms.Button btnBoton2;
		private System.Windows.Forms.Label lblTitulo;
		}
	}

