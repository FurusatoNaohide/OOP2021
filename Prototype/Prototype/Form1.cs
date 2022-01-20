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
        private int _index;
        public Registration(int clubId,int index)
        {
            InitializeComponent();
            _clubId = clubId;
            _index = index;
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
            Form2 report = new Form2();
            report.ShowDialog();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            
            manageDataGridView.CurrentRow.Cells[1].Value = (DateTime)dtpPresenDate.Value;
            manageDataGridView.CurrentRow.Cells[2].Value = (DateTime)dtpUsedDate.Value;
            //提出者、費用名は外部キーを登録
            manageDataGridView.CurrentRow.Cells[3].Value = Presenter_Refer(cbPresenter.Text);
            manageDataGridView.CurrentRow.Cells[4].Value = Cost_Refer(cbCostName.Text);
            manageDataGridView.CurrentRow.Cells[5].Value = tbMoney.Text;
            manageDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
            manageDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
            manageDataGridView.CurrentRow.Cells[10].Value = _clubId;

            manageBindingNavigatorSaveItem_Click(sender, e);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

#if true //学校サーバー
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Manage' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.manageTableAdapter.Fill(this.infosys202107DataSet.Manage);
            //※予期せぬ動作　ここで「シーケンスに要素が含まれていません」と出てくる。
            this.manageTableAdapter.FillByClub(this.infosys202107DataSet.Manage, _clubId);
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);

            lbClubName.Text = this.infosys202107DataSet.Club[_index].Name;

            #region
            manageDataGridView.Columns[0].Visible = false;      //Id　主キー
            manageDataGridView.Columns[1].HeaderText = "提出日";
            manageDataGridView.Columns[2].Visible = false;      //部費使用日
            manageDataGridView.Columns[3].Visible = false;      //提出者Id　外部キー
            manageDataGridView.Columns[4].Visible = false;      //費用Id　外部キー
            manageDataGridView.Columns[5].HeaderText = "使用金額";
            manageDataGridView.Columns[6].Visible = false;
            manageDataGridView.Columns[7].Visible = false;      //領収書
            manageDataGridView.Columns[8].HeaderText = "確認欄";
            manageDataGridView.Columns[9].HeaderText = "備考欄";//備考
            manageDataGridView.Columns[10].Visible = false;     //部活Id　外部キー
            #endregion

            //Presentersにある提出者リストをComboBoxに登録
            foreach (var item in infosys202107DataSet.Presenters)
            {
                setCbPresenter(item.Name);
            }
            //Costにある費用名リストをComboBoxに登録
            foreach (var item in infosys202107DataSet.Cost)
            {
                setCbCost(item.Name);
            }
#endif
#if false //自宅用
            // TODO: このコード行はデータを 'sampleManageDataSet1.Clubs' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubsTableAdapter.Fill(this.sampleManageDataSet1.Clubs);
            // TODO: このコード行はデータを 'sampleManageDataSet1.Manages' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.managesTableAdapter.Fill(this.sampleManageDataSet1.Manages);
            this.managesTableAdapter.FillByClub(this.sampleManageDataSet1.Manages, _clubId);

            lbClubName.Text = this.sampleManageDataSet1.Clubs[_clubId -1].Name;

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

        //ComboBoxに費用名をセットする
        private void setCbCost(string name)
        {
            if (!cbCostName.Items.Contains(name))
            {
                cbCostName.Items.Add(name);
            }
        }

        //ComboBoxに提出者をセットする
        private void setCbPresenter(string name)
        {
            if (!cbPresenter.Items.Contains(name))
            {
                cbPresenter.Items.Add(name);
            }
        }

        private void manageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
#if true //学校サーバー
            //データベースへ反映
            this.Validate();
            this.manageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
