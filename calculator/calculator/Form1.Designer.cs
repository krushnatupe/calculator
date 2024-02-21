namespace calculator
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
            this.Calculator = new System.Windows.Forms.GroupBox();
            this.zero = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Controls.Add(this.zero);
            this.Calculator.Controls.Add(this.answer);
            this.Calculator.Controls.Add(this.clear);
            this.Calculator.Controls.Add(this.two);
            this.Calculator.Controls.Add(this.add);
            this.Calculator.Controls.Add(this.one);
            this.Calculator.Controls.Add(this.three);
            this.Calculator.Controls.Add(this.five);
            this.Calculator.Controls.Add(this.sub);
            this.Calculator.Controls.Add(this.four);
            this.Calculator.Controls.Add(this.six);
            this.Calculator.Controls.Add(this.eight);
            this.Calculator.Controls.Add(this.mul);
            this.Calculator.Controls.Add(this.seven);
            this.Calculator.Controls.Add(this.nine);
            this.Calculator.Controls.Add(this.div);
            this.Calculator.Controls.Add(this.label2);
            this.Calculator.Controls.Add(this.label1);
            this.Calculator.Location = new System.Drawing.Point(244, 65);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(307, 260);
            this.Calculator.TabIndex = 0;
            this.Calculator.TabStop = false;
            this.Calculator.Text = "groupBox1";
            this.Calculator.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(79, 218);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(63, 23);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(148, 218);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(63, 23);
            this.answer.TabIndex = 21;
            this.answer.Text = "=";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(6, 218);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(63, 23);
            this.clear.TabIndex = 20;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(79, 179);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(63, 23);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(229, 218);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(63, 23);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(6, 179);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(63, 23);
            this.one.TabIndex = 16;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(148, 179);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(63, 23);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(79, 138);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(63, 23);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(232, 179);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 23);
            this.sub.TabIndex = 23;
            this.sub.Text = "-";
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(6, 138);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(63, 23);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(148, 138);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(63, 23);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(79, 98);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(63, 23);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(229, 138);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(63, 23);
            this.mul.TabIndex = 9;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(6, 98);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(63, 23);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(148, 98);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(63, 23);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(229, 98);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(63, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.MaximumSize = new System.Drawing.Size(300, 300);
            this.label2.MinimumSize = new System.Drawing.Size(300, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.MinimumSize = new System.Drawing.Size(300, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.Calculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Calculator;
        private Label label1;
        private Label label2;
        private Button div;
        private Button five;
        private Button sub;
        private Button four;
        private Button six;
        private Button eight;
        private Button mul;
        private Button seven;
        private Button nine;
        private Button two;
        private Button add;
        private Button one;
        private Button three;
        private Button zero;
        private Button answer;
        private Button clear;
    }
}