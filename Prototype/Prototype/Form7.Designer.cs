
namespace Prototype
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClubName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClubID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.infosys202107DataSet = new Prototype.infosys202107DataSet();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubTableAdapter = new Prototype.infosys202107DataSetTableAdapters.ClubTableAdapter();
            this.tableAdapterManager = new Prototype.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.clubBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clubBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clubDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.sampleManageDataSet1 = new Prototype.SampleManageDataSet1();
            this.clubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubsTableAdapter = new Prototype.SampleManageDataSet1TableAdapters.ClubsTableAdapter();
            this.tableAdapterManager1 = new Prototype.SampleManageDataSet1TableAdapters.TableAdapterManager();
            this.clubsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingNavigator)).BeginInit();
            this.clubBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "部活動登録画面";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "部活動名：";
            // 
            // tbClubName
            // 
            this.tbClubName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbClubName.Location = new System.Drawing.Point(196, 129);
            this.tbClubName.Margin = new System.Windows.Forms.Padding(4);
            this.tbClubName.Name = "tbClubName";
            this.tbClubName.Size = new System.Drawing.Size(277, 37);
            this.tbClubName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(64, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "部活ID：";
            // 
            // tbClubID
            // 
            this.tbClubID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbClubID.Location = new System.Drawing.Point(196, 208);
            this.tbClubID.Margin = new System.Windows.Forms.Padding(4);
            this.tbClubID.Name = "tbClubID";
            this.tbClubID.Size = new System.Drawing.Size(277, 37);
            this.tbClubID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "パスワード：";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPassWord.Location = new System.Drawing.Point(196, 294);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '＊';
            this.tbPassWord.Size = new System.Drawing.Size(277, 37);
            this.tbPassWord.TabIndex = 9;
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegister.Location = new System.Drawing.Point(361, 555);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(125, 41);
            this.btRegister.TabIndex = 10;
            this.btRegister.Text = "登録";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(361, 619);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 41);
            this.btCancel.TabIndex = 11;
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
            // clubBindingNavigator
            // 
            this.clubBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clubBindingNavigator.BindingSource = this.clubBindingSource;
            this.clubBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clubBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clubBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clubBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clubBindingNavigatorSaveItem});
            this.clubBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clubBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clubBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clubBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clubBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clubBindingNavigator.Name = "clubBindingNavigator";
            this.clubBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clubBindingNavigator.Size = new System.Drawing.Size(560, 27);
            this.clubBindingNavigator.TabIndex = 12;
            this.clubBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // clubBindingNavigatorSaveItem
            // 
            this.clubBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clubBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clubBindingNavigatorSaveItem.Image")));
            this.clubBindingNavigatorSaveItem.Name = "clubBindingNavigatorSaveItem";
            this.clubBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.clubBindingNavigatorSaveItem.Text = "データの保存";
            this.clubBindingNavigatorSaveItem.Click += new System.EventHandler(this.clubBindingNavigatorSaveItem_Click);
            // 
            // clubDataGridView
            // 
            this.clubDataGridView.AutoGenerateColumns = false;
            this.clubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clubDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.clubDataGridView.DataSource = this.clubBindingSource;
            this.clubDataGridView.Location = new System.Drawing.Point(31, 402);
            this.clubDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clubDataGridView.Name = "clubDataGridView";
            this.clubDataGridView.RowHeadersWidth = 51;
            this.clubDataGridView.RowTemplate.Height = 21;
            this.clubDataGridView.Size = new System.Drawing.Size(323, 258);
            this.clubDataGridView.TabIndex = 12;
            this.clubDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clubDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Club_No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Club_No";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(24, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "登録一覧：";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(361, 402);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(125, 41);
            this.btConnect.TabIndex = 14;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
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
            // clubsDataGridView
            // 
            this.clubsDataGridView.AutoGenerateColumns = false;
            this.clubsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clubsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clubsDataGridView.DataSource = this.clubsBindingSource;
            this.clubsDataGridView.Location = new System.Drawing.Point(31, 402);
            this.clubsDataGridView.Name = "clubsDataGridView";
            this.clubsDataGridView.RowHeadersWidth = 51;
            this.clubsDataGridView.RowTemplate.Height = 24;
            this.clubsDataGridView.Size = new System.Drawing.Size(323, 258);
            this.clubsDataGridView.TabIndex = 14;
            this.clubsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clubsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn5.HeaderText = "No";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Club_Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Club_Id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn8.HeaderText = "Password";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(361, 462);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 41);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 694);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.clubsDataGridView);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clubDataGridView);
            this.Controls.Add(this.clubBindingNavigator);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbClubID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingNavigator)).EndInit();
            this.clubBindingNavigator.ResumeLayout(false);
            this.clubBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClubName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbClubID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btCancel;
        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private infosys202107DataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clubBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clubBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clubDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConnect;
        private SampleManageDataSet1 sampleManageDataSet1;
        private System.Windows.Forms.BindingSource clubsBindingSource;
        private SampleManageDataSet1TableAdapters.ClubsTableAdapter clubsTableAdapter;
        private SampleManageDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView clubsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btAdd;
    }
}