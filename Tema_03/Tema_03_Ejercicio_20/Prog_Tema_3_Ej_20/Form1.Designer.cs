namespace Prog_Tema_3_Ej_20
	{
	partial class Prog_Tema_3_Ej_20
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
			this.lblBase = new System.Windows.Forms.Label();
			this.lblExponente = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.txtExponente = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(64, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(293, 64);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Potencias n²";
			// 
			// lblBase
			// 
			this.lblBase.AutoSize = true;
			this.lblBase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBase.ForeColor = System.Drawing.Color.White;
			this.lblBase.Location = new System.Drawing.Point(86, 96);
			this.lblBase.Name = "lblBase";
			this.lblBase.Size = new System.Drawing.Size(67, 29);
			this.lblBase.TabIndex = 0;
			this.lblBase.Text = "Base:";
			// 
			// lblExponente
			// 
			this.lblExponente.AutoSize = true;
			this.lblExponente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExponente.ForeColor = System.Drawing.Color.White;
			this.lblExponente.Location = new System.Drawing.Point(26, 153);
			this.lblExponente.Name = "lblExponente";
			this.lblExponente.Size = new System.Drawing.Size(127, 29);
			this.lblExponente.TabIndex = 0;
			this.lblExponente.Text = "Exponente:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(109, 301);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(150, 39);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtBase
			// 
			this.txtBase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBase.ForeColor = System.Drawing.Color.Brown;
			this.txtBase.Location = new System.Drawing.Point(159, 93);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(100, 37);
			this.txtBase.TabIndex = 1;
			// 
			// txtExponente
			// 
			this.txtExponente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExponente.ForeColor = System.Drawing.Color.Brown;
			this.txtExponente.Location = new System.Drawing.Point(159, 150);
			this.txtExponente.Name = "txtExponente";
			this.txtExponente.Size = new System.Drawing.Size(100, 37);
			this.txtExponente.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.LightCoral;
			this.btnCalcular.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(110, 219);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(149, 51);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			// 
			// Prog_Tema_3_Ej_20
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(410, 384);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtExponente);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblExponente);
			this.Controls.Add(this.lblBase);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_20";
			this.Text = "Prog_Tema_3_Ej_20";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblBase;
		private System.Windows.Forms.Label lblExponente;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.TextBox txtExponente;
		private System.Windows.Forms.Button btnCalcular;
		}
	}

