﻿namespace Prog_Tema_4_Ej_18_
	{
	partial class Prog_Tema_4_Ej_18
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
			this.lblNumeroM = new System.Windows.Forms.Label();
			this.txtNumeroM = new System.Windows.Forms.TextBox();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.grpPizarra = new System.Windows.Forms.GroupBox();
			this.lblNumeroN = new System.Windows.Forms.Label();
			this.txtNumeroN = new System.Windows.Forms.TextBox();
			this.grpPizarra.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(598, 26);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Serie: m + m^2 / 2! + m^3 / 3! + m^4 / 4! + ... + m^n / n!";
			// 
			// lblNumeroM
			// 
			this.lblNumeroM.AutoSize = true;
			this.lblNumeroM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroM.Location = new System.Drawing.Point(61, 54);
			this.lblNumeroM.Name = "lblNumeroM";
			this.lblNumeroM.Size = new System.Drawing.Size(298, 29);
			this.lblNumeroM.TabIndex = 0;
			this.lblNumeroM.Text = "Introduce el número \'m\': ";
			// 
			// txtNumeroM
			// 
			this.txtNumeroM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroM.Location = new System.Drawing.Point(360, 55);
			this.txtNumeroM.Name = "txtNumeroM";
			this.txtNumeroM.Size = new System.Drawing.Size(70, 31);
			this.txtNumeroM.TabIndex = 1;
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.ForeColor = System.Drawing.Color.Black;
			this.btnMostrar.Location = new System.Drawing.Point(183, 170);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(192, 58);
			this.btnMostrar.TabIndex = 3;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(6, 35);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(137, 28);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// grpPizarra
			// 
			this.grpPizarra.Controls.Add(this.lblResultado);
			this.grpPizarra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPizarra.Location = new System.Drawing.Point(24, 247);
			this.grpPizarra.Name = "grpPizarra";
			this.grpPizarra.Size = new System.Drawing.Size(559, 126);
			this.grpPizarra.TabIndex = 0;
			this.grpPizarra.TabStop = false;
			this.grpPizarra.Text = "Pizarra";
			// 
			// lblNumeroN
			// 
			this.lblNumeroN.AutoSize = true;
			this.lblNumeroN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroN.Location = new System.Drawing.Point(62, 102);
			this.lblNumeroN.Name = "lblNumeroN";
			this.lblNumeroN.Size = new System.Drawing.Size(291, 29);
			this.lblNumeroN.TabIndex = 0;
			this.lblNumeroN.Text = "Introduce el número \'n\': ";
			// 
			// txtNumeroN
			// 
			this.txtNumeroN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroN.Location = new System.Drawing.Point(360, 103);
			this.txtNumeroN.Name = "txtNumeroN";
			this.txtNumeroN.Size = new System.Drawing.Size(70, 31);
			this.txtNumeroN.TabIndex = 2;
			// 
			// Prog_Tema_4_Ej_18
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(615, 398);
			this.Controls.Add(this.txtNumeroN);
			this.Controls.Add(this.lblNumeroN);
			this.Controls.Add(this.grpPizarra);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.txtNumeroM);
			this.Controls.Add(this.lblNumeroM);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_4_Ej_18";
			this.Text = "Prog_Tema_4_Ej_18";
			this.grpPizarra.ResumeLayout(false);
			this.grpPizarra.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblNumeroM;
		private System.Windows.Forms.TextBox txtNumeroM;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.GroupBox grpPizarra;
		private System.Windows.Forms.Label lblNumeroN;
		private System.Windows.Forms.TextBox txtNumeroN;
		}
	}


