﻿namespace Prog_Tema_4_Ej_23_
	{
	partial class Prog_Tema_4_Ej_23
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnFuncionIterativa = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblTituloResultado = new System.Windows.Forms.Label();
			this.btnFuncionRecursiva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(217, 71);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 26);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(216, 114);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 26);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnFuncionIterativa
			// 
			this.btnFuncionIterativa.BackColor = System.Drawing.Color.Blue;
			this.btnFuncionIterativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionIterativa.Location = new System.Drawing.Point(45, 162);
			this.btnFuncionIterativa.Name = "btnFuncionIterativa";
			this.btnFuncionIterativa.Size = new System.Drawing.Size(285, 43);
			this.btnFuncionIterativa.TabIndex = 3;
			this.btnFuncionIterativa.Text = "Función Iterativa";
			this.btnFuncionIterativa.UseVisualStyleBackColor = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(195, 280);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(122, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(19, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(346, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ División con restas";
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Location = new System.Drawing.Point(41, 77);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(168, 20);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Introduce el dividendo:";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Location = new System.Drawing.Point(61, 114);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(145, 20);
			this.lblNum2.TabIndex = 0;
			this.lblNum2.Text = "Introduce el divisor:";
			// 
			// lblTituloResultado
			// 
			this.lblTituloResultado.AutoSize = true;
			this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloResultado.Location = new System.Drawing.Point(43, 282);
			this.lblTituloResultado.Name = "lblTituloResultado";
			this.lblTituloResultado.Size = new System.Drawing.Size(146, 25);
			this.lblTituloResultado.TabIndex = 0;
			this.lblTituloResultado.Text = "El resultado es:";
			// 
			// btnFuncionRecursiva
			// 
			this.btnFuncionRecursiva.BackColor = System.Drawing.Color.Blue;
			this.btnFuncionRecursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionRecursiva.Location = new System.Drawing.Point(45, 223);
			this.btnFuncionRecursiva.Name = "btnFuncionRecursiva";
			this.btnFuncionRecursiva.Size = new System.Drawing.Size(285, 43);
			this.btnFuncionRecursiva.TabIndex = 4;
			this.btnFuncionRecursiva.Text = "Función Recursiva";
			this.btnFuncionRecursiva.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_4_Ej_23
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(375, 342);
			this.Controls.Add(this.btnFuncionRecursiva);
			this.Controls.Add(this.lblTituloResultado);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnFuncionIterativa);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.ForeColor = System.Drawing.Color.GhostWhite;
			this.Name = "Prog_Tema_4_Ej_23";
			this.Text = "Prog_Tema_4_Ej_23";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.Button btnFuncionIterativa;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblTituloResultado;
		private System.Windows.Forms.Button btnFuncionRecursiva;
		}
	}






