namespace Prog_Tema_2_Ej_11
	{
	partial class Prog_Tema_2_Ej_11
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
			this.lblSaldo = new System.Windows.Forms.Label();
			this.lblInteres = new System.Windows.Forms.Label();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.txtInteres = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblAnual = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitulo.Location = new System.Drawing.Point(92, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(183, 52);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "BANCO";
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblSaldo.Location = new System.Drawing.Point(61, 89);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(260, 32);
			this.lblSaldo.TabIndex = 0;
			this.lblSaldo.Text = "Introduzca el saldo:";
			// 
			// lblInteres
			// 
			this.lblInteres.AutoSize = true;
			this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInteres.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblInteres.Location = new System.Drawing.Point(52, 187);
			this.lblInteres.Name = "lblInteres";
			this.lblInteres.Size = new System.Drawing.Size(269, 32);
			this.lblInteres.TabIndex = 0;
			this.lblInteres.Text = "Introduzca el interés";
			// 
			// txtSaldo
			// 
			this.txtSaldo.Location = new System.Drawing.Point(67, 139);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(254, 26);
			this.txtSaldo.TabIndex = 1;
			// 
			// txtInteres
			// 
			this.txtInteres.Location = new System.Drawing.Point(58, 242);
			this.txtInteres.Name = "txtInteres";
			this.txtInteres.Size = new System.Drawing.Size(148, 26);
			this.txtInteres.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(112, 289);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(132, 41);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblResultado.Location = new System.Drawing.Point(73, 352);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(229, 32);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado anual:\n";
			// 
			// lblAnual
			// 
			this.lblAnual.AutoSize = true;
			this.lblAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnual.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblAnual.Location = new System.Drawing.Point(223, 236);
			this.lblAnual.Name = "lblAnual";
			this.lblAnual.Size = new System.Drawing.Size(117, 32);
			this.lblAnual.TabIndex = 0;
			this.lblAnual.Text = "% anual";
			// 
			// Prog_Tema_2_Ej_11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(395, 450);
			this.Controls.Add(this.lblAnual);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtInteres);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.lblInteres);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_2_Ej_11";
			this.Text = "Prog_Tema_2_Ej_11";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.Label lblInteres;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.TextBox txtInteres;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblAnual;
		}
	}

