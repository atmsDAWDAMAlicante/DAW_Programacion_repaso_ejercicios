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
            this.grpTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIntroducir
            // 
            this.txtIntroducir.Location = new System.Drawing.Point(26, 22);
            this.txtIntroducir.Name = "txtIntroducir";
            this.txtIntroducir.Size = new System.Drawing.Size(278, 26);
            this.txtIntroducir.TabIndex = 1;
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(26, 66);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(119, 35);
            this.btnAccion.TabIndex = 2;
            this.btnAccion.Text = "Acción";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // grpTexto
            // 
            this.grpTexto.Controls.Add(this.lblResultado);
            this.grpTexto.Location = new System.Drawing.Point(26, 125);
            this.grpTexto.Name = "grpTexto";
            this.grpTexto.Size = new System.Drawing.Size(278, 302);
            this.grpTexto.TabIndex = 0;
            this.grpTexto.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(16, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 24);
            this.lblResultado.TabIndex = 3;
            // 
            // Prog_Tema_3_Ej_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
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
    }
}

