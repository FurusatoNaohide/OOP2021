
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
            this.btCostNameRegister = new System.Windows.Forms.Button();
            this.btPresenterRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "部費管理システム　管理用";
            // 
            // btManage
            // 
            this.btManage.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btManage.Location = new System.Drawing.Point(346, 217);
            this.btManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(216, 84);
            this.btManage.TabIndex = 2;
            this.btManage.Text = "決算管理";
            this.btManage.UseVisualStyleBackColor = true;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btClubRegister
            // 
            this.btClubRegister.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClubRegister.Location = new System.Drawing.Point(56, 92);
            this.btClubRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClubRegister.Name = "btClubRegister";
            this.btClubRegister.Size = new System.Drawing.Size(216, 84);
            this.btClubRegister.TabIndex = 3;
            this.btClubRegister.Text = "部活動登録";
            this.btClubRegister.UseVisualStyleBackColor = true;
            this.btClubRegister.Click += new System.EventHandler(this.btClubRegister_Click);
            // 
            // btCostNameRegister
            // 
            this.btCostNameRegister.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCostNameRegister.Location = new System.Drawing.Point(56, 217);
            this.btCostNameRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCostNameRegister.Name = "btCostNameRegister";
            this.btCostNameRegister.Size = new System.Drawing.Size(216, 84);
            this.btCostNameRegister.TabIndex = 4;
            this.btCostNameRegister.Text = "費用名登録";
            this.btCostNameRegister.UseVisualStyleBackColor = true;
            this.btCostNameRegister.Click += new System.EventHandler(this.btCostNameRegister_Click);
            // 
            // btPresenterRegister
            // 
            this.btPresenterRegister.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPresenterRegister.Location = new System.Drawing.Point(346, 92);
            this.btPresenterRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPresenterRegister.Name = "btPresenterRegister";
            this.btPresenterRegister.Size = new System.Drawing.Size(216, 84);
            this.btPresenterRegister.TabIndex = 5;
            this.btPresenterRegister.Text = "提出者登録";
            this.btPresenterRegister.UseVisualStyleBackColor = true;
            this.btPresenterRegister.Click += new System.EventHandler(this.btPresenterRegister_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 330);
            this.Controls.Add(this.btPresenterRegister);
            this.Controls.Add(this.btCostNameRegister);
            this.Controls.Add(this.btClubRegister);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Button btClubRegister;
        private System.Windows.Forms.Button btCostNameRegister;
        private System.Windows.Forms.Button btPresenterRegister;
    }
}