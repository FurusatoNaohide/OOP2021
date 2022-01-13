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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
#if true//学校サーバー
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            this.btAdd_Click(sender,e);
#endif
#if false //自宅用
            // TODO: このコード行はデータを 'sampleManageDataSet1.Clubs' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubsTableAdapter.Fill(this.sampleManageDataSet1.Clubs);
#endif
        }

        //データベース　Clubテーブルに登録
        private void btRegister_Click(object sender, EventArgs e)
        {
#if true //学校サーバー
            clubDataGridView.CurrentRow.Cells[1].Value = tbClubID.Text;
            clubDataGridView.CurrentRow.Cells[2].Value = tbClubName.Text;
            clubDataGridView.CurrentRow.Cells[3].Value = tbPassWord.Text;

            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
#endif
#if false //自宅用
            clubsDataGridView.CurrentRow.Cells[1].Value = tbClubID.Text;
            clubsDataGridView.CurrentRow.Cells[2].Value = tbClubName.Text;
            clubsDataGridView.CurrentRow.Cells[3].Value = tbPassWord.Text;

            this.Validate();
            this.clubsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sampleManageDataSet1);

#endif

            tbClubID.Text = null;
            tbClubName.Text = null;
            tbPassWord.Text = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void clubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
#if true //学校サーバー
           // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);

            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
#endif
#if false //自宅用
            this.Validate();
            this.clubsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sampleManageDataSet1);
#endif
        }

        private void Form7_Load(object sender, EventArgs e)
        {
#if true //学校サーバー
            clubDataGridView.Columns[0].Visible = false;
            clubDataGridView.Columns[1].HeaderText = "部活ID";
            clubDataGridView.Columns[2].HeaderText = "部活動名";
            clubDataGridView.Columns[3].Visible = false;
#endif
#if false //自宅用
            // TODO: このコード行はデータを 'sampleManageDataSet1.Clubs' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubsTableAdapter.Fill(this.sampleManageDataSet1.Clubs);

            clubsDataGridView.Columns[0].Visible = false;
            clubsDataGridView.Columns[1].HeaderText = "部活ID";
            clubsDataGridView.Columns[2].HeaderText = "部活動名";
            clubsDataGridView.Columns[3].Visible = false;
#endif
        }

        private void clubDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clubsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //部活動テーブルに新規追加
        private void btAdd_Click(object sender, EventArgs e)
        {
#if true //学校サーバー
            this.clubBindingSource.AddNew();
            this.clubDataGridView.DataSource = this.clubBindingSource;
#endif
#if false //自宅用
            this.clubsBindingSource.AddNew();
            this.clubsDataGridView.DataSource = this.clubsBindingSource;
#endif
        }

        //新規追加
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        //削除
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
