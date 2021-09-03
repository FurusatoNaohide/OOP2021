
namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbDetaul = new System.Windows.Forms.ListBox();
            this.btWeathreView = new System.Windows.Forms.Button();
            this.cbSelectArea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "地域を選択";
            // 
            // lbDetaul
            // 
            this.lbDetaul.FormattingEnabled = true;
            this.lbDetaul.ItemHeight = 15;
            this.lbDetaul.Location = new System.Drawing.Point(69, 111);
            this.lbDetaul.Name = "lbDetaul";
            this.lbDetaul.Size = new System.Drawing.Size(534, 319);
            this.lbDetaul.TabIndex = 1;
            // 
            // btWeathreView
            // 
            this.btWeathreView.Location = new System.Drawing.Point(467, 37);
            this.btWeathreView.Name = "btWeathreView";
            this.btWeathreView.Size = new System.Drawing.Size(135, 40);
            this.btWeathreView.TabIndex = 2;
            this.btWeathreView.Text = "天気表示";
            this.btWeathreView.UseVisualStyleBackColor = true;
            this.btWeathreView.Click += new System.EventHandler(this.btWeathreView_Click);
            // 
            // cbSelectArea
            // 
            this.cbSelectArea.FormattingEnabled = true;
            this.cbSelectArea.Items.AddRange(new object[] {
            "前橋",
            "みなかみ",
            "宇都宮",
            "大田原",
            "水戸"});
            this.cbSelectArea.Location = new System.Drawing.Point(164, 47);
            this.cbSelectArea.Name = "cbSelectArea";
            this.cbSelectArea.Size = new System.Drawing.Size(235, 23);
            this.cbSelectArea.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSelectArea);
            this.Controls.Add(this.btWeathreView);
            this.Controls.Add(this.lbDetaul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDetaul;
        private System.Windows.Forms.Button btWeathreView;
        private System.Windows.Forms.ComboBox cbSelectArea;
    }
}

