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
    public partial class Form3 : Form
    {
        private DateTime _PresentedDate;
        private DateTime _UsedDate;
        private string _Presenter;
        private string _CostName;
        private int _Money;
        private string _Summary;
        private string _Confirmation; //備考
        private string _Remarks; //確認欄
        private Image _Recipt;

        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");
        

        //部費報告書の画面でデータをクリックしたらそのデータの詳細をもらい表示
        //データを更新して元フォームに更新したデータを返したい
        //部活IDが必要か確認
        public Form3(DateTime Pdate,DateTime Udate,string Presenter,string CostName,int Money,string Summary,Image Recipt)
        {
            InitializeComponent();
            _PresentedDate = Pdate;
            _UsedDate = Udate;
            _Presenter = Presenter;
            _CostName = CostName;
            _Money = Money;
            _Summary = Summary;
            _Recipt = Recipt;

            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            lbPDate.Text = _PresentedDate.ToString("gg y年 M月 d日",ci);
            lbUsedDate.Text = _UsedDate.ToString("gg y年 M月 d日", ci);

        }

        private void btApproval_Click(object sender, EventArgs e)
        {

        }
    }
}
