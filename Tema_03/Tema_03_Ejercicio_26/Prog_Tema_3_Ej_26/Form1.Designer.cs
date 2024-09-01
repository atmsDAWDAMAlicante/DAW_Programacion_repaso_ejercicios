namespace Prog_Tema_3_Ej_26
	{
	partial class Prog_Tema_3_Ej_26
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
			this.btnMostrar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.grpPizarra = new System.Windows.Forms.GroupBox();
			this.grpPizarra.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(116, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(297, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Múltiplos de 3:";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(94, 67);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(316, 23);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Sólo caben 7 números por línea";
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.Indigo;
			this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.ForeColor = System.Drawing.Color.White;
			this.btnMostrar.Location = new System.Drawing.Point(173, 102);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(142, 46);
			this.btnMostrar.TabIndex = 1;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = false;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(28, 46);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(128, 28);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// grpPizarra
			// 
			this.grpPizarra.Controls.Add(this.lblResultado);
			this.grpPizarra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPizarra.ForeColor = System.Drawing.Color.White;
			this.grpPizarra.Location = new System.Drawing.Point(12, 154);
			this.grpPizarra.Name = "grpPizarra";
			this.grpPizarra.Size = new System.Drawing.Size(460, 212);
			this.grpPizarra.TabIndex = 0;
			this.grpPizarra.TabStop = false;
			this.grpPizarra.Text = "Pizarra";
			// 
			// Prog_Tema_3_Ej_26
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.ClientSize = new System.Drawing.Size(484, 380);
			this.Controls.Add(this.grpPizarra);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_26";
			this.Text = "Prog_Tema_3_Ej_26";
			this.grpPizarra.ResumeLayout(false);
			this.grpPizarra.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.GroupBox grpPizarra;
		}
	}
