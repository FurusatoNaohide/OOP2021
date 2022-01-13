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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void presentersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.presentersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            presentersDataGridView.Columns[0].Visible = false;
            presentersDataGridView.Columns[1].HeaderText = "提出者名";

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);
            this.btAdd_Click(sender,e);
        }

        //Presenterテーブルに新規追加
        private void btAdd_Click(object sender, EventArgs e)
        {
            this.presentersBindingSource.AddNew();
            this.presentersDataGridView.DataSource = this.presentersBindingSource;
        }

        //データベース　Presenterテーブルに登録
        private void btRegister_Click(object sender, EventArgs e)
        {
            presentersDataGridView.CurrentRow.Cells[1].Value = tbPresenterName.Text;

            this.Validate();
            this.presentersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

            tbPresenterName.Text = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
