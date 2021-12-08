
namespace Prototype
{
    partial class Form6
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
            this.btManage = new System.Windows.Forms.Button();
            this.btClubRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "部費管理システム　管理用";
            // 
            // btManage
            // 
            this.btManage.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btManage.Location = new System.Drawing.Point(98, 175);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(225, 67);
            this.btManage.TabIndex = 2;
            this.btManage.Text = "決算管理";
            this.btManage.UseVisualStyleBackColor = true;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btClubRegister
            // 
            this.btClubRegister.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClubRegister.Location = new System.Drawing.Point(98, 87);
            this.btClubRegister.Name = "btClubRegister";
            this.btClubRegister.Size = new System.Drawing.Size(225, 67);
            this.btClubRegister.TabIndex = 3;
            this.btClubRegister.Text = "部活動登録";
            this.btClubRegister.UseVisualStyleBackColor = true;
            this.btClubRegister.Click += new System.EventHandler(this.btClubRegister_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 264);
            this.Controls.Add(this.btClubRegister);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Button btClubRegister;
    }
}