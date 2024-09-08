namespace Prog_Tema_4_Ej_09_
	{
	partial class Prog_Tema_4_Ej_09
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(61, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(276, 52);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Potencia!!!";
			// 
			// lblTituloBase
			// 
			this.lblTituloBase.AutoSize = true;
			this.lblTituloBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloBase.ForeColor = System.Drawing.Color.White;
			this.lblTituloBase.Location = new System.Drawing.Point(91, 90);
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
			this.lblTituloExponente.Location = new System.Drawing.Point(91, 128);
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
			this.lblSubtituloResultado.Location = new System.Drawing.Point(98, 243);
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
			this.lblResultado.Location = new System.Drawing.Point(71, 286);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(108, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtBase
			// 
			this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBase.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtBase.Location = new System.Drawing.Point(227, 87);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(50, 26);
			this.txtBase.TabIndex = 1;
			// 
			// txtExponente
			// 
			this.txtExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExponente.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtExponente.Location = new System.Drawing.Point(227, 128);
			this.txtExponente.Name = "txtExponente";
			this.txtExponente.Size = new System.Drawing.Size(50, 26);
			this.txtExponente.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.OrangeRed;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCalcular.Location = new System.Drawing.Point(127, 173);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(135, 47);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// Prog_Tema_4_Ej_09
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(417, 343);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtExponente);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSubtituloResultado);
			this.Controls.Add(this.lblTituloExponente);
			this.Controls.Add(this.lblTituloBase);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_4_Ej_09";
			this.Text = "Prog_Tema_4_Ej_09";
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
		private System.Windows.Forms.Button btnCalcular;
		}
	}

