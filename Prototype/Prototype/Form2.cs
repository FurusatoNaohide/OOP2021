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
    public partial class Form2 : Form
    {
        private string _year;
        private int _month;

        private DateTime _PresentedDate;
        private DateTime _UsedDate;
        private string _Presenter;
        private string _CostName;
        private int _Money;
        private string _Summary;
        private Image _Recipt;

        //まずは範囲情報で全部活該当データを抽出
        public Form2()
        {
            InitializeComponent();
        }
        //年度別の時はmonthは0にして月年度で分ける
        public Form2(string year, int month)
        {
            InitializeComponent();
            _year = year;
            _month = month;
        }

        //データベース導入（Manage）クエリ追加
        private void Form2_Load(object sender, EventArgs e)
        {
            //範囲抽出
            
        }

        //部活動を変えるごとに該当情報を更新（ここにも更新用データベース導入）
        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //コンボボックスに登録した部活動を用いて部活IDを持ってくる
            //部活IDを基に、部活ごとのデータを持ってくる
        }

        //データ選択後別フォームに情報を持っていく
        private void dgvClubCost_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClubCost.CurrentRow == null) return;
            try
            {
                _PresentedDate = (DateTime)dgvClubCost.CurrentRow.Cells[1].Value;
                _UsedDate = (DateTime)dgvClubCost.CurrentRow.Cells[2].Value;
                //提出者名と費用名は外部キーで持ってくる
                _Presenter = Presenter_getName(dgvClubCost.CurrentRow.Cells[3].Value.ToString());
                _CostName = Cost_getName(dgvClubCost.CurrentRow.Cells[4].Value.ToString());
                _Money = int.Parse(dgvClubCost.CurrentRow.Cells[5].Value.ToString());
                _Summary = dgvClubCost.CurrentRow.Cells[6].Value.ToString();
                _Recipt = ByteArrayToImage((byte[])dgvClubCost.CurrentRow.Cells[7].Value);

            }
            catch (InvalidCastException) //変換できなかったときのエラー
            {
                _Recipt = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //データベース導入後コメント文解除+修正
        private string Presenter_getName(string pId)
        {
            #region
            //var pdata = infosys202107DataSet.Presenters.Where(x => x.Id == int.Parse(pId)).First();
            string p_Name = null;
            //if (pdata != null)
            //{
            //    p_Name = pdata.Name;
            //}
            return p_Name;
            #endregion
        }

        private string Cost_getName(string cId)
        {
            #region
            //var cdata = infosys202107DataSet.Cost.Where(x => x.Id == int.Parse(cId)).First();
            string c_Name = null;
            //if (cdata != null)
            //{
            //    c_Name = cdata.Name;
            //}
            return c_Name;
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

        //データグリッドビューエラー対応
        private void dgvClubCost_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
