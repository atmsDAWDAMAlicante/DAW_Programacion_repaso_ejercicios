namespace Prog_Tema_3_Ej_13
	{
	partial class Prog_Tema_3_Ej_13
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
			this.btnDoWhile = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(2, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(459, 46);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Bucles: sólo con pares.";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(460, 26);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(239, 25);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el número límite:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.ForestGreen;
			this.txtNumero.Location = new System.Drawing.Point(720, 20);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(60, 30);
			this.txtNumero.TabIndex = 1;
			// 
			// btnBucleFor
			// 
			this.btnBucleFor.BackColor = System.Drawing.Color.ForestGreen;
			this.btnBucleFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBucleFor.ForeColor = System.Drawing.Color.Yellow;
			this.btnBucleFor.Location = new System.Drawing.Point(12, 60);
			this.btnBucleFor.Name = "btnBucleFor";
			this.btnBucleFor.Size = new System.Drawing.Size(140, 45);
			this.btnBucleFor.TabIndex = 2;
			this.btnBucleFor.Text = "Bucle For";
			this.btnBucleFor.UseVisualStyleBackColor = false;
			this.btnBucleFor.Click += new System.EventHandler(this.btnBucleFor_Click);
			// 
			// btnBucleWhile
			// 
			this.btnBucleWhile.BackColor = System.Drawing.Color.ForestGreen;
			this.btnBucleWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBucleWhile.ForeColor = System.Drawing.Color.Yellow;
			this.btnBucleWhile.Location = new System.Drawing.Point(156, 60);
			this.btnBucleWhile.Name = "btnBucleWhile";
			this.btnBucleWhile.Size = new System.Drawing.Size(190, 45);
			this.btnBucleWhile.TabIndex = 3;
			this.btnBucleWhile.Text = "Bucle While";
			this.btnBucleWhile.UseVisualStyleBackColor = false;
			this.btnBucleWhile.Click += new System.EventHandler(this.btnBucleWhile_Click);
			// 
			// btnDoWhile
			// 
			this.btnDoWhile.BackColor = System.Drawing.Color.ForestGreen;
			this.btnDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoWhile.ForeColor = System.Drawing.Color.Yellow;
			this.btnDoWhile.Location = new System.Drawing.Point(350, 60);
			this.btnDoWhile.Name = "btnDoWhile";
			this.btnDoWhile.Size = new System.Drawing.Size(270, 45);
			this.btnDoWhile.TabIndex = 4;
			this.btnDoWhile.Text = "Bucle Do While";
			this.btnDoWhile.UseVisualStyleBackColor = false;
			this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(12, 121);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(192, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Preparados... listos...";
			// 
			// Prog_Tema_3_Ej_13
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Chartreuse;
			this.ClientSize = new System.Drawing.Size(800, 160);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnDoWhile);
			this.Controls.Add(this.btnBucleWhile);
			this.Controls.Add(this.btnBucleFor);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Prog_Tema_3_Ej_13";
			this.Text = "Prog_Tema_3_Ej_13";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnBucleFor;
		private System.Windows.Forms.Button btnBucleWhile;
		private System.Windows.Forms.Button btnDoWhile;
		private System.Windows.Forms.Label lblResultado;
		}
	}

