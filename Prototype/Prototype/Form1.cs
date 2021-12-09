using System;
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
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Manage' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.manageTableAdapter.Fill(this.infosys202107DataSet.Manage);
            this.manageTableAdapter.FillByClub(this.infosys202107DataSet.Manage, _clubId);

            lbClubName.Text = this.infosys202107DataSet.Club[_clubId - 1].Name;

            manageDataGridView.Columns[0].Visible = false;
            manageDataGridView.Columns[1].HeaderText = "提出日";
            manageDataGridView.Columns[2].Visible = false;
            manageDataGridView.Columns[3].Visible = false;
            manageDataGridView.Columns[4].Visible = false;
            manageDataGridView.Columns[5].HeaderText = "使用金額";
            manageDataGridView.Columns[6].HeaderText = "概要";
            manageDataGridView.Columns[7].Visible = false;
            manageDataGridView.Columns[8].HeaderText = "確認欄";
            manageDataGridView.Columns[9].Visible = false;
            manageDataGridView.Columns[10].Visible = false;
        }

        private void manageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
