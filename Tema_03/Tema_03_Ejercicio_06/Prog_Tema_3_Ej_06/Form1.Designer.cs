namespace Prog_Tema_3_Ej_06
{
    partial class Prog_Tema_3_Ej_06
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
			this.txtNota = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.lblSalida = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNota
			// 
			this.txtNota.Location = new System.Drawing.Point(222, 68);
			this.txtNota.Name = "txtNota";
			this.txtNota.Size = new System.Drawing.Size(100, 26);
			this.txtNota.TabIndex = 1;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.Orange;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.Location = new System.Drawing.Point(107, 109);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(132, 44);
			this.btnAccion.TabIndex = 2;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(9, 209);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 29);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(9, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(338, 37);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Notas/Calificaciones:";
			// 
			// lblEntrada
			// 
			this.lblEntrada.AutoSize = true;
			this.lblEntrada.Location = new System.Drawing.Point(9, 71);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(207, 20);
			this.lblEntrada.TabIndex = 0;
			this.lblEntrada.Text = "Introduce un número (nota):";
			// 
			// lblSalida
			// 
			this.lblSalida.AutoSize = true;
			this.lblSalida.Location = new System.Drawing.Point(9, 170);
			this.lblSalida.Name = "lblSalida";
			this.lblSalida.Size = new System.Drawing.Size(199, 20);
			this.lblSalida.TabIndex = 0;
			this.lblSalida.Text = "La calificación obtenida es:";
			// 
			// Prog_Tema_3_Ej_06
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(413, 286);
			this.Controls.Add(this.lblSalida);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNota);
			this.Name = "Prog_Tema_3_Ej_06";
			this.Text = "Prog_Tema_3_Ej_06";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblEntrada;
		private System.Windows.Forms.Label lblSalida;
		}
}

