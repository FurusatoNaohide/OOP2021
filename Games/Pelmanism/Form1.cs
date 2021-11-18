using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism
{
    public partial class FormGame : Form
    {
        private Card[] playingCards;    //遊ぶカードの束
        private Player player;          //プレイヤー
        private int gameSec;            //ゲーム時間

        public FormGame()
        {
            InitializeComponent();
        }

        //カードの生成
        //(仮引数)cards:カードの配列への参照
        private void CreateCards(ref Card[] cards)
        {
            string[] picture =
            {
                "〇","●","△","▲","□","■","◇","◆","☆","★","※","×",
            };
            //カードのインスタンスの生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                //同じ柄のカードを二枚作る
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }

        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //カードの生成
            CreateCards(ref playingCards);
            //プレイヤーの生成
            player = new Player();

            //カードをフォームに動的に配置する
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;
            for (int i = 0; i < playingCards.Length; i++)
            {
                //カード（ボタン）のプロパティを設定する
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                //offsetX カード一枚分の幅 offsetY カード一枚分の高さ
                //i % 8 * sizeW 一列分の配置、幅　i / 8 * sizeH　行ごとの高さ
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW,
                                                        offsetY + i / 8 * sizeH);
                playingCards[i].Click += CardsButtons_Click;
            }

            //カード（ボタン）の配置
            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください。";

        }

        private void CardsButtons_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
