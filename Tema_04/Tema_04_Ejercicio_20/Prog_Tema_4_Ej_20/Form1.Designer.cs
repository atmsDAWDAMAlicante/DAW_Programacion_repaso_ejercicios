namespace Prog_Tema_4_Ej_20_
	{
	partial class Prog_Tema_4_Ej_20
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
			this.lblTituloBase = new System.Windows.Forms.Label();
			this.lblTituloExponente = new System.Windows.Forms.Label();
			this.lblSubtituloResultado = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.txtExponente = new System.Windows.Forms.TextBox();
			this.btnFuncionIterativa = new System.Windows.Forms.Button();
			this.btnFuncionRecursiva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(4, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(395, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Cálculo Potencias";
			// 
			// lblTituloBase
			// 
			this.lblTituloBase.AutoSize = true;
			this.lblTituloBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloBase.ForeColor = System.Drawing.Color.White;
			this.lblTituloBase.Location = new System.Drawing.Point(101, 77);
			this.lblTituloBase.Name = "lblTituloBase";
			this.lblTituloBase.Size = new System.Drawing.Size(68, 25);
			this.lblTituloBase.TabIndex = 0;
			this.lblTituloBase.Text = "Base:";
			// 
			// lblTituloExponente
			// 
			this.lblTituloExponente.AutoSize = true;
			this.lblTituloExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloExponente.ForeColor = System.Drawing.Color.White;
			this.lblTituloExponente.Location = new System.Drawing.Point(101, 115);
			this.lblTituloExponente.Name = "lblTituloExponente";
			this.lblTituloExponente.Size = new System.Drawing.Size(122, 25);
			this.lblTituloExponente.TabIndex = 0;
			this.lblTituloExponente.Text = "Exponente:";
			// 
			// lblSubtituloResultado
			// 
			this.lblSubtituloResultado.AutoSize = true;
			this.lblSubtituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtituloResultado.ForeColor = System.Drawing.Color.White;
			this.lblSubtituloResultado.Location = new System.Drawing.Point(27, 308);
			this.lblSubtituloResultado.Name = "lblSubtituloResultado";
			this.lblSubtituloResultado.Size = new System.Drawing.Size(162, 25);
			this.lblSubtituloResultado.TabIndex = 0;
			this.lblSubtituloResultado.Text = "El resutlado es:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(201, 308);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(108, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtBase
			// 
			this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBase.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtBase.Location = new System.Drawing.Point(223, 74);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(50, 26);
			this.txtBase.TabIndex = 1;
			// 
			// txtExponente
			// 
			this.txtExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExponente.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtExponente.Location = new System.Drawing.Point(223, 115);
			this.txtExponente.Name = "txtExponente";
			this.txtExponente.Size = new System.Drawing.Size(50, 26);
			this.txtExponente.TabIndex = 2;
			// 
			// btnFuncionIterativa
			// 
			this.btnFuncionIterativa.BackColor = System.Drawing.Color.OrangeRed;
			this.btnFuncionIterativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionIterativa.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnFuncionIterativa.Location = new System.Drawing.Point(64, 173);
			this.btnFuncionIterativa.Name = "btnFuncionIterativa";
			this.btnFuncionIterativa.Size = new System.Drawing.Size(249, 47);
			this.btnFuncionIterativa.TabIndex = 3;
			this.btnFuncionIterativa.Text = "Función Iterativa";
			this.btnFuncionIterativa.UseVisualStyleBackColor = false;
			// 
			// btnFuncionRecursiva
			// 
			this.btnFuncionRecursiva.BackColor = System.Drawing.Color.OrangeRed;
			this.btnFuncionRecursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionRecursiva.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnFuncionRecursiva.Location = new System.Drawing.Point(64, 237);
			this.btnFuncionRecursiva.Name = "btnFuncionRecursiva";
			this.btnFuncionRecursiva.Size = new System.Drawing.Size(249, 47);
			this.btnFuncionRecursiva.TabIndex = 4;
			this.btnFuncionRecursiva.Text = "Función Recursiva";
			this.btnFuncionRecursiva.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_4_Ej_20
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(412, 366);
			this.Controls.Add(this.btnFuncionRecursiva);
			this.Controls.Add(this.btnFuncionIterativa);
			this.Controls.Add(this.txtExponente);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtituloResultado);
			this.Controls.Add(this.lblTituloExponente);
			this.Controls.Add(this.lblTituloBase);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_4_Ej_20";
			this.Text = "Prog_Tema_4_Ej_20";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblTituloBase;
		private System.Windows.Forms.Label lblTituloExponente;
		private System.Windows.Forms.Label lblSubtituloResultado;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.TextBox txtExponente;
		private System.Windows.Forms.Button btnFuncionIterativa;
		private System.Windows.Forms.Button btnFuncionRecursiva;
		}
	}









