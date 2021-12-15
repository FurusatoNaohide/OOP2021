
namespace Prototype
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClubID = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.infosys202107DataSet = new Prototype.infosys202107DataSet();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ClubTableAdapter();
            this.tableAdapterManager = new Prototype.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.sampleManageDataSet1 = new Prototype.SampleManageDataSet1();
            this.clubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubsTableAdapter = new Prototype.SampleManageDataSet1TableAdapters.ClubsTableAdapter();
            this.tableAdapterManager1 = new Prototype.SampleManageDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "部活ID：";
            // 
            // tbClubID
            // 
            this.tbClubID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbClubID.Location = new System.Drawing.Point(165, 36);
            this.tbClubID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClubID.Name = "tbClubID";
            this.tbClubID.Size = new System.Drawing.Size(277, 37);
            this.tbClubID.TabIndex = 1;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPassWord.Location = new System.Drawing.Point(165, 115);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(277, 37);
            this.tbPassWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "パスワード：";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(283, 186);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(84, 30);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(375, 186);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(84, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // infosys202107DataSet
            // 
            this.infosys202107DataSet.DataSetName = "infosys202107DataSet";
            this.infosys202107DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CostTableAdapter = null;
            this.tableAdapterManager.ManageTableAdapter = null;
            this.tableAdapterManager.PresentersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prototype.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sampleManageDataSet1
            // 
            this.sampleManageDataSet1.DataSetName = "SampleManageDataSet1";
            this.sampleManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubsBindingSource
            // 
            this.clubsBindingSource.DataMember = "Clubs";
            this.clubsBindingSource.DataSource = this.sampleManageDataSet1;
            // 
            // clubsTableAdapter
            // 
            this.clubsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClubsTableAdapter = this.clubsTableAdapter;
            this.tableAdapterManager1.CostsTableAdapter = null;
            this.tableAdapterManager1.ManagesTableAdapter = null;
            this.tableAdapterManager1.PresentersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Prototype.SampleManageDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 243);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClubID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "ログイン画面";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClubID;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private infosys202107DataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SampleManageDataSet1 sampleManageDataSet1;
        private System.Windows.Forms.BindingSource clubsBindingSource;
        private SampleManageDataSet1TableAdapters.ClubsTableAdapter clubsTableAdapter;
        private SampleManageDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}