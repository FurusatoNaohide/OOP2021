
namespace Prototype
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202107DataSet = new Prototype.infosys202107DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCostTotal = new System.Windows.Forms.Label();
            this.manageTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ManageTableAdapter();
            this.tableAdapterManager = new Prototype.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.clubTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ClubTableAdapter();
            this.costTableAdapter = new Prototype.infosys202107DataSetTableAdapters.CostTableAdapter();
            this.presentersTableAdapter = new Prototype.infosys202107DataSetTableAdapters.PresentersTableAdapter();
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbYearOrMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(247, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "部費報告書";
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(123, 70);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(121, 20);
            this.cbClub.TabIndex = 1;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(232, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "合計金額";
            // 
            // manageDataGridView
            // 
            this.manageDataGridView.AllowUserToAddRows = false;
            this.manageDataGridView.AutoGenerateColumns = false;
            this.manageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.manageDataGridView.DataSource = this.manageBindingSource;
            this.manageDataGridView.Location = new System.Drawing.Point(22, 99);
            this.manageDataGridView.MultiSelect = false;
            this.manageDataGridView.Name = "manageDataGridView";
            this.manageDataGridView.RowTemplate.Height = 21;
            this.manageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manageDataGridView.Size = new System.Drawing.Size(444, 537);
            this.manageDataGridView.TabIndex = 5;
            this.manageDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.manageDataGridView_DataError);
            this.manageDataGridView.SelectionChanged += new System.EventHandler(this.manageDataGridView_SelectionChanged);
            this.manageDataGridView.DoubleClick += new System.EventHandler(this.manageDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "PDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UsedDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "UsedDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost_Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn6.HeaderText = "Money";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Summary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Summary";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Receipt";
            this.dataGridViewImageColumn1.HeaderText = "Receipt";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Confirmation";
            this.dataGridViewTextBoxColumn8.HeaderText = "Confirmation";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Club_Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Club_Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // manageBindingSource
            // 
            this.manageBindingSource.DataMember = "Manage";
            this.manageBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // infosys202107DataSet
            // 
            this.infosys202107DataSet.DataSetName = "infosys202107DataSet";
            this.infosys202107DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "部活動名：";
            // 
            // lbCostTotal
            // 
            this.lbCostTotal.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCostTotal.Location = new System.Drawing.Point(303, 649);
            this.lbCostTotal.Name = "lbCostTotal";
            this.lbCostTotal.Size = new System.Drawing.Size(163, 23);
            this.lbCostTotal.TabIndex = 7;
            this.lbCostTotal.Text = "\\";
            this.lbCostTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // manageTableAdapter
            // 
            this.manageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CostTableAdapter = this.costTableAdapter;
            this.tableAdapterManager.ManageTableAdapter = this.manageTableAdapter;
            this.tableAdapterManager.PresentersTableAdapter = this.presentersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prototype.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // costTableAdapter
            // 
            this.costTableAdapter.ClearBeforeFill = true;
            // 
            // presentersTableAdapter
            // 
            this.presentersTableAdapter.ClearBeforeFill = true;
            // 
            // costBindingSource
            // 
            this.costBindingSource.DataMember = "Cost";
            this.costBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // presentersBindingSource
            // 
            this.presentersBindingSource.DataMember = "Presenters";
            this.presentersBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // lbYearOrMonth
            // 
            this.lbYearOrMonth.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbYearOrMonth.Location = new System.Drawing.Point(66, 23);
            this.lbYearOrMonth.Name = "lbYearOrMonth";
            this.lbYearOrMonth.Size = new System.Drawing.Size(175, 26);
            this.lbYearOrMonth.TabIndex = 8;
            this.lbYearOrMonth.Text = "＿＿年度";
            this.lbYearOrMonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 681);
            this.Controls.Add(this.lbYearOrMonth);
            this.Controls.Add(this.lbCostTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.manageDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "部費管理システム";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Label label2;
        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource manageBindingSource;
        private infosys202107DataSetTableAdapters.ManageTableAdapter manageTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private infosys202107DataSetTableAdapters.CostTableAdapter costTableAdapter;
        private System.Windows.Forms.DataGridView manageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource costBindingSource;
        private infosys202107DataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private infosys202107DataSetTableAdapters.PresentersTableAdapter presentersTableAdapter;
        private System.Windows.Forms.BindingSource presentersBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCostTotal;
        private System.Windows.Forms.Label lbYearOrMonth;
    }
}