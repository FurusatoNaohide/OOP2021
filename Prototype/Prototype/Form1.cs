﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Registration : Form
    {
        private int _clubId;
        public Registration(int clubId)
        {
            InitializeComponent();
            _clubId = clubId;
        }

        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbReceipt.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像解除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbReceipt.Image = null;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            manageDataGridView.CurrentRow.Cells[1].Value = dtpPresenDate.Value;
            manageDataGridView.CurrentRow.Cells[2].Value = dtpUsedDate.Value;
            //提出者、費用名は外部キーで参照
            //manageDataGridView.CurrentRow.Cells[3].Value = ;
            //manageDataGridView.CurrentRow.Cells[4].Value = ;
            manageDataGridView.CurrentRow.Cells[5].Value = tbMoney.Text;
            manageDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
            manageDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
            manageDataGridView.CurrentRow.Cells[10].Value = _clubId;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

#if false //学校サーバー
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Manage' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.manageTableAdapter.Fill(this.infosys202107DataSet.Manage);
            this.manageTableAdapter.FillByClub(this.infosys202107DataSet.Manage, _clubId);

            lbClubName.Text = this.infosys202107DataSet.Club[_clubId - 1].Name;

            manageDataGridView.Columns[0].Visible = false;      //Id　主キー
            manageDataGridView.Columns[1].HeaderText = "提出日";
            manageDataGridView.Columns[2].Visible = false;      //部費使用日
            manageDataGridView.Columns[3].Visible = false;      //提出者Id　外部キー
            manageDataGridView.Columns[4].Visible = false;      //費用Id　外部キー
            manageDataGridView.Columns[5].HeaderText = "使用金額";
            manageDataGridView.Columns[6].HeaderText = "概要";
            manageDataGridView.Columns[7].Visible = false;      //領収書
            manageDataGridView.Columns[8].HeaderText = "確認欄";
            manageDataGridView.Columns[9].Visible = false;      //備考
            manageDataGridView.Columns[10].Visible = false;     //部活Id　外部キー
#endif
#if true //自宅用
            // TODO: このコード行はデータを 'sampleManageDataSet1.Manages' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.managesTableAdapter.Fill(this.sampleManageDataSet1.Manages);
            this.managesTableAdapter.FillByClub(this.sampleManageDataSet1.Manages, _clubId);

            lbClubName.Text = this.sampleManageDataSet1.Clubs[_clubId - 1].Name;

            managesDataGridView.Columns[0].Visible = false;      //Id　主キー
            managesDataGridView.Columns[1].HeaderText = "提出日";
            managesDataGridView.Columns[2].Visible = false;      //部費使用日
            managesDataGridView.Columns[3].Visible = false;      //提出者Id　外部キー
            managesDataGridView.Columns[4].Visible = false;      //費用Id　外部キー
            managesDataGridView.Columns[5].HeaderText = "使用金額";
            managesDataGridView.Columns[6].HeaderText = "概要";
            managesDataGridView.Columns[7].Visible = false;      //領収書
            managesDataGridView.Columns[8].HeaderText = "確認欄";
            managesDataGridView.Columns[9].Visible = false;      //備考
            managesDataGridView.Columns[10].Visible = false;     //部活Id　外部キー
#endif
        }

        private void manageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        //更新ボタン
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (manageDataGridView.CurrentRow.Cells == null) return;

            manageDataGridView.CurrentRow.Cells[1].Value = dtpPresenDate.Value;
            manageDataGridView.CurrentRow.Cells[2].Value = dtpUsedDate.Value;
            //提出者、費用名は外部キーで参照
            //manageDataGridView.CurrentRow.Cells[3].Value = ;
            //manageDataGridView.CurrentRow.Cells[4].Value = ;
            manageDataGridView.CurrentRow.Cells[5].Value = tbMoney.Text;
            manageDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
            manageDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
            manageDataGridView.CurrentRow.Cells[10].Value = _clubId;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        //新規ボタン押下　データボックス初期化
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpPresenDate.Value = DateTime.Today;
            dtpUsedDate.Value = DateTime.Today;
            cbPresenter.Text = null;
            cbCostName.Text = null;
            tbMoney.Text = null;
            tbSummary.Text = null;
            pbReceipt.Image = null;
        }
    }
}
