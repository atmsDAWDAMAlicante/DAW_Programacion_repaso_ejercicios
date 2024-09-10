namespace Prog_Tema_4_Ej_12_
	{
	partial class Prog_Tema_4_Ej_12
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
			this.lblDia = new System.Windows.Forms.Label();
			this.lblMes = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.txtDia = new System.Windows.Forms.TextBox();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(46, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(350, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ Fecha válida";
			// 
			// lblDia
			// 
			this.lblDia.AutoSize = true;
			this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDia.ForeColor = System.Drawing.Color.White;
			this.lblDia.Location = new System.Drawing.Point(120, 98);
			this.lblDia.Name = "lblDia";
			this.lblDia.Size = new System.Drawing.Size(51, 25);
			this.lblDia.TabIndex = 0;
			this.lblDia.Text = "Día:";
			// 
			// lblMes
			// 
			this.lblMes.AutoSize = true;
			this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMes.ForeColor = System.Drawing.Color.White;
			this.lblMes.Location = new System.Drawing.Point(111, 151);
			this.lblMes.Name = "lblMes";
			this.lblMes.Size = new System.Drawing.Size(60, 25);
			this.lblMes.TabIndex = 0;
			this.lblMes.Text = "Mes:";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.ForeColor = System.Drawing.Color.White;
			this.lblYear.Location = new System.Drawing.Point(111, 204);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(58, 25);
			this.lblYear.TabIndex = 0;
			this.lblYear.Text = "Año:";
			// 
			// txtDia
			// 
			this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDia.ForeColor = System.Drawing.Color.Navy;
			this.txtDia.Location = new System.Drawing.Point(176, 94);
			this.txtDia.Name = "txtDia";
			this.txtDia.Size = new System.Drawing.Size(75, 35);
			this.txtDia.TabIndex = 1;
			// 
			// txtMes
			// 
			this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMes.ForeColor = System.Drawing.Color.Navy;
			this.txtMes.Location = new System.Drawing.Point(176, 145);
			this.txtMes.Name = "txtMes";
			this.txtMes.Size = new System.Drawing.Size(75, 35);
			this.txtMes.TabIndex = 2;
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYear.ForeColor = System.Drawing.Color.Navy;
			this.txtYear.Location = new System.Drawing.Point(176, 198);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(100, 35);
			this.txtYear.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Blue;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(161, 257);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(128, 53);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(157, 325);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(119, 26);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// Prog_Tema_4_Ej_12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(463, 374);
			this.Controls.Add(this.txtDia);
			this.Controls.Add(this.txtMes);
			this.Controls.Add(this.lblMes);
			this.Controls.Add(this.lblDia);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Prog_Tema_4_Ej_12";
			this.Text = "Prog_Tema_4_Ej_12";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblDia;
		private System.Windows.Forms.Label lblMes;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.TextBox txtDia;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;

		}
	}

