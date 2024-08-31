namespace Prog_Tema_3_Ej_23
	{
	partial class Prog_Tema_3_Ej_23
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblAlerta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(14, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(570, 64);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Peso de los Alumnos";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(20, 80);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(329, 50);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduce el peso de los alumnos\nmediante un InputBox:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(20, 191);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.White;
			this.btnAccion.Location = new System.Drawing.Point(280, 80);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(180, 50);
			this.btnAccion.TabIndex = 1;
			this.btnAccion.Text = "Insertar pesos";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblAlerta
			// 
			this.lblAlerta.AutoSize = true;
			this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlerta.ForeColor = System.Drawing.Color.Red;
			this.lblAlerta.Location = new System.Drawing.Point(20, 147);
			this.lblAlerta.Name = "lblAlerta";
			this.lblAlerta.Size = new System.Drawing.Size(51, 20);
			this.lblAlerta.TabIndex = 0;
			this.lblAlerta.Text = "Alerta";
			// 
			// Prog_Tema_3_Ej_23
			// 
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(500, 413);
			this.Controls.Add(this.lblAlerta);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblResultado);
			this.Name = "Prog_Tema_3_Ej_23";
			this.Text = "Prog_Tema_3_Ej_23";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnAccion;
		private System.Windows.Forms.Label lblAlerta;
		}
	}

