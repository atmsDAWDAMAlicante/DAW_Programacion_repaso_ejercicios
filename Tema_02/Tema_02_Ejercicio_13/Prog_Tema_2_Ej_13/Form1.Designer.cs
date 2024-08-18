namespace Prog_Tema_2_Ej_13
	{
	partial class Prog_Tema_2_Ej_13
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
			this.lblHorasNormales = new System.Windows.Forms.Label();
			this.lblHorasExtra = new System.Windows.Forms.Label();
			this.txtHorasNormales = new System.Windows.Forms.TextBox();
			this.txtHorasExtra = new System.Windows.Forms.TextBox();
			this.lblImporteHoraTrabajada = new System.Windows.Forms.Label();
			this.txtImporteHoraTrabajada = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(18, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(190, 55);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Nómina";
			// 
			// lblHorasNormales
			// 
			this.lblHorasNormales.AutoSize = true;
			this.lblHorasNormales.Location = new System.Drawing.Point(18, 133);
			this.lblHorasNormales.Name = "lblHorasNormales";
			this.lblHorasNormales.Size = new System.Drawing.Size(125, 20);
			this.lblHorasNormales.TabIndex = 0;
			this.lblHorasNormales.Text = "Horas normales:";
			// 
			// lblHorasExtra
			// 
			this.lblHorasExtra.AutoSize = true;
			this.lblHorasExtra.Location = new System.Drawing.Point(18, 178);
			this.lblHorasExtra.Name = "lblHorasExtra";
			this.lblHorasExtra.Size = new System.Drawing.Size(95, 20);
			this.lblHorasExtra.TabIndex = 0;
			this.lblHorasExtra.Text = "Horas extra:";
			// 
			// txtHorasNormales
			// 
			this.txtHorasNormales.Location = new System.Drawing.Point(174, 127);
			this.txtHorasNormales.Name = "txtHorasNormales";
			this.txtHorasNormales.Size = new System.Drawing.Size(100, 26);
			this.txtHorasNormales.TabIndex = 2;
			// 
			// txtHorasExtra
			// 
			this.txtHorasExtra.Location = new System.Drawing.Point(174, 172);
			this.txtHorasExtra.Name = "txtHorasExtra";
			this.txtHorasExtra.Size = new System.Drawing.Size(100, 26);
			this.txtHorasExtra.TabIndex = 3;
			// 
			// lblImporteHoraTrabajada
			// 
			this.lblImporteHoraTrabajada.AutoSize = true;
			this.lblImporteHoraTrabajada.Location = new System.Drawing.Point(18, 79);
			this.lblImporteHoraTrabajada.Name = "lblImporteHoraTrabajada";
			this.lblImporteHoraTrabajada.Size = new System.Drawing.Size(175, 20);
			this.lblImporteHoraTrabajada.TabIndex = 0;
			this.lblImporteHoraTrabajada.Text = "Importe hora trabajada:";
			// 
			// txtImporteHoraTrabajada
			// 
			this.txtImporteHoraTrabajada.Location = new System.Drawing.Point(199, 76);
			this.txtImporteHoraTrabajada.Name = "txtImporteHoraTrabajada";
			this.txtImporteHoraTrabajada.Size = new System.Drawing.Size(100, 26);
			this.txtImporteHoraTrabajada.TabIndex = 1;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Turquoise;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(18, 232);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(227, 57);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(320, 76);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(86, 20);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado:\n";
			// 
			// Prog_Tema_2_Ej_13
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(698, 321);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtImporteHoraTrabajada);
			this.Controls.Add(this.lblImporteHoraTrabajada);
			this.Controls.Add(this.txtHorasExtra);
			this.Controls.Add(this.txtHorasNormales);
			this.Controls.Add(this.lblHorasExtra);
			this.Controls.Add(this.lblHorasNormales);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_2_Ej_13";
			this.Text = "Prog_Tema_2_Ej_13";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblHorasNormales;
		private System.Windows.Forms.Label lblHorasExtra;
		private System.Windows.Forms.TextBox txtHorasNormales;
		private System.Windows.Forms.TextBox txtHorasExtra;
		private System.Windows.Forms.Label lblImporteHoraTrabajada;
		private System.Windows.Forms.TextBox txtImporteHoraTrabajada;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		}
	}

