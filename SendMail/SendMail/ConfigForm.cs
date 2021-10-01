using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost();//ホスト名
            tbPort.Text = settings.sPort();//ポート番号
            tbUserName.Text = settings.sMailAddr();//ユーザー名
            tbPass.Text = settings.sPass();//パスワード
            cbSsl.Checked = settings.bSsl();//SSL
            tbSender.Text = settings.sMailAddr();//送信元
        }
        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            this.Close();
        }
        //送信データ登録
        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            /*
            //保存先のファイル名
            string fileName = @"C:\Users\infosys\Desktop\Example\xml\set.xml";


            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            //書き込むファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));
            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, settings);
            //ファイルを閉じる
            sw.Close();
            */
        }
        //適用ボタン
        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();//送信データ登録
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
