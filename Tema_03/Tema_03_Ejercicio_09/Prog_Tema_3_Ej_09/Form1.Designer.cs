namespace Prog_Tema_3_Ej_09
{
    partial class Prog_Tema_3_Ej_09
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnSuCambio = new System.Windows.Forms.Button();
            this.grpSuCambio = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpSuCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Introduce una cantidad en pesetas";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 59);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 26);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnSuCambio
            // 
            this.btnSuCambio.Location = new System.Drawing.Point(159, 55);
            this.btnSuCambio.Name = "btnSuCambio";
            this.btnSuCambio.Size = new System.Drawing.Size(109, 37);
            this.btnSuCambio.TabIndex = 2;
            this.btnSuCambio.Text = "Su cambio";
            this.btnSuCambio.UseVisualStyleBackColor = true;
            this.btnSuCambio.Click += new System.EventHandler(this.btnSuCambio_Click);
            // 
            // grpSuCambio
            // 
            this.grpSuCambio.Controls.Add(this.lblResultado);
            this.grpSuCambio.Location = new System.Drawing.Point(16, 98);
            this.grpSuCambio.Name = "grpSuCambio";
            this.grpSuCambio.Size = new System.Drawing.Size(252, 332);
            this.grpSuCambio.TabIndex = 0;
            this.grpSuCambio.TabStop = false;
            this.grpSuCambio.Text = "Su cambio:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 24);
            this.lblResultado.TabIndex = 0;
            // 
            // Prog_Tema_3_Ej_09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.grpSuCambio);
            this.Controls.Add(this.btnSuCambio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Prog_Tema_3_Ej_09";
            this.Text = "Prog_Tema_3_Ej_09";
            this.grpSuCambio.ResumeLayout(false);
            this.grpSuCambio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSuCambio;
        private System.Windows.Forms.GroupBox grpSuCambio;
        private System.Windows.Forms.Label lblResultado;
    }
}

