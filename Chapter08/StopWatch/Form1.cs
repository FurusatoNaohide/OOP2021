using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e) {
            tmDisp.Tick += Tm_Tick;
            tmDisp.Interval = 10;
            tmDisp.Start();
            sw.Start();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Tm_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //lbTimerDisp.Text = "00:00:00.00";//この記述でもOK
        }

        private void btstop_Click(object sender, EventArgs e) {
            tmDisp.Stop();
            sw.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Restart();
            lbTimerDisp.Text = "00:00:00.00";
        }
    }
}
