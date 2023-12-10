namespace Prog_Tema_4_Ej_03
{
    partial class Prog_Tema_4_Ej_03
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblNumeroA = new System.Windows.Forms.Label();
            this.lblNumeroB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(33, 28);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(160, 26);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(33, 80);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(160, 26);
            this.txtNumero2.TabIndex = 1;
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(54, 135);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(111, 30);
            this.btnAccion.TabIndex = 2;
            this.btnAccion.Text = "Acción";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblNumeroA
            // 
            this.lblNumeroA.AutoSize = true;
            this.lblNumeroA.Location = new System.Drawing.Point(38, 190);
            this.lblNumeroA.Name = "lblNumeroA";
            this.lblNumeroA.Size = new System.Drawing.Size(21, 20);
            this.lblNumeroA.TabIndex = 3;
            this.lblNumeroA.Text = "...";
            // 
            // lblNumeroB
            // 
            this.lblNumeroB.AutoSize = true;
            this.lblNumeroB.Location = new System.Drawing.Point(38, 244);
            this.lblNumeroB.Name = "lblNumeroB";
            this.lblNumeroB.Size = new System.Drawing.Size(21, 20);
            this.lblNumeroB.TabIndex = 4;
            this.lblNumeroB.Text = "...";
            // 
            // Prog_Tema_4_Ej_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 295);
            this.Controls.Add(this.lblNumeroB);
            this.Controls.Add(this.lblNumeroA);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Prog_Tema_4_Ej_03";
            this.Text = "Prog_Tema_4_Ej_03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblNumeroA;
        private System.Windows.Forms.Label lblNumeroB;
    }
}

