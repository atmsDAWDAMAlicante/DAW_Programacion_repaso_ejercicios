namespace Prog_Tema_2_Ej_12
	{
	partial class Prog_Tema_2_Ej_12
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
			this.lblProducto1 = new System.Windows.Forms.Label();
			this.lblProducto2 = new System.Windows.Forms.Label();
			this.lblProducto3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblEuro1 = new System.Windows.Forms.Label();
			this.lblEuro2 = new System.Windows.Forms.Label();
			this.lblEuro3 = new System.Windows.Forms.Label();
			this.lblImporte = new System.Windows.Forms.Label();
			this.btnImporte = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(33, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(190, 59);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Tienda";
			// 
			// lblProducto1
			// 
			this.lblProducto1.AutoSize = true;
			this.lblProducto1.Location = new System.Drawing.Point(12, 88);
			this.lblProducto1.Name = "lblProducto1";
			this.lblProducto1.Size = new System.Drawing.Size(112, 25);
			this.lblProducto1.TabIndex = 0;
			this.lblProducto1.Text = "Producto 1:";
			// 
			// lblProducto2
			// 
			this.lblProducto2.AutoSize = true;
			this.lblProducto2.Location = new System.Drawing.Point(12, 137);
			this.lblProducto2.Name = "lblProducto2";
			this.lblProducto2.Size = new System.Drawing.Size(112, 25);
			this.lblProducto2.TabIndex = 0;
			this.lblProducto2.Text = "Producto 2:";
			// 
			// lblProducto3
			// 
			this.lblProducto3.AutoSize = true;
			this.lblProducto3.Location = new System.Drawing.Point(12, 189);
			this.lblProducto3.Name = "lblProducto3";
			this.lblProducto3.Size = new System.Drawing.Size(112, 25);
			this.lblProducto3.TabIndex = 0;
			this.lblProducto3.Text = "Producto 3:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 83);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 30);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(130, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 30);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(130, 184);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 30);
			this.textBox3.TabIndex = 3;
			// 
			// lblEuro1
			// 
			this.lblEuro1.AutoSize = true;
			this.lblEuro1.Location = new System.Drawing.Point(249, 88);
			this.lblEuro1.Name = "lblEuro1";
			this.lblEuro1.Size = new System.Drawing.Size(23, 25);
			this.lblEuro1.TabIndex = 0;
			this.lblEuro1.Text = "€";
			// 
			// lblEuro2
			// 
			this.lblEuro2.AutoSize = true;
			this.lblEuro2.Location = new System.Drawing.Point(249, 137);
			this.lblEuro2.Name = "lblEuro2";
			this.lblEuro2.Size = new System.Drawing.Size(23, 25);
			this.lblEuro2.TabIndex = 0;
			this.lblEuro2.Text = "€";
			// 
			// lblEuro3
			// 
			this.lblEuro3.AutoSize = true;
			this.lblEuro3.Location = new System.Drawing.Point(249, 189);
			this.lblEuro3.Name = "lblEuro3";
			this.lblEuro3.Size = new System.Drawing.Size(23, 25);
			this.lblEuro3.TabIndex = 0;
			this.lblEuro3.Text = "€";
			// 
			// lblImporte
			// 
			this.lblImporte.AutoSize = true;
			this.lblImporte.Location = new System.Drawing.Point(12, 294);
			this.lblImporte.Name = "lblImporte";
			this.lblImporte.Size = new System.Drawing.Size(83, 25);
			this.lblImporte.TabIndex = 0;
			this.lblImporte.Text = "Importe:\n";
			// 
			// btnImporte
			// 
			this.btnImporte.BackColor = System.Drawing.Color.Wheat;
			this.btnImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImporte.Location = new System.Drawing.Point(64, 238);
			this.btnImporte.Name = "btnImporte";
			this.btnImporte.Size = new System.Drawing.Size(260, 39);
			this.btnImporte.TabIndex = 4;
			this.btnImporte.Text = "Calcular importe";
			this.btnImporte.UseVisualStyleBackColor = false;
			this.btnImporte.Click += new System.EventHandler(this.btnImporte_Click);
			// 
			// Prog_Tema_2_Ej_12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(383, 431);
			this.Controls.Add(this.btnImporte);
			this.Controls.Add(this.lblImporte);
			this.Controls.Add(this.lblEuro3);
			this.Controls.Add(this.lblEuro2);
			this.Controls.Add(this.lblEuro1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblProducto3);
			this.Controls.Add(this.lblProducto2);
			this.Controls.Add(this.lblProducto1);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Prog_Tema_2_Ej_12";
			this.Text = "Prog_Tema_2_Ej_12";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblProducto1;
		private System.Windows.Forms.Label lblProducto2;
		private System.Windows.Forms.Label lblProducto3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblEuro1;
		private System.Windows.Forms.Label lblEuro2;
		private System.Windows.Forms.Label lblEuro3;
		private System.Windows.Forms.Label lblImporte;
		private System.Windows.Forms.Button btnImporte;
		}
	}

