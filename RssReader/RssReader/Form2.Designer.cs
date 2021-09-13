
namespace RssReader
{
    partial class Form2
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
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btGoBack = new System.Windows.Forms.Button();
            this.btGoForWard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(1, 28);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1397, 732);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbBrowser_Navigated);
            // 
            // btGoBack
            // 
            this.btGoBack.Location = new System.Drawing.Point(7, 3);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(45, 25);
            this.btGoBack.TabIndex = 1;
            this.btGoBack.Text = "←";
            this.btGoBack.UseVisualStyleBackColor = true;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // btGoForWard
            // 
            this.btGoForWard.Location = new System.Drawing.Point(58, 3);
            this.btGoForWard.Name = "btGoForWard";
            this.btGoForWard.Size = new System.Drawing.Size(49, 24);
            this.btGoForWard.TabIndex = 2;
            this.btGoForWard.Text = "→";
            this.btGoForWard.UseVisualStyleBackColor = true;
            this.btGoForWard.Click += new System.EventHandler(this.btGoForWard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 760);
            this.Controls.Add(this.btGoForWard);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Button btGoForWard;
    }
}