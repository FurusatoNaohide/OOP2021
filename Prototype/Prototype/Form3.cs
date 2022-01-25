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
        public DateTime PresentedDate { get; set; }
        public DateTime UsedDate { get; set; }
        public string Presenter { get; set; }
        public string CostName { get; set; }
        public double Money { get; set; }
        public string Summary { get; set; }
        public Image Recipt { get; set; }
        public string Confimation { get; set; }
        public string Remarks { get; set; }

        private DateTime _PresentedDate;
        private DateTime _UsedDate;
        private string _Presenter;
        private string _CostName;
        private double _Money;
        private string _Summary;
        private string _Confirmation; //備考
        private string _Remarks; //確認欄
        private Image _Recipt;

        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");

        string confirmation;

        //部費報告書の画面でデータをクリックしたらそのデータの詳細をもらい表示
        //データを更新して元フォームに更新したデータを返したい
        //部活IDが必要か確認
#if false
        //public Form3(DateTime Pdate,DateTime Udate,string Presenter,string CostName,double Money,string Summary,Image Recipt)
        //{
        //    InitializeComponent();
        //    _PresentedDate = Pdate;
        //    _UsedDate = Udate;
        //    _Presenter = Presenter;
        //    _CostName = CostName;
        //    _Money = Money;
        //    _Summary = Summary;
        //    _Recipt = Recipt;

        //    ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
        //    lbPDate.Text = _PresentedDate.ToString("gg y年 M月 d日",ci);
        //    lbUsedDate.Text = _UsedDate.ToString("gg y年 M月 d日", ci);
        //    lbName.Text = _Presenter;
        //    lbCost.Text = _CostName;
        //    lbSummary.Text = _Summary;
        //    lbMoney.Text = _Money.ToString("#,##0");
        //    pbReceipt.Image = _Recipt;
        //}
#endif
        public Form3()
        {
            InitializeComponent();
        }

        private void btApproval_Click(object sender, EventArgs e)
        {
            confirmation = "承";
            change_decision();
        }

        private void change_decision()
        {
            PresentedDate = this.PresentedDate;
            UsedDate = this.UsedDate;
            Presenter = this.Presenter;
            CostName = this.CostName;
            Money = this.Money;
            Summary = this.Summary;
            Recipt = this.Recipt;
            Confimation = this.confirmation;
            Remarks = this.tbRemarks.Text;

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            this.lbPDate.Text = PresentedDate.ToString("gg y年 M月 d日", ci);
            this.lbUsedDate.Text = UsedDate.ToString("gg y年 M月 d日", ci);
            this.lbName.Text = Presenter;
            this.lbCost.Text = CostName;
            this.lbSummary.Text = Summary;
            this.lbMoney.Text = Money.ToString("#,##0");
            this.pbReceipt.Image = Recipt;
        }
    }
}
