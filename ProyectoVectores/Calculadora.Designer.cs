namespace ProyectoVectores
{
    partial class Calculadora
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btbdelete = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(32, 69);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(535, 22);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.TextChanged += new System.EventHandler(this.txtPantalla_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btndivision);
            this.groupBox1.Controls.Add(this.btnproducto);
            this.groupBox1.Controls.Add(this.btnresta);
            this.groupBox1.Controls.Add(this.btnsuma);
            this.groupBox1.Controls.Add(this.btbdelete);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Location = new System.Drawing.Point(26, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 335);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PNumber);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(293, 190);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(85, 33);
            this.btndivision.TabIndex = 16;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.Operaciones);
            // 
            // btnproducto
            // 
            this.btnproducto.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.Location = new System.Drawing.Point(293, 120);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(85, 40);
            this.btnproducto.TabIndex = 15;
            this.btnproducto.Text = "*";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.Operaciones);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(293, 44);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(85, 44);
            this.btnresta.TabIndex = 14;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.Operaciones);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(293, 261);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(85, 41);
            this.btnsuma.TabIndex = 13;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.Operaciones);
            // 
            // btbdelete
            // 
            this.btbdelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbdelete.Location = new System.Drawing.Point(94, 261);
            this.btbdelete.Name = "btbdelete";
            this.btbdelete.Size = new System.Drawing.Size(112, 39);
            this.btbdelete.TabIndex = 12;
            this.btbdelete.Text = "CE";
            this.btbdelete.UseVisualStyleBackColor = true;
            this.btbdelete.Click += new System.EventHandler(this.btbdelete_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(212, 190);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 33);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.PNumber);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(113, 194);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 33);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.PNumber);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(6, 190);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 33);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.PNumber);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(212, 120);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 40);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.PNumber);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(212, 44);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 44);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.PNumber);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(113, 120);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 40);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.PNumber);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(6, 261);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 39);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.PNumber);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(6, 44);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 44);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.PNumber);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(113, 44);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 44);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.PNumber);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(6, 120);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 40);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.PNumber);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(396, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 179);
            this.button3.TabIndex = 20;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button20_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPantalla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btbdelete;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button3;
    }
}