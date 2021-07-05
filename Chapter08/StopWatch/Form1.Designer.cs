
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.btLup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(53, 109);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(115, 55);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(53, 170);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(115, 57);
            this.btstop.TabIndex = 2;
            this.btstop.Text = "ストップ";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(200, 109);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(115, 55);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(51, 43);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(264, 46);
            this.lbTimerDisp.TabIndex = 4;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(339, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 184);
            this.listBox1.TabIndex = 5;
            // 
            // btLup
            // 
            this.btLup.Location = new System.Drawing.Point(200, 172);
            this.btLup.Name = "btLup";
            this.btLup.Size = new System.Drawing.Size(115, 55);
            this.btLup.TabIndex = 6;
            this.btLup.Text = "ラップ→";
            this.btLup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 268);
            this.Controls.Add(this.btLup);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btstop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer tmDisp;
        private System.Windows.Forms.Button btLup;
    }
}

