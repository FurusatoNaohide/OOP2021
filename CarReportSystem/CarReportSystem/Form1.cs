using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }

        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像解除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }   

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Picture = pbPicture.Image,
                Report = tbReport.Text
            };
            
            listCarReport.Add(carReport);   //1レコード追加

            //コンボボックスの履歴登録
            setCbAuther(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            
            
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if(((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuther(string auther) {
            if (!cbAuthor.Items.Contains(auther)) {
                cbAuthor.Items.Add(auther);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);

            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];
                
            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther; 
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            pbPicture.Image = selectedCar.Picture;
            tbReport.Text = selectedCar.Report;

            
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {

                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default:    //その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            //CurrrentRow 選択してるセルのある行を選択
            //listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        //今表示しているデータに更新、指定行に入れる
        private void btDataCorrect_Click(object sender, EventArgs e) {
            /*
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(
                dtpDate.Value, cbAuthor.Text, selectedGroup(), 
                cbCarName.Text, tbReport.Text,pbPicture.Image);
            dgvRegistData.Refresh();    //コントロールの強制再描画
            */
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
                carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
                carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
                carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup().ToString();  //メーカー
                carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
                carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート
            

#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナル形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
#endif
        }

        private void btOpen_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202107DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202107DataSet.CarReport);

#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                //読み込んだデータを各コンボボックスに登録する
                foreach (var item in listCarReport) {
                    setCbAuther(item.Auther);
                    setCbCarName(item.CarName);
                }

                /*//データグリッドビューから取得
                for (int i = 0; i < dgvRegistData.RowCount; i++) {
                    setCbAuther(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                    setCbCarName(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                } 
                */
            }
#endif
        }

        private void fmMain_Load(object sender, EventArgs e) {
            
            //dgvRegistData.Columns[5].Visible = false;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }
    }
}
