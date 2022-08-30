namespace Aula01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.caixa1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caixa2 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comparar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultadoadv = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // caixa1
            // 
            this.caixa1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixa1.Location = new System.Drawing.Point(35, 34);
            this.caixa1.Name = "caixa1";
            this.caixa1.Size = new System.Drawing.Size(163, 24);
            this.caixa1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Somar";
            // 
            // caixa2
            // 
            this.caixa2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixa2.Location = new System.Drawing.Point(35, 64);
            this.caixa2.Name = "caixa2";
            this.caixa2.Size = new System.Drawing.Size(163, 24);
            this.caixa2.TabIndex = 4;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.SystemColors.Highlight;
            this.total.Location = new System.Drawing.Point(35, 120);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(58, 28);
            this.total.TabIndex = 5;
            this.total.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comparar
            // 
            this.comparar.AutoSize = true;
            this.comparar.Location = new System.Drawing.Point(72, 166);
            this.comparar.Name = "comparar";
            this.comparar.Size = new System.Drawing.Size(89, 15);
            this.comparar.TabIndex = 9;
            this.comparar.Text = "COMPARAÇÃO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caixa1);
            this.groupBox1.Controls.Add(this.comparar);
            this.groupBox1.Controls.Add(this.caixa2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultadoadv);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 205);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adivinhe";
            // 
            // resultadoadv
            // 
            this.resultadoadv.AutoSize = true;
            this.resultadoadv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultadoadv.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultadoadv.Location = new System.Drawing.Point(118, 153);
            this.resultadoadv.Name = "resultadoadv";
            this.resultadoadv.Size = new System.Drawing.Size(39, 28);
            this.resultadoadv.TabIndex = 10;
            this.resultadoadv.Text = "???";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Adivinhar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um valor de 0 a 10";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox caixa1;
        private Button button1;
        private Label label1;
        private TextBox caixa2;
        private Label total;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label comparar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label resultadoadv;
        private Button button5;
        private Label label2;
        private TextBox textBox1;
    }
}