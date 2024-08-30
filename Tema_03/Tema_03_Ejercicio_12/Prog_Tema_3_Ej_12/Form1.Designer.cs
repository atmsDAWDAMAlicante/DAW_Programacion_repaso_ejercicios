namespace Prog_Tema_3_Ej_12
	{
	partial class Prog_Tema_3_Ej_12
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
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnBucleFor = new System.Windows.Forms.Button();
			this.btnBucleWhile = new System.Windows.Forms.Button();
			this.btnBucleDoWhile = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTipoBucle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(12, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(359, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Tres tipos de bucles";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(378, 25);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(324, 29);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el número límite:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.DodgerBlue;
			this.txtNumero.Location = new System.Drawing.Point(717, 22);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(120, 35);
			this.txtNumero.TabIndex = 1;
			// 
			// btnBucleFor
			// 
			this.btnBucleFor.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnBucleFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBucleFor.ForeColor = System.Drawing.Color.White;
			this.btnBucleFor.Location = new System.Drawing.Point(12, 76);
			this.btnBucleFor.Name = "btnBucleFor";
			this.btnBucleFor.Size = new System.Drawing.Size(212, 43);
			this.btnBucleFor.TabIndex = 2;
			this.btnBucleFor.Text = "Bucle For";
			this.btnBucleFor.UseVisualStyleBackColor = false;
			this.btnBucleFor.Click += new System.EventHandler(this.btnBucleFor_Click);
			// 
			// btnBucleWhile
			// 
			this.btnBucleWhile.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnBucleWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBucleWhile.ForeColor = System.Drawing.Color.White;
			this.btnBucleWhile.Location = new System.Drawing.Point(240, 76);
			this.btnBucleWhile.Name = "btnBucleWhile";
			this.btnBucleWhile.Size = new System.Drawing.Size(212, 43);
			this.btnBucleWhile.TabIndex = 3;
			this.btnBucleWhile.Text = "Bucle While";
			this.btnBucleWhile.UseVisualStyleBackColor = false;
			this.btnBucleWhile.Click += new System.EventHandler(this.btnBucleWhile_Click);
			// 
			// btnBucleDoWhile
			// 
			this.btnBucleDoWhile.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnBucleDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBucleDoWhile.ForeColor = System.Drawing.Color.White;
			this.btnBucleDoWhile.Location = new System.Drawing.Point(463, 76);
			this.btnBucleDoWhile.Name = "btnBucleDoWhile";
			this.btnBucleDoWhile.Size = new System.Drawing.Size(250, 43);
			this.btnBucleDoWhile.TabIndex = 4;
			this.btnBucleDoWhile.Text = "Bucle Do While";
			this.btnBucleDoWhile.UseVisualStyleBackColor = false;
			this.btnBucleDoWhile.Click += new System.EventHandler(this.btnBucleDoWhile_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(12, 140);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(195, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "preparados... listos... ";
			// 
			// lblTipoBucle
			// 
			this.lblTipoBucle.AutoSize = true;
			this.lblTipoBucle.ForeColor = System.Drawing.Color.White;
			this.lblTipoBucle.Location = new System.Drawing.Point(724, 87);
			this.lblTipoBucle.Name = "lblTipoBucle";
			this.lblTipoBucle.Size = new System.Drawing.Size(105, 20);
			this.lblTipoBucle.TabIndex = 0;
			this.lblTipoBucle.Text = "Tipo de Bucle";
			// 
			// Prog_Tema_3_Ej_12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(873, 191);
			this.Controls.Add(this.lblTipoBucle);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnBucleDoWhile);
			this.Controls.Add(this.btnBucleWhile);
			this.Controls.Add(this.btnBucleFor);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_12";
			this.Text = "Prog_Tema_3_Ej_12";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnBucleFor;
		private System.Windows.Forms.Button btnBucleWhile;
		private System.Windows.Forms.Button btnBucleDoWhile;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTipoBucle;
		}
	}

