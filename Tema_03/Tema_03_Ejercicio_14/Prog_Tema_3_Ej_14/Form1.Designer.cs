namespace Prog_Tema_3_Ej_14
	{
	partial class Prog_Tema_3_Ej_14
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
			this.grpPizarra = new System.Windows.Forms.GroupBox();
			this.btnBucleWhile = new System.Windows.Forms.Button();
			this.btnBucleFor = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.grpPizarra.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPizarra
			// 
			this.grpPizarra.Controls.Add(this.btnBucleWhile);
			this.grpPizarra.Controls.Add(this.btnBucleFor);
			this.grpPizarra.Controls.Add(this.lblResultado);
			this.grpPizarra.Controls.Add(this.txtNumero);
			this.grpPizarra.Controls.Add(this.lblSubtitulo);
			this.grpPizarra.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPizarra.ForeColor = System.Drawing.Color.White;
			this.grpPizarra.Location = new System.Drawing.Point(35, 114);
			this.grpPizarra.Name = "grpPizarra";
			this.grpPizarra.Size = new System.Drawing.Size(559, 298);
			this.grpPizarra.TabIndex = 0;
			this.grpPizarra.TabStop = false;
			this.grpPizarra.Text = "Pizarra";
			// 
			// btnBucleWhile
			// 
			this.btnBucleWhile.BackColor = System.Drawing.Color.DimGray;
			this.btnBucleWhile.Location = new System.Drawing.Point(294, 103);
			this.btnBucleWhile.Name = "btnBucleWhile";
			this.btnBucleWhile.Size = new System.Drawing.Size(192, 54);
			this.btnBucleWhile.TabIndex = 3;
			this.btnBucleWhile.Text = "Bucle While";
			this.btnBucleWhile.UseVisualStyleBackColor = false;
			this.btnBucleWhile.Click += new System.EventHandler(this.btnBucleWhile_Click);
			// 
			// btnBucleFor
			// 
			this.btnBucleFor.BackColor = System.Drawing.Color.DimGray;
			this.btnBucleFor.Location = new System.Drawing.Point(46, 103);
			this.btnBucleFor.Name = "btnBucleFor";
			this.btnBucleFor.Size = new System.Drawing.Size(171, 54);
			this.btnBucleFor.TabIndex = 2;
			this.btnBucleFor.Text = "Bucle For";
			this.btnBucleFor.UseVisualStyleBackColor = false;
			this.btnBucleFor.Click += new System.EventHandler(this.btnBucleFor_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(63, 193);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(251, 67);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(399, 40);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 47);
			this.txtNumero.TabIndex = 1;
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Location = new System.Drawing.Point(40, 43);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(349, 39);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "... escribe un número...";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(78, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(473, 100);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Sumatorio Σ";
			// 
			// Prog_Tema_3_Ej_14
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(628, 450);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.grpPizarra);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Prog_Tema_3_Ej_14";
			this.Text = "Prog_Tema_3_Ej_14";
			this.grpPizarra.ResumeLayout(false);
			this.grpPizarra.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.GroupBox grpPizarra;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Button btnBucleFor;
		private System.Windows.Forms.Button btnBucleWhile;
		}
	}

