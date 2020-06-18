namespace ProyectoVectores
{
    partial class FrmNumerosLetras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNumerosLetras));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número entre 0 y 9.999.999";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(347, 57);
            this.txtNumero.MaxLength = 7;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(194, 22);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "El número en letras es :";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(48, 151);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(424, 103);
            this.txtResultado.TabIndex = 3;
            // 
            // FrmNumerosLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 301);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNumerosLetras";
            this.Text = "                                            FrmNumerosLetras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}