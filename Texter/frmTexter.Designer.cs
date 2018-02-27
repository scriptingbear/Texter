namespace Texter
{
    partial class frmTexter
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reverseChars = new System.Windows.Forms.RadioButton();
            this.reverseWords = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trimExternalBlanks = new System.Windows.Forms.CheckBox();
            this.trimInternalBlanks = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.caseOptions = new System.Windows.Forms.GroupBox();
            this.convertProper = new System.Windows.Forms.RadioButton();
            this.convertLower = new System.Windows.Forms.RadioButton();
            this.convertUpper = new System.Windows.Forms.RadioButton();
            this.fontSelector = new System.Windows.Forms.FontDialog();
            this.selectFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.minWordLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.twistedText = new System.Windows.Forms.TextBox();
            this.reverseNone = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.caseOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minWordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select modification  and then enter some text";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 64);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(542, 93);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.twistedText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // reverseChars
            // 
            this.reverseChars.AutoSize = true;
            this.reverseChars.Location = new System.Drawing.Point(15, 46);
            this.reverseChars.Name = "reverseChars";
            this.reverseChars.Size = new System.Drawing.Size(91, 20);
            this.reverseChars.TabIndex = 0;
            this.reverseChars.Text = "Characters";
            this.reverseChars.UseVisualStyleBackColor = true;
            // 
            // reverseWords
            // 
            this.reverseWords.AutoSize = true;
            this.reverseWords.Location = new System.Drawing.Point(15, 72);
            this.reverseWords.Name = "reverseWords";
            this.reverseWords.Size = new System.Drawing.Size(66, 20);
            this.reverseWords.TabIndex = 1;
            this.reverseWords.Text = "Words";
            this.reverseWords.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reverseNone);
            this.groupBox1.Controls.Add(this.reverseChars);
            this.groupBox1.Controls.Add(this.reverseWords);
            this.groupBox1.Location = new System.Drawing.Point(15, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reverse";
            // 
            // trimExternalBlanks
            // 
            this.trimExternalBlanks.AutoSize = true;
            this.trimExternalBlanks.Location = new System.Drawing.Point(16, 21);
            this.trimExternalBlanks.Name = "trimExternalBlanks";
            this.trimExternalBlanks.Size = new System.Drawing.Size(125, 20);
            this.trimExternalBlanks.TabIndex = 0;
            this.trimExternalBlanks.Text = "Leading/Trailing";
            this.trimExternalBlanks.UseVisualStyleBackColor = true;
            // 
            // trimInternalBlanks
            // 
            this.trimInternalBlanks.AutoSize = true;
            this.trimInternalBlanks.Location = new System.Drawing.Point(16, 47);
            this.trimInternalBlanks.Name = "trimInternalBlanks";
            this.trimInternalBlanks.Size = new System.Drawing.Size(70, 20);
            this.trimInternalBlanks.TabIndex = 1;
            this.trimInternalBlanks.Text = "Internal";
            this.trimInternalBlanks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trimExternalBlanks);
            this.groupBox2.Controls.Add(this.trimInternalBlanks);
            this.groupBox2.Location = new System.Drawing.Point(155, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trim Blanks";
            // 
            // caseOptions
            // 
            this.caseOptions.Controls.Add(this.convertProper);
            this.caseOptions.Controls.Add(this.convertLower);
            this.caseOptions.Controls.Add(this.convertUpper);
            this.caseOptions.Location = new System.Drawing.Point(328, 332);
            this.caseOptions.Name = "caseOptions";
            this.caseOptions.Size = new System.Drawing.Size(106, 117);
            this.caseOptions.TabIndex = 3;
            this.caseOptions.TabStop = false;
            this.caseOptions.Text = "Casing";
            // 
            // convertProper
            // 
            this.convertProper.AutoSize = true;
            this.convertProper.Location = new System.Drawing.Point(14, 78);
            this.convertProper.Name = "convertProper";
            this.convertProper.Size = new System.Drawing.Size(67, 20);
            this.convertProper.TabIndex = 2;
            this.convertProper.TabStop = true;
            this.convertProper.Text = "Proper";
            this.convertProper.UseVisualStyleBackColor = true;
            // 
            // convertLower
            // 
            this.convertLower.AutoSize = true;
            this.convertLower.Location = new System.Drawing.Point(14, 52);
            this.convertLower.Name = "convertLower";
            this.convertLower.Size = new System.Drawing.Size(62, 20);
            this.convertLower.TabIndex = 1;
            this.convertLower.TabStop = true;
            this.convertLower.Text = "Lower";
            this.convertLower.UseVisualStyleBackColor = true;
            // 
            // convertUpper
            // 
            this.convertUpper.AutoSize = true;
            this.convertUpper.Location = new System.Drawing.Point(14, 26);
            this.convertUpper.Name = "convertUpper";
            this.convertUpper.Size = new System.Drawing.Size(64, 20);
            this.convertUpper.TabIndex = 0;
            this.convertUpper.TabStop = true;
            this.convertUpper.Text = "Upper";
            this.convertUpper.UseVisualStyleBackColor = true;
            // 
            // selectFont
            // 
            this.selectFont.Location = new System.Drawing.Point(15, 453);
            this.selectFont.Name = "selectFont";
            this.selectFont.Size = new System.Drawing.Size(75, 23);
            this.selectFont.TabIndex = 4;
            this.selectFont.Text = "Font...";
            this.selectFont.UseVisualStyleBackColor = true;
            this.selectFont.Click += new System.EventHandler(this.selectFont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min Word Length";
            // 
            // minWordLength
            // 
            this.minWordLength.Location = new System.Drawing.Point(257, 456);
            this.minWordLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minWordLength.Name = "minWordLength";
            this.minWordLength.ReadOnly = true;
            this.minWordLength.Size = new System.Drawing.Size(65, 22);
            this.minWordLength.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR HERMANN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Twisted Text";
            // 
            // twistedText
            // 
            this.twistedText.Location = new System.Drawing.Point(10, 210);
            this.twistedText.Multiline = true;
            this.twistedText.Name = "twistedText";
            this.twistedText.ReadOnly = true;
            this.twistedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.twistedText.Size = new System.Drawing.Size(544, 116);
            this.twistedText.TabIndex = 15;
            // 
            // reverseNone
            // 
            this.reverseNone.AutoSize = true;
            this.reverseNone.Checked = true;
            this.reverseNone.Location = new System.Drawing.Point(15, 21);
            this.reverseNone.Name = "reverseNone";
            this.reverseNone.Size = new System.Drawing.Size(59, 20);
            this.reverseNone.TabIndex = 2;
            this.reverseNone.TabStop = true;
            this.reverseNone.Text = "None";
            this.reverseNone.UseVisualStyleBackColor = true;
            // 
            // frmTexter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 517);
            this.Controls.Add(this.twistedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minWordLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectFont);
            this.Controls.Add(this.caseOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTexter";
            this.Text = "Text Twister!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.caseOptions.ResumeLayout(false);
            this.caseOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minWordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton reverseChars;
        private System.Windows.Forms.RadioButton reverseWords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox trimExternalBlanks;
        private System.Windows.Forms.CheckBox trimInternalBlanks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox caseOptions;
        private System.Windows.Forms.RadioButton convertProper;
        private System.Windows.Forms.RadioButton convertLower;
        private System.Windows.Forms.RadioButton convertUpper;
        private System.Windows.Forms.FontDialog fontSelector;
        private System.Windows.Forms.Button selectFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minWordLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox twistedText;
        private System.Windows.Forms.RadioButton reverseNone;
    }
}

