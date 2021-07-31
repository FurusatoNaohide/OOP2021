
namespace Exercise4 {
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
            this.fbdFindFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btChoiseDirectory = new System.Windows.Forms.Button();
            this.btCopyDirectory = new System.Windows.Forms.Button();
            this.btCopyFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChoiseDirectory
            // 
            this.btChoiseDirectory.Location = new System.Drawing.Point(16, 15);
            this.btChoiseDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btChoiseDirectory.Name = "btChoiseDirectory";
            this.btChoiseDirectory.Size = new System.Drawing.Size(128, 39);
            this.btChoiseDirectory.TabIndex = 0;
            this.btChoiseDirectory.Text = "指定ディレクトリ";
            this.btChoiseDirectory.UseVisualStyleBackColor = true;
            this.btChoiseDirectory.Click += new System.EventHandler(this.btChoiseDirectory_Click);
            // 
            // btCopyDirectory
            // 
            this.btCopyDirectory.Location = new System.Drawing.Point(16, 62);
            this.btCopyDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btCopyDirectory.Name = "btCopyDirectory";
            this.btCopyDirectory.Size = new System.Drawing.Size(128, 39);
            this.btCopyDirectory.TabIndex = 1;
            this.btCopyDirectory.Text = "複製先ディレクトリ";
            this.btCopyDirectory.UseVisualStyleBackColor = true;
            this.btCopyDirectory.Click += new System.EventHandler(this.btCopyDirectory_Click);
            // 
            // btCopyFile
            // 
            this.btCopyFile.Location = new System.Drawing.Point(16, 109);
            this.btCopyFile.Margin = new System.Windows.Forms.Padding(4);
            this.btCopyFile.Name = "btCopyFile";
            this.btCopyFile.Size = new System.Drawing.Size(128, 39);
            this.btCopyFile.TabIndex = 2;
            this.btCopyFile.Text = "コピー";
            this.btCopyFile.UseVisualStyleBackColor = true;
            this.btCopyFile.Click += new System.EventHandler(this.btCopyFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 151);
            this.Controls.Add(this.btCopyFile);
            this.Controls.Add(this.btCopyDirectory);
            this.Controls.Add(this.btChoiseDirectory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdFindFolder;
        private System.Windows.Forms.Button btChoiseDirectory;
        private System.Windows.Forms.Button btCopyDirectory;
        private System.Windows.Forms.Button btCopyFile;
    }
}

