using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ 先に呼ばれる
        public Form1() {
            InitializeComponent();
        }

        //フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            //問題5.4
            inputStrData.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        //空白の個数
        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            TextBoxSpaceCount.Text = count.ToString();
        }

        //特定の文字列の置き換え
        private void Button5_3_2_Click(object sender, EventArgs e) {
            var replaced = inputStrText.Text.Replace("big", "small");
            TextBoxWordChange.Text = replaced;
        }

        //単語の数 Split()で分けた配列の個数をカウント
        private void Button5_3_3_Click(object sender, EventArgs e) {
            var counts = inputStrText.Text.Split(' ').Count();
            TextBoxWordCount.Text = counts.ToString();
        }

        //4文字以下の単語をつなげて表示
        private void Button5_3_4_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) {
                TextBoxWordCount4.Text += word + ' ';
            };
        }

        //空白で区切り、配列格納した後、再度文字列連結(StringBuilderクラス)
        private void Button5_3_5_Click(object sender, EventArgs e) {
            /*var sb = new StringBuilder();
            var words = inputStrText.Text.Split(' ').ToArray();
            foreach (var word in words) {
                sb.Append(word + ' ');
            }
            TextBoxReWord.Text = sb.ToString();*/

            //余分な空白を入れないように
            var array = inputStrText.Text.Split(' ').ToArray();
            if(array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                TextBoxReWord.Text = sb.ToString();
            }
        }

        //指定した特定の文字列を指定した別の文字列に置き換え
        private void Button5_3_6_Click(object sender, EventArgs e) {
            TextBoxWordChange2.Text = inputStrText.Text.Replace(TextBoxBeforWord.Text, TextBoxAfterWord.Text);
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //Novelist=谷崎潤一郎
            //BestWork=春琴抄
            //Born=1886
            foreach (var pair in inputStrData.Text.Split(';')) {
                //pairに入っているデータを'='で分割 例:array[0]="Novelist" array[1]="谷崎潤一郎"
                var array = pair.Split('=');
                outputStrData.Text += ToJapanese(array[0]) + ":" + array[1] + Environment.NewLine;//改行 別記入例:"\r\n"(C#),"\n"(C)
            }
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
