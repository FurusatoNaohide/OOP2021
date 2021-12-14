
namespace Prototype
{
    partial class Form8
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
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.gbRange = new System.Windows.Forms.GroupBox();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMonth.SuspendLayout();
            this.gbRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.radioButton12);
            this.gbMonth.Controls.Add(this.radioButton11);
            this.gbMonth.Controls.Add(this.radioButton10);
            this.gbMonth.Controls.Add(this.radioButton9);
            this.gbMonth.Controls.Add(this.radioButton8);
            this.gbMonth.Controls.Add(this.radioButton7);
            this.gbMonth.Controls.Add(this.radioButton6);
            this.gbMonth.Controls.Add(this.radioButton5);
            this.gbMonth.Controls.Add(this.radioButton4);
            this.gbMonth.Controls.Add(this.radioButton3);
            this.gbMonth.Controls.Add(this.radioButton2);
            this.gbMonth.Controls.Add(this.radioButton1);
            this.gbMonth.Location = new System.Drawing.Point(16, 47);
            this.gbMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMonth.Size = new System.Drawing.Size(221, 140);
            this.gbMonth.TabIndex = 0;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "月決算";
            // 
            // gbRange
            // 
            this.gbRange.Controls.Add(this.label1);
            this.gbRange.Controls.Add(this.cbYear);
            this.gbRange.Controls.Add(this.rbYear);
            this.gbRange.Controls.Add(this.rbMonth);
            this.gbRange.Controls.Add(this.gbMonth);
            this.gbRange.Location = new System.Drawing.Point(32, 24);
            this.gbRange.Name = "gbRange";
            this.gbRange.Size = new System.Drawing.Size(258, 274);
            this.gbRange.TabIndex = 2;
            this.gbRange.TabStop = false;
            this.gbRange.Text = "範囲選択";
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Checked = true;
            this.rbMonth.Location = new System.Drawing.Point(16, 21);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(58, 19);
            this.rbMonth.TabIndex = 0;
            this.rbMonth.TabStop = true;
            this.rbMonth.Tag = "0";
            this.rbMonth.Text = "月別";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(80, 21);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(73, 19);
            this.rbYear.TabIndex = 1;
            this.rbYear.Tag = "1";
            this.rbYear.Text = "年度別";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(97, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(178, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "1月";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(151, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Tag = "8";
            this.radioButton2.Text = "9月";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Tag = "9";
            this.radioButton3.Text = "10月";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(86, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 19);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Tag = "10";
            this.radioButton4.Text = "11月";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(151, 97);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 19);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.Tag = "11";
            this.radioButton5.Text = "12月";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(86, 72);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(51, 19);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.Tag = "7";
            this.radioButton6.Text = "8月";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(21, 72);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(51, 19);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Tag = "6";
            this.radioButton7.Text = "7月";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(151, 47);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(51, 19);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.Tag = "5";
            this.radioButton8.Text = "6月";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(86, 47);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(51, 19);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.Tag = "4";
            this.radioButton9.Text = "5月";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(21, 47);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(51, 19);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.Tag = "3";
            this.radioButton10.Text = "4月";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(151, 22);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(51, 19);
            this.radioButton11.TabIndex = 2;
            this.radioButton11.Tag = "2";
            this.radioButton11.Text = "3月";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(86, 22);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(51, 19);
            this.radioButton12.TabIndex = 1;
            this.radioButton12.Tag = "1";
            this.radioButton12.Text = "2月";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(65, 218);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 23);
            this.cbYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "年度決算";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbRange);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form8";
            this.Text = "範囲指定";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.gbRange.ResumeLayout(false);
            this.gbRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.GroupBox gbRange;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
    }
}