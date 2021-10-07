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
using System.Xml;
using System.Runtime.Serialization;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();
        public string FileName = "mailsettings.xml";

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
            try
            {
                SettingRegist();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //送信データ登録
        private void SettingRegist()
        {
            
            
        }
        //適用ボタン
        private void btApply_Click(object sender, EventArgs e)
        {
            try
            {
                SettingRegist();//送信データ登録
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;//ホスト名
            tbPort.Text = settings.Port.ToString();//ポート番号
            tbUserName.Text = settings.MailAddr;//ユーザー名
            tbPass.Text = settings.Pass;//パスワード
            cbSsl.Checked = settings.Ssl;//SSL
            tbSender.Text = settings.MailAddr;//送信元
        }
    }
}
