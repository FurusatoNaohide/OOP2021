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
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
        }

        //データベース　Clubテーブルに登録
        private void btRegister_Click(object sender, EventArgs e)
        {
            clubDataGridView.CurrentRow.Cells[1].Value = tbClubID.Text;
            clubDataGridView.CurrentRow.Cells[2].Value = tbClubName.Text;
            clubDataGridView.CurrentRow.Cells[3].Value = tbPassWord.Text;

            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            clubDataGridView.Columns[0].Visible = false;
            clubDataGridView.Columns[1].HeaderText = "部活ID";
            clubDataGridView.Columns[2].HeaderText = "部活動名";
            clubDataGridView.Columns[3].Visible = false;
        }

        private void clubDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
