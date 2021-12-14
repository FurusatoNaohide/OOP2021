
namespace Prototype
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.lbClubName = new System.Windows.Forms.Label();
            this.cbCostName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpUsedDate = new System.Windows.Forms.DateTimePicker();
            this.cbPresenter = new System.Windows.Forms.ComboBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.pbReceipt = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btReceiptOpen = new System.Windows.Forms.Button();
            this.btReceiptDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.infosys202107DataSet = new Prototype.infosys202107DataSet();
            this.manageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ManageTableAdapter();
            this.tableAdapterManager = new Prototype.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.clubTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ClubTableAdapter();
            this.manageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPresenDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingNavigator)).BeginInit();
            this.manageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HG教科書体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(425, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "部費使用登録画面";
            // 
            // lbClubName
            // 
            this.lbClubName.Font = new System.Drawing.Font("HGS教科書体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbClubName.Location = new System.Drawing.Point(16, 55);
            this.lbClubName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubName.Name = "lbClubName";
            this.lbClubName.Size = new System.Drawing.Size(401, 29);
            this.lbClubName.TabIndex = 1;
            this.lbClubName.Text = "～～部";
            // 
            // cbCostName
            // 
            this.cbCostName.FormattingEnabled = true;
            this.cbCostName.Location = new System.Drawing.Point(163, 244);
            this.cbCostName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCostName.Name = "cbCostName";
            this.cbCostName.Size = new System.Drawing.Size(160, 23);
            this.cbCostName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(45, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "費用名：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(45, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "使用金額：";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(45, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "提出者名：";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(47, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "使用日：";
            // 
            // dtpUsedDate
            // 
            this.dtpUsedDate.Location = new System.Drawing.Point(163, 151);
            this.dtpUsedDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpUsedDate.Name = "dtpUsedDate";
            this.dtpUsedDate.Size = new System.Drawing.Size(160, 22);
            this.dtpUsedDate.TabIndex = 7;
            // 
            // cbPresenter
            // 
            this.cbPresenter.FormattingEnabled = true;
            this.cbPresenter.Location = new System.Drawing.Point(163, 199);
            this.cbPresenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPresenter.Name = "cbPresenter";
            this.cbPresenter.Size = new System.Drawing.Size(160, 23);
            this.cbPresenter.TabIndex = 8;
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(163, 295);
            this.tbMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(160, 22);
            this.tbMoney.TabIndex = 9;
            // 
            // pbReceipt
            // 
            this.pbReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReceipt.Location = new System.Drawing.Point(363, 136);
            this.pbReceipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbReceipt.Name = "pbReceipt";
            this.pbReceipt.Size = new System.Drawing.Size(267, 392);
            this.pbReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReceipt.TabIndex = 10;
            this.pbReceipt.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(359, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "領収書：";
            // 
            // btReceiptOpen
            // 
            this.btReceiptOpen.Location = new System.Drawing.Point(463, 100);
            this.btReceiptOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReceiptOpen.Name = "btReceiptOpen";
            this.btReceiptOpen.Size = new System.Drawing.Size(80, 29);
            this.btReceiptOpen.TabIndex = 12;
            this.btReceiptOpen.Text = "開く...";
            this.btReceiptOpen.UseVisualStyleBackColor = true;
            this.btReceiptOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btReceiptDelete
            // 
            this.btReceiptDelete.Location = new System.Drawing.Point(551, 100);
            this.btReceiptDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReceiptDelete.Name = "btReceiptDelete";
            this.btReceiptDelete.Size = new System.Drawing.Size(80, 29);
            this.btReceiptDelete.TabIndex = 13;
            this.btReceiptDelete.Text = "削除";
            this.btReceiptDelete.UseVisualStyleBackColor = true;
            this.btReceiptDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(47, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "概要：";
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(163, 335);
            this.tbSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(160, 64);
            this.tbSummary.TabIndex = 16;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(36, 428);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(136, 42);
            this.btRegister.TabIndex = 17;
            this.btRegister.Text = "登録";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(196, 428);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(128, 42);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(36, 486);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 42);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(196, 486);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(128, 42);
            this.btCheck.TabIndex = 20;
            this.btCheck.Text = "確認";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
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
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CostTableAdapter = null;
            this.tableAdapterManager.ManageTableAdapter = this.manageTableAdapter;
            this.tableAdapterManager.PresentersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prototype.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // manageBindingNavigator
            // 
            this.manageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manageBindingNavigator.BindingSource = this.manageBindingSource;
            this.manageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manageBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.manageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.manageBindingNavigatorSaveItem});
            this.manageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manageBindingNavigator.Name = "manageBindingNavigator";
            this.manageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manageBindingNavigator.Size = new System.Drawing.Size(664, 27);
            this.manageBindingNavigator.TabIndex = 21;
            this.manageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // manageBindingNavigatorSaveItem
            // 
            this.manageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manageBindingNavigatorSaveItem.Image")));
            this.manageBindingNavigatorSaveItem.Name = "manageBindingNavigatorSaveItem";
            this.manageBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.manageBindingNavigatorSaveItem.Text = "データの保存";
            this.manageBindingNavigatorSaveItem.Click += new System.EventHandler(this.manageBindingNavigatorSaveItem_Click);
            // 
            // manageDataGridView
            // 
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
            this.manageDataGridView.Location = new System.Drawing.Point(36, 549);
            this.manageDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageDataGridView.Name = "manageDataGridView";
            this.manageDataGridView.RowHeadersWidth = 51;
            this.manageDataGridView.RowTemplate.Height = 21;
            this.manageDataGridView.Size = new System.Drawing.Size(595, 265);
            this.manageDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "PDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UsedDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "UsedDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost_Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn6.HeaderText = "Money";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Summary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Summary";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Receipt";
            this.dataGridViewImageColumn1.HeaderText = "Receipt";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Confirmation";
            this.dataGridViewTextBoxColumn8.HeaderText = "Confirmation";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Club_Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Club_Id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HGS教科書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "提出日：";
            // 
            // dtpPresenDate
            // 
            this.dtpPresenDate.Location = new System.Drawing.Point(163, 105);
            this.dtpPresenDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPresenDate.Name = "dtpPresenDate";
            this.dtpPresenDate.Size = new System.Drawing.Size(160, 22);
            this.dtpPresenDate.TabIndex = 23;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 848);
            this.Controls.Add(this.dtpPresenDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manageDataGridView);
            this.Controls.Add(this.manageBindingNavigator);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btReceiptDelete);
            this.Controls.Add(this.btReceiptOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbReceipt);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.cbPresenter);
            this.Controls.Add(this.dtpUsedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCostName);
            this.Controls.Add(this.lbClubName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registration";
            this.Text = "部費管理システム";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingNavigator)).EndInit();
            this.manageBindingNavigator.ResumeLayout(false);
            this.manageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClubName;
        private System.Windows.Forms.ComboBox cbCostName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUsedDate;
        private System.Windows.Forms.ComboBox cbPresenter;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.PictureBox pbReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btReceiptOpen;
        private System.Windows.Forms.Button btReceiptDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource manageBindingSource;
        private infosys202107DataSetTableAdapters.ManageTableAdapter manageTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton manageBindingNavigatorSaveItem;
        private infosys202107DataSetTableAdapters.ClubTableAdapter clubTableAdapter;
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
        private System.Windows.Forms.BindingSource clubBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPresenDate;
    }
}

