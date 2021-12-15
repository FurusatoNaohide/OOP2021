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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //データベースを参照して部活IDとパスワードの組み合わせが合致したらログイン完了
#if false //学校サーバー
            try
            {
                var data = this.clubTableAdapter.FillByClub(this.infosys202107DataSet.Club, int.Parse(tbClubID.Text), tbPassWord.Text);
                int clubId = -1;
                if (data == 1)
                {
                    //部活の主キー番号を記憶させて別フォームに持っていきたい
                    foreach (var club in this.infosys202107DataSet.Club)
                    {
                        if (club.Club_No == int.Parse(tbClubID.Text))
                        {
                            clubId = club.Id;
                        }
                    }
                    if (clubId != -1)
                    {
                        this.Hide();
                        Registration registration = new Registration(clubId);
                        registration.ShowDialog();
                    }

                }
                else
                {
                    tbClubID.Text = null;
                    tbPassWord.Text = null;
                    MessageBox.Show("部活IDとパスワードが一致しませんでした。");
                }
            }
            catch (FormatException fx)
            {
                MessageBox.Show(fx.Message);
            }
#endif
#if true
            try
            {
                var data = this.clubsTableAdapter.FillByClub(this.sampleManageDataSet1.Clubs, tbClubID.Text, tbPassWord.Text);
                //clubsテーブルのIdを入れる引数
                int clubsId = -1;
                if (data == 1)
                {
                    foreach (var club in this.sampleManageDataSet1.Clubs)
                    {
                        if (club.Club_Id == tbClubID.Text)
                        {
                            clubsId = club.No;
                        }
                    }
                    if (clubsId != -1)
                    {
                        this.Hide();
                        Registration registration = new Registration(clubsId);
                        registration.ShowDialog();
                    }
                }
                else
                {
                    tbClubID.Text = null;
                    tbPassWord.Text = null;
                    MessageBox.Show("部活IDとパスワードが一致しませんでした。");
                }
            }
            catch (FormatException fx)
            {
                MessageBox.Show(fx.Message);
            }
#endif
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
#if false //学校サーバー
            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);
#endif
#if true
            this.Validate();
            this.clubsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sampleManageDataSet1);
#endif
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //自宅用
            // TODO: このコード行はデータを 'sampleManageDataSet1.Clubs' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubsTableAdapter.Fill(this.sampleManageDataSet1.Clubs);

            //学校サーバー
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);

        }
    }
}
