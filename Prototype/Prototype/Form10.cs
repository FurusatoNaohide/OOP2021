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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void costBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            costDataGridView.Columns[0].Visible = false;
            costDataGridView.Columns[1].HeaderText = "費用名";

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);
            this.btAdd_Click(sender, e);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.costBindingSource.AddNew();
            this.costDataGridView.DataSource = this.costBindingSource;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            costDataGridView.CurrentRow.Cells[1].Value = tbCostName.Text;

            this.Validate();
            this.costBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

            tbCostName.Text = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
