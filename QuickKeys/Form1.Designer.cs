namespace QuickKeys
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoDistribution = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rdoNewDistribution = new System.Windows.Forms.RadioButton();
            this.rdoAppendDistribution = new System.Windows.Forms.RadioButton();
            this.rdoDatedependingDistrivution = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Pegelschrieb";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoDistribution
            // 
            this.rdoDistribution.AutoSize = true;
            this.rdoDistribution.Location = new System.Drawing.Point(25, 164);
            this.rdoDistribution.Name = "rdoDistribution";
            this.rdoDistribution.Size = new System.Drawing.Size(77, 17);
            this.rdoDistribution.TabIndex = 2;
            this.rdoDistribution.Text = "Distribution";
            this.rdoDistribution.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(187, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "31 Days";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 187);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "PDF";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(25, 210);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(122, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Marker as document";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(136, 164);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(231, 20);
            this.txtBox.TabIndex = 7;
            this.txtBox.Text = "Document 2017-11-07_07-58-14-791.docx";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Change Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(300, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rdoNewDistribution
            // 
            this.rdoNewDistribution.AutoSize = true;
            this.rdoNewDistribution.Checked = true;
            this.rdoNewDistribution.Location = new System.Drawing.Point(25, 233);
            this.rdoNewDistribution.Name = "rdoNewDistribution";
            this.rdoNewDistribution.Size = new System.Drawing.Size(102, 17);
            this.rdoNewDistribution.TabIndex = 10;
            this.rdoNewDistribution.TabStop = true;
            this.rdoNewDistribution.Text = "New Distribution";
            this.rdoNewDistribution.UseVisualStyleBackColor = true;
            this.rdoNewDistribution.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoAppendDistribution
            // 
            this.rdoAppendDistribution.AutoSize = true;
            this.rdoAppendDistribution.Location = new System.Drawing.Point(25, 256);
            this.rdoAppendDistribution.Name = "rdoAppendDistribution";
            this.rdoAppendDistribution.Size = new System.Drawing.Size(117, 17);
            this.rdoAppendDistribution.TabIndex = 11;
            this.rdoAppendDistribution.Text = "Append Distribution";
            this.rdoAppendDistribution.UseVisualStyleBackColor = true;
            this.rdoAppendDistribution.CheckedChanged += new System.EventHandler(this.rdoAppendDistribution_CheckedChanged);
            // 
            // rdoDatedependingDistrivution
            // 
            this.rdoDatedependingDistrivution.AutoSize = true;
            this.rdoDatedependingDistrivution.Location = new System.Drawing.Point(25, 279);
            this.rdoDatedependingDistrivution.Name = "rdoDatedependingDistrivution";
            this.rdoDatedependingDistrivution.Size = new System.Drawing.Size(158, 17);
            this.rdoDatedependingDistrivution.TabIndex = 12;
            this.rdoDatedependingDistrivution.Text = "Date Depending Distribution";
            this.rdoDatedependingDistrivution.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(300, 230);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 303);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.rdoDatedependingDistrivution);
            this.Controls.Add(this.rdoAppendDistribution);
            this.Controls.Add(this.rdoNewDistribution);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rdoDistribution);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoDistribution;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rdoNewDistribution;
        private System.Windows.Forms.RadioButton rdoAppendDistribution;
        private System.Windows.Forms.RadioButton rdoDatedependingDistrivution;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