#endif
#if false //自宅用
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sampleManageDataSet1);
#endif
        }

        //更新ボタン
        private void btUpdate_Click(object sender, EventArgs e)
        {
#if true //学校サーバー
            if (manageDataGridView.CurrentRow.Cells == null) return;

            btRegister_Click(sender, e);
#endif
#if false  //自宅用
            if (managesDataGridView.CurrentRow.Cells == null) return;
            managesDataGridView.CurrentRow.Cells[1].Value = dtpPresenDate.Value;
            managesDataGridView.CurrentRow.Cells[2].Value = dtpUsedDate.Value;
            //提出者、費用名は外部キーで参照
            //managesDataGridView.CurrentRow.Cells[3].Value = ;
            //managesDataGridView.CurrentRow.Cells[4].Value = ;
            managesDataGridView.CurrentRow.Cells[5].Value = tbMoney.Text;
            managesDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
            managesDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
            managesDataGridView.CurrentRow.Cells[10].Value = _clubId;

            //データベースへ反映
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sampleManageDataSet1);
#endif
        }

        //削除ボタン
        private void btDelete_Click(object sender, EventArgs e)
        {
            //DataGridViewSelectedRowCollection sRow = manageDataGridView.SelectedRows;
            //for (int i = sRow.Count; i >= 0; i--)
            //{
            //    manageDataGridView.Rows.RemoveAt(sRow[i].Index);
            //}
        }

        //新規ボタン押下　データボックス初期化
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            #region
            dtpPresenDate.Value = DateTime.Today;
            dtpUsedDate.Value = DateTime.Today;
            cbPresenter.Text = null;
            cbCostName.Text = null;
            tbMoney.Text = null;
            tbSummary.Text = null;
            pbReceipt.Image = null;
            #endregion
        }

        

        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }
        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //提出者IDを取り出す、ない場合登録できない
        private int Presenter_Refer(string name)
        {
            #region
            int P_Id = 0;
            try
            {
                var pData = infosys202107DataSet.Presenters.Where(x => x.Name == name).First();
                
                if (pData != null)
                {
                    P_Id = pData.Id;
                }
                else
                {
                    cbPresenter.Text = null;
                    MessageBox.Show("この名前は登録されていません。\r\nもう一度確認するか、登録してください。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return P_Id;
            #endregion
        }

        private int Cost_Refer(string costname)
        {
            #region
            int C_Id = 0;
            try
            {
                var cData = infosys202107DataSet.Cost.Where(x => x.Name == costname).First();
                
                if (cData != null)
                {
                    C_Id = cData.Id;
                }
                else
                {
                    cbCostName.Text = null;
                    MessageBox.Show("この費用名は登録されていません。\r\nもう一度確認するか、登録してください。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return C_Id;
            #endregion
        }

#if true //学校サーバー
        private void manageDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            #region
            if (manageDataGridView.CurrentRow == null) return;
            try
            {
                dtpPresenDate.Value = (DateTime)manageDataGridView.CurrentRow.Cells[1].Value;
                dtpUsedDate.Value = (DateTime)manageDataGridView.CurrentRow.Cells[2].Value;
                //提出者名と費用名は外部キーで持ってくる
                cbPresenter.Text = Presenter_getName(manageDataGridView.CurrentRow.Cells[3].Value.ToString());
                cbCostName.Text = Cost_getName(manageDataGridView.CurrentRow.Cells[4].Value.ToString());
                tbMoney.Text = double.Parse(manageDataGridView.CurrentRow.Cells[5].Value.ToString()).ToString();
                tbSummary.Text = manageDataGridView.CurrentRow.Cells[6].Value.ToString();
                pbReceipt.Image = ByteArrayToImage((byte[])manageDataGridView.CurrentRow.Cells[7].Value);

            }
            catch (InvalidCastException) //変換できなかったときのエラー
            {
                pbReceipt.Image = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private string Presenter_getName(string pId)
        {
            #region
            var pdata = infosys202107DataSet.Presenters.Where(x => x.Id == int.Parse(pId)).First();
            string p_Name = null;
            if (pdata != null)
            {
                p_Name = pdata.Name;
            }
            return p_Name;
            #endregion
        }

        private string Cost_getName(string cId)
        {
            #region
            var cdata = infosys202107DataSet.Cost.Where(x => x.Id == int.Parse(cId)).First();
            string c_Name = null;
            if (cdata != null)
            {
                c_Name = cdata.Name;
            }
            return c_Name;
            #endregion
        }

        //新規追加ボタン
        private void btAdd_Click(object sender, EventArgs e)
        {
            #region
            this.manageBindingSource.AddNew();
            this.manageDataGridView.DataSource = this.manageBindingSource;

            //初期化
            dtpPresenDate.Value = DateTime.Today;
            dtpUsedDate.Value = DateTime.Today;
            cbPresenter.Text = "";
            cbCostName.Text = "";
            tbMoney.Text = "";
            tbSummary.Text = "";
            pbReceipt.Image = null;
            #endregion
        }

        //データグリッドビューエラー対応
        private void manageDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
#endif

#if false //自宅用
        private void managesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (managesDataGridView.CurrentRow == null) return;
            try
            {
                dtpPresenDate.Value = (DateTime)managesDataGridView.CurrentRow.Cells[1].Value;
                dtpUsedDate.Value = (DateTime)managesDataGridView.CurrentRow.Cells[2].Value;
                cbPresenter.Text = managesDataGridView.CurrentRow.Cells[3].Value.ToString();
                cbCostName.Text = managesDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbMoney.Text = managesDataGridView.CurrentRow.Cells[5].Value.ToString();
                tbSummary.Text = managesDataGridView.CurrentRow.Cells[6].Value.ToString();
                pbReceipt.Image = ByteArrayToImage((byte[])managesDataGridView.CurrentRow.Cells[7].Value);

            }
            catch (Exception)
            {

                throw;
            }
        }
#endif
    }
}