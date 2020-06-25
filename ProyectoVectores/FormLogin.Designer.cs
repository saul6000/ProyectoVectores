namespace ProyectoVectores
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btbingresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btbsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(348, 97);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(213, 22);
            this.txtusuario.TabIndex = 1;
            // 
            // btbingresar
            // 
            this.btbingresar.Location = new System.Drawing.Point(608, 75);
            this.btbingresar.Name = "btbingresar";
            this.btbingresar.Size = new System.Drawing.Size(97, 73);
            this.btbingresar.TabIndex = 2;
            this.btbingresar.Text = "Ingresar";
            this.btbingresar.UseVisualStyleBackColor = true;
            this.btbingresar.Click += new System.EventHandler(this.btbingresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(348, 193);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '#';
            this.txtcontraseña.Size = new System.Drawing.Size(213, 22);
            this.txtcontraseña.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 154);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btbsalir
            // 
            this.btbsalir.Location = new System.Drawing.Point(608, 180);
            this.btbsalir.Name = "btbsalir";
            this.btbsalir.Size = new System.Drawing.Size(97, 52);
            this.btbsalir.TabIndex = 7;
            this.btbsalir.Text = "Salir";
            this.btbsalir.UseVisualStyleBackColor = true;
            this.btbsalir.Click += new System.EventHandler(this.btbsalir_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbsalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbingresar);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btbingresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btbsalir;
    }
}