namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb1bim = new System.Windows.Forms.TextBox();
            this.txb2bim = new System.Windows.Forms.TextBox();
            this.txb3bim = new System.Windows.Forms.TextBox();
            this.txb4bim = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(94, 40);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1º bim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2º bim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3º bim";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "4º bim";
            // 
            // txb1bim
            // 
            this.txb1bim.Location = new System.Drawing.Point(61, 82);
            this.txb1bim.Name = "txb1bim";
            this.txb1bim.Size = new System.Drawing.Size(45, 20);
            this.txb1bim.TabIndex = 6;
            this.txb1bim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txb2bim
            // 
            this.txb2bim.Location = new System.Drawing.Point(61, 119);
            this.txb2bim.Name = "txb2bim";
            this.txb2bim.Size = new System.Drawing.Size(49, 20);
            this.txb2bim.TabIndex = 7;
            // 
            // txb3bim
            // 
            this.txb3bim.Location = new System.Drawing.Point(209, 85);
            this.txb3bim.Name = "txb3bim";
            this.txb3bim.Size = new System.Drawing.Size(42, 20);
            this.txb3bim.TabIndex = 8;
            // 
            // txb4bim
            // 
            this.txb4bim.Location = new System.Drawing.Point(209, 116);
            this.txb4bim.Name = "txb4bim";
            this.txb4bim.Size = new System.Drawing.Size(39, 20);
            this.txb4bim.TabIndex = 9;
            this.txb4bim.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(106, 167);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 10;
            this.Calc.Text = "Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(61, 196);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(178, 20);
            this.res.TabIndex = 11;
            this.res.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.res);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.txb4bim);
            this.Controls.Add(this.txb3bim);
            this.Controls.Add(this.txb2bim);
            this.Controls.Add(this.txb1bim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb1bim;
        private System.Windows.Forms.TextBox txb2bim;
        private System.Windows.Forms.TextBox txb3bim;
        private System.Windows.Forms.TextBox txb4bim;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox res;
    }
}

