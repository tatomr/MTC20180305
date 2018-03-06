namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Operator = new System.Windows.Forms.GroupBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.Operator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Value:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Value:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(45, 42);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(45, 108);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(45, 208);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Operator
            // 
            this.Operator.Controls.Add(this.rbDivide);
            this.Operator.Controls.Add(this.rbMultiply);
            this.Operator.Controls.Add(this.rbSubtract);
            this.Operator.Controls.Add(this.rbAdd);
            this.Operator.Location = new System.Drawing.Point(217, 42);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(105, 123);
            this.Operator.TabIndex = 7;
            this.Operator.TabStop = false;
            this.Operator.Text = "Operator";
            this.Operator.Enter += new System.EventHandler(this.Operator_Enter);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(6, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(6, 42);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbSubtract.TabIndex = 1;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(6, 65);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(6, 88);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            this.rbDivide.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operator.ResumeLayout(false);
            this.Operator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Operator;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbAdd;
    }
}

