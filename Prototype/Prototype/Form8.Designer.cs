
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
            this.components = new System.ComponentModel.Container();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.rbApril = new System.Windows.Forms.RadioButton();
            this.rbFebruary = new System.Windows.Forms.RadioButton();
            this.rbMarch = new System.Windows.Forms.RadioButton();
            this.rbMay = new System.Windows.Forms.RadioButton();
            this.rbJanuary = new System.Windows.Forms.RadioButton();
            this.rbJune = new System.Windows.Forms.RadioButton();
            this.rbAugust = new System.Windows.Forms.RadioButton();
            this.rbJuly = new System.Windows.Forms.RadioButton();
            this.rbNovember = new System.Windows.Forms.RadioButton();
            this.rbOctober = new System.Windows.Forms.RadioButton();
            this.rbSeptember = new System.Windows.Forms.RadioButton();
            this.rbDecember = new System.Windows.Forms.RadioButton();
            this.gbRange = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.infosys202107DataSet = new Prototype.infosys202107DataSet();
            this.manageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ManageTableAdapter();
            this.tableAdapterManager = new Prototype.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.gbMonth.SuspendLayout();
            this.gbRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.rbApril);
            this.gbMonth.Controls.Add(this.rbFebruary);
            this.gbMonth.Controls.Add(this.rbMarch);
            this.gbMonth.Controls.Add(this.rbMay);
            this.gbMonth.Controls.Add(this.rbJanuary);
            this.gbMonth.Controls.Add(this.rbJune);
            this.gbMonth.Controls.Add(this.rbAugust);
            this.gbMonth.Controls.Add(this.rbJuly);
            this.gbMonth.Controls.Add(this.rbNovember);
            this.gbMonth.Controls.Add(this.rbOctober);
            this.gbMonth.Controls.Add(this.rbSeptember);
            this.gbMonth.Controls.Add(this.rbDecember);
            this.gbMonth.Location = new System.Drawing.Point(12, 38);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(166, 112);
            this.gbMonth.TabIndex = 0;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "月決算";
            // 
            // rbApril
            // 
            this.rbApril.AutoSize = true;
            this.rbApril.Checked = true;
            this.rbApril.Location = new System.Drawing.Point(12, 25);
            this.rbApril.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbApril.Name = "rbApril";
            this.rbApril.Size = new System.Drawing.Size(41, 16);
            this.rbApril.TabIndex = 3;
            this.rbApril.TabStop = true;
            this.rbApril.Tag = "3";
            this.rbApril.Text = "4月";
            this.rbApril.UseVisualStyleBackColor = true;
            // 
            // rbFebruary
            // 
            this.rbFebruary.AutoSize = true;
            this.rbFebruary.Location = new System.Drawing.Point(60, 81);
            this.rbFebruary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFebruary.Name = "rbFebruary";
            this.rbFebruary.Size = new System.Drawing.Size(41, 16);
            this.rbFebruary.TabIndex = 1;
            this.rbFebruary.Tag = "1";
            this.rbFebruary.Text = "2月";
            this.rbFebruary.UseVisualStyleBackColor = true;
            // 
            // rbMarch
            // 
            this.rbMarch.AutoSize = true;
            this.rbMarch.Location = new System.Drawing.Point(110, 81);
            this.rbMarch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMarch.Name = "rbMarch";
            this.rbMarch.Size = new System.Drawing.Size(41, 16);
            this.rbMarch.TabIndex = 2;
            this.rbMarch.Tag = "2";
            this.rbMarch.Text = "3月";
            this.rbMarch.UseVisualStyleBackColor = true;
            // 
            // rbMay
            // 
            this.rbMay.AutoSize = true;
            this.rbMay.Location = new System.Drawing.Point(60, 25);
            this.rbMay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMay.Name = "rbMay";
            this.rbMay.Size = new System.Drawing.Size(41, 16);
            this.rbMay.TabIndex = 4;
            this.rbMay.Tag = "4";
            this.rbMay.Text = "5月";
            this.rbMay.UseVisualStyleBackColor = true;
            // 
            // rbJanuary
            // 
            this.rbJanuary.AutoSize = true;
            this.rbJanuary.Location = new System.Drawing.Point(12, 81);
            this.rbJanuary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJanuary.Name = "rbJanuary";
            this.rbJanuary.Size = new System.Drawing.Size(41, 16);
            this.rbJanuary.TabIndex = 0;
            this.rbJanuary.Tag = "0";
            this.rbJanuary.Text = "1月";
            this.rbJanuary.UseVisualStyleBackColor = true;
            // 
            // rbJune
            // 
            this.rbJune.AutoSize = true;
            this.rbJune.Location = new System.Drawing.Point(110, 26);
            this.rbJune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJune.Name = "rbJune";
            this.rbJune.Size = new System.Drawing.Size(41, 16);
            this.rbJune.TabIndex = 5;
            this.rbJune.Tag = "5";
            this.rbJune.Text = "6月";
            this.rbJune.UseVisualStyleBackColor = true;
            // 
            // rbAugust
            // 
            this.rbAugust.AutoSize = true;
            this.rbAugust.Location = new System.Drawing.Point(60, 44);
            this.rbAugust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAugust.Name = "rbAugust";
            this.rbAugust.Size = new System.Drawing.Size(41, 16);
            this.rbAugust.TabIndex = 7;
            this.rbAugust.Tag = "7";
            this.rbAugust.Text = "8月";
            this.rbAugust.UseVisualStyleBackColor = true;
            // 
            // rbJuly
            // 
            this.rbJuly.AutoSize = true;
            this.rbJuly.Location = new System.Drawing.Point(12, 44);
            this.rbJuly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJuly.Name = "rbJuly";
            this.rbJuly.Size = new System.Drawing.Size(41, 16);
            this.rbJuly.TabIndex = 6;
            this.rbJuly.Tag = "6";
            this.rbJuly.Text = "7月";
            this.rbJuly.UseVisualStyleBackColor = true;
            // 
            // rbNovember
            // 
            this.rbNovember.AutoSize = true;
            this.rbNovember.Location = new System.Drawing.Point(60, 62);
            this.rbNovember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNovember.Name = "rbNovember";
            this.rbNovember.Size = new System.Drawing.Size(47, 16);
            this.rbNovember.TabIndex = 10;
            this.rbNovember.Tag = "10";
            this.rbNovember.Text = "11月";
            this.rbNovember.UseVisualStyleBackColor = true;
            // 
            // rbOctober
            // 
            this.rbOctober.AutoSize = true;
            this.rbOctober.Location = new System.Drawing.Point(12, 62);
            this.rbOctober.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOctober.Name = "rbOctober";
            this.rbOctober.Size = new System.Drawing.Size(47, 16);
            this.rbOctober.TabIndex = 9;
            this.rbOctober.Tag = "9";
            this.rbOctober.Text = "10月";
            this.rbOctober.UseVisualStyleBackColor = true;
            // 
            // rbSeptember
            // 
            this.rbSeptember.AutoSize = true;
            this.rbSeptember.Location = new System.Drawing.Point(110, 44);
            this.rbSeptember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSeptember.Name = "rbSeptember";
            this.rbSeptember.Size = new System.Drawing.Size(41, 16);
            this.rbSeptember.TabIndex = 8;
            this.rbSeptember.Tag = "8";
            this.rbSeptember.Text = "9月";
            this.rbSeptember.UseVisualStyleBackColor = true;
            // 
            // rbDecember
            // 
            this.rbDecember.AutoSize = true;
            this.rbDecember.Location = new System.Drawing.Point(110, 62);
            this.rbDecember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDecember.Name = "rbDecember";
            this.rbDecember.Size = new System.Drawing.Size(47, 16);
            this.rbDecember.TabIndex = 11;
            this.rbDecember.Tag = "11";
            this.rbDecember.Text = "12月";
            this.rbDecember.UseVisualStyleBackColor = true;
            // 
            // gbRange
            // 
            this.gbRange.Controls.Add(this.label1);
            this.gbRange.Controls.Add(this.cbYear);
            this.gbRange.Controls.Add(this.rbYear);
            this.gbRange.Controls.Add(this.rbMonth);
            this.gbRange.Controls.Add(this.gbMonth);
            this.gbRange.Location = new System.Drawing.Point(15, 14);
            this.gbRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRange.Name = "gbRange";
            this.gbRange.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRange.Size = new System.Drawing.Size(194, 219);
            this.gbRange.TabIndex = 2;
            this.gbRange.TabStop = false;
            this.gbRange.Text = "範囲選択";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "年度決算";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(49, 175);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(92, 20);
            this.cbYear.TabIndex = 0;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(60, 17);
            this.rbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(59, 16);
            this.rbYear.TabIndex = 1;
            this.rbYear.Tag = "1";
            this.rbYear.Text = "年度別";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Checked = true;
            this.rbMonth.Location = new System.Drawing.Point(12, 17);
            this.rbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(47, 16);
            this.rbMonth.TabIndex = 0;
            this.rbMonth.TabStop = true;
            this.rbMonth.Tag = "0";
            this.rbMonth.Text = "月別";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOk.Location = new System.Drawing.Point(55, 237);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(56, 32);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(115, 238);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 32);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // infosys202107DataSet
            // 
            this.infosys202107DataSet.DataSetName = "infosys202107DataSet";
            this.infosys202107DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageBindingSource
            // 
            this.manageBindingSource.DataMember = "Manage";
            this.manageBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // manageTableAdapter
            // 
            this.manageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CostTableAdapter = null;
            this.tableAdapterManager.ManageTableAdapter = this.manageTableAdapter;
            this.tableAdapterManager.PresentersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prototype.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 281);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.gbRange);
            this.Name = "Form8";
            this.Text = "範囲指定";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.gbRange.ResumeLayout(false);
            this.gbRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.GroupBox gbRange;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RadioButton rbFebruary;
        private System.Windows.Forms.RadioButton rbMarch;
        private System.Windows.Forms.RadioButton rbApril;
        private System.Windows.Forms.RadioButton rbMay;
        private System.Windows.Forms.RadioButton rbJune;
        private System.Windows.Forms.RadioButton rbJuly;
        private System.Windows.Forms.RadioButton rbAugust;
        private System.Windows.Forms.RadioButton rbDecember;
        private System.Windows.Forms.RadioButton rbNovember;
        private System.Windows.Forms.RadioButton rbOctober;
        private System.Windows.Forms.RadioButton rbSeptember;
        private System.Windows.Forms.RadioButton rbJanuary;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource manageBindingSource;
        private infosys202107DataSetTableAdapters.ManageTableAdapter manageTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}