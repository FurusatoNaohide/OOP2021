
namespace CarReportSystem {
    partial class fmMain {
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRegistData = new System.Windows.Forms.DataGridView();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btDataAdd = new System.Windows.Forms.Button();
            this.btDataCorrect = new System.Windows.Forms.Button();
            this.btDataDelete = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(79, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 23);
            this.dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(79, 57);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(190, 20);
            this.cbAuthor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "記録者：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.Control;
            this.pbPicture.Location = new System.Drawing.Point(478, 57);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(260, 223);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(81, 149);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(188, 20);
            this.cbCarName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "車名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "メーカー：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbImport);
            this.groupBox1.Controls.Add(this.rbSubaru);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Controls.Add(this.rbNissan);
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Location = new System.Drawing.Point(81, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(280, 18);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 5;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(227, 18);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(47, 16);
            this.rbImport.TabIndex = 4;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "外車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(169, 18);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 18);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 2;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(59, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 1;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "レポート：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(79, 189);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(377, 124);
            this.tbReport.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(6, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "記事一覧：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(475, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "画像";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRegistData
            // 
            this.dgvRegistData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistData.Location = new System.Drawing.Point(79, 329);
            this.dgvRegistData.Name = "dgvRegistData";
            this.dgvRegistData.RowTemplate.Height = 21;
            this.dgvRegistData.Size = new System.Drawing.Size(659, 196);
            this.dgvRegistData.TabIndex = 13;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(521, 21);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(97, 27);
            this.btPictureOpen.TabIndex = 14;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(641, 21);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(97, 27);
            this.btPictureDelete.TabIndex = 15;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            // 
            // btDataAdd
            // 
            this.btDataAdd.Location = new System.Drawing.Point(495, 286);
            this.btDataAdd.Name = "btDataAdd";
            this.btDataAdd.Size = new System.Drawing.Size(77, 27);
            this.btDataAdd.TabIndex = 16;
            this.btDataAdd.Text = "追加";
            this.btDataAdd.UseVisualStyleBackColor = true;
            // 
            // btDataCorrect
            // 
            this.btDataCorrect.Location = new System.Drawing.Point(578, 286);
            this.btDataCorrect.Name = "btDataCorrect";
            this.btDataCorrect.Size = new System.Drawing.Size(77, 27);
            this.btDataCorrect.TabIndex = 17;
            this.btDataCorrect.Text = "修正";
            this.btDataCorrect.UseVisualStyleBackColor = true;
            // 
            // btDataDelete
            // 
            this.btDataDelete.Location = new System.Drawing.Point(661, 286);
            this.btDataDelete.Name = "btDataDelete";
            this.btDataDelete.Size = new System.Drawing.Size(77, 27);
            this.btDataDelete.TabIndex = 18;
            this.btDataDelete.Text = "削除";
            this.btDataDelete.UseVisualStyleBackColor = true;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(8, 356);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(65, 27);
            this.btOpen.TabIndex = 19;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(8, 389);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 27);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "保存...";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(8, 498);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(65, 27);
            this.btExit.TabIndex = 21;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 545);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btDataDelete);
            this.Controls.Add(this.btDataCorrect);
            this.Controls.Add(this.btDataAdd);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.dgvRegistData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRegistData;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btDataAdd;
        private System.Windows.Forms.Button btDataCorrect;
        private System.Windows.Forms.Button btDataDelete;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
    }
}

