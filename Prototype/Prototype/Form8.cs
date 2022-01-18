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
    public partial class Form8 : Form
    {
        string nendo;
        int month;
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");
        

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //範囲指定
            selectedRange();
            //月毎決算ならデフォルトは今年度で1月～12月のどれかを指定　デフォルト値は年度初め月の4月
            //年度決算ならデフォルトは今年度で過去の年度もComboBoxで指定可能
            //年度は登録データから該当年度を持ってくる

            
            //foreach (var item in infosys202107DataSet.Manage)
            //{
            //    setCbYear(item.PDate);
            //}

            //初期値として現在の年度を代入
            var now = DateTime.Now;
            //nendo = now.AddMonths(-3).ToString("yyyy");
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            nendo = now.ToString("gg y年",ci);

        }

        //Manageにある提出日から年度を検出
        private void setCbYear(DateTime Pdate)
        {
            if (!cbYear.Items.Contains(Pdate.ToString("gg y年", ci)))
            {
                cbYear.Items.Add(Pdate.ToString("gg y年", ci));
            }
        }

        //月別か年度別かを指定
        private void selectedRange()
        {
            if (rbYear.Checked)
            {
                cbYear.Enabled = true;
                gbMonth.Enabled = false;
            }
            else
            {
                cbYear.Enabled = false;
                gbMonth.Enabled = true;
            }
        }

        //指定した範囲の情報を部費報告書に渡す
        private void btOk_Click(object sender, EventArgs e)
        {
            if (rbYear.Checked)
            {
                this.Hide();
                //Form2 form2 = new Form2(cbYear.Text);
            }
            else
            {
                
                this.Hide();
                
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            selectedRange();
        }

        //これだと四月空の変更しか反映されていないので何処からでも反映できるメソッドを探す（改良必要）
        private void rbApril_CheckedChanged(object sender, EventArgs e)
        {
            //指定したグループ内のラジオボタンでチェックされているものを取り出す
            var rb_select = gbMonth.Controls.OfType<RadioButton>().SingleOrDefault(x => x.Checked);
            month = int.Parse(rb_select.Text.Replace("月", ""));
        }
    }
}
