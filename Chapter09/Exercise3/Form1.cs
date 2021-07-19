using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        string openfilePath = "";  //追加先ファイル(保存するファイル)
        string addfilePath = ""; //追加元ファイル

        public Form1() {
            InitializeComponent();
        }
        //保存先ファイルを指定
        private void btOpen_Click(object sender, EventArgs e) {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
                openfilePath = sfdSaveFile.FileName;
            }
        }
        //追加元ファイルを指定
        private void btAddFile_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                addfilePath = ofdOpenFile.FileName;
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            var lines = File.ReadLines(addfilePath, Encoding.UTF8).Select((s, ix) => string.Format("{0,4}: {1}", ix + 1, s)).ToArray();
            //File.WriteAllLines(openfilePath, lines);

            //追加元ファイル←追加先ファイル
            using (var writer = new StreamWriter(openfilePath, append: true)) {
                foreach (var line in lines) {
                    writer.WriteLine(line);
                }

            }
        }
    }
}
