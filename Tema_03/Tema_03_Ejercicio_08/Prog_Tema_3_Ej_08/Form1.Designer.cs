namespace Prog_Tema_3_Ej_08
{
    partial class Prog_Tema_3_Ej_08
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
			this.txtIntroducir = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.grpTexto = new System.Windows.Forms.GroupBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.grpTexto.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtIntroducir
			// 
			this.txtIntroducir.Location = new System.Drawing.Point(26, 88);
			this.txtIntroducir.Name = "txtIntroducir";
			this.txtIntroducir.Size = new System.Drawing.Size(278, 26);
			this.txtIntroducir.TabIndex = 1;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.DarkGreen;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.Gold;
			this.btnAccion.Location = new System.Drawing.Point(26, 126);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(142, 50);
			this.btnAccion.TabIndex = 2;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// grpTexto
			// 
			this.grpTexto.Controls.Add(this.lblResultado);
			this.grpTexto.ForeColor = System.Drawing.Color.Gold;
			this.grpTexto.Location = new System.Drawing.Point(26, 182);
			this.grpTexto.Name = "grpTexto";
			this.grpTexto.Size = new System.Drawing.Size(314, 337);
			this.grpTexto.TabIndex = 0;
			this.grpTexto.TabStop = false;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(6, 22);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(126, 25);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "(su mensaje)";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
			this.lblTitulo.Location = new System.Drawing.Point(26, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(314, 39);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Impresión de texto";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Gold;
			this.lblSubtitulo.Location = new System.Drawing.Point(26, 57);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(182, 25);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Introduzca su texto:";
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.DarkGreen;
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.ForeColor = System.Drawing.Color.Gold;
			this.btnBorrar.Location = new System.Drawing.Point(174, 126);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(130, 50);
			this.btnBorrar.TabIndex = 3;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// Prog_Tema_3_Ej_08
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(410, 538);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.grpTexto);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtIntroducir);
			this.Name = "Prog_Tema_3_Ej_08";
			this.Text = "Prog_Tema_3_Ej_08";
			this.grpTexto.ResumeLayout(false);
			this.grpTexto.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntroducir;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.GroupBox grpTexto;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Button btnBorrar;
		}
}

