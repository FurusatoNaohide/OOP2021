
namespace Exercise1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btReadAllLine = new System.Windows.Forms.Button();
            this.btReadLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutPut
            // 
            this.tbOutPut.Location = new System.Drawing.Point(31, 61);
            this.tbOutPut.Multiline = true;
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.Size = new System.Drawing.Size(705, 442);
            this.tbOutPut.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(31, 9);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 37);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(121, 27);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(100, 19);
            this.tbKeyWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "キーワード";
            // 
            // btReadAllLine
            // 
            this.btReadAllLine.Location = new System.Drawing.Point(244, 12);
            this.btReadAllLine.Name = "btReadAllLine";
            this.btReadAllLine.Size = new System.Drawing.Size(75, 37);
            this.btReadAllLine.TabIndex = 4;
            this.btReadAllLine.Text = "ReadAllLine";
            this.btReadAllLine.UseVisualStyleBackColor = true;
            this.btReadAllLine.Click += new System.EventHandler(this.btReadAllLine_Click);
            // 
            // btReadLine
            // 
            this.btReadLine.Location = new System.Drawing.Point(340, 12);
            this.btReadLine.Name = "btReadLine";
            this.btReadLine.Size = new System.Drawing.Size(75, 37);
            this.btReadLine.TabIndex = 5;
            this.btReadLine.Text = "ReadLine";
            this.btReadLine.UseVisualStyleBackColor = true;
            this.btReadLine.Click += new System.EventHandler(this.btReadLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 538);
            this.Controls.Add(this.btReadLine);
            this.Controls.Add(this.btReadAllLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutPut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReadAllLine;
        private System.Windows.Forms.Button btReadLine;
    }
}

