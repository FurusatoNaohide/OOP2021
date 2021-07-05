using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var day = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            var today = DateTime.Today;
            DayOfWeek dayOfWeek = day.DayOfWeek;


#if false   //曜日
            string dow = "";
            

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }
            tbOutput.Text = dow + "です";
#endif
#if false //今日 - 指定した日付
            TimeSpan diff = today.Date - day.Date;
            tbOutput.Text = diff.Days + "日前";
#endif
            //年齢を求める
            tbOutput.Text = GetAge(dtpDateTime.Value, today).ToString() + "歳";


            //閏年判定
            var isLeapYear = DateTime.IsLeapYear(day.Year);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            } else {
                tbLeapYear.Text = "閏年ではありません";
            }

            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }

        //年齢を求めるメソッド
        public int GetAge(DateTime birthday, DateTime targetday) {
            var age = targetday.Year - birthday.Year;
            if(targetday < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
