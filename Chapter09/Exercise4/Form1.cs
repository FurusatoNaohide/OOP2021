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

namespace Exercise4 {
    public partial class Form1 : Form {
        string selectDirectory = ""; //指定ディレクトリ
        string copyDirectory = "";//コピー先ディレクトリ

        public Form1() {
            InitializeComponent();
        }

        private void btChoiseDirectory_Click(object sender, EventArgs e) {
            if (fbdFindFolder.ShowDialog() == DialogResult.OK){
                selectDirectory = fbdFindFolder.SelectedPath;
            }
        }

        private void btCopyDirectory_Click(object sender, EventArgs e){
            if(fbdFindFolder.ShowDialog() == DialogResult.OK){
                copyDirectory = fbdFindFolder.SelectedPath;
            }
        }

        private void btCopyFile_Click(object sender, EventArgs e){
            var di = new DirectoryInfo(selectDirectory);
            
            var files = di.EnumerateFiles("*.txt", SearchOption.AllDirectories);
            foreach (var file in files){
                var fwe = Path.GetFileNameWithoutExtension(file.FullName);
                var extension = Path.GetExtension(file.Extension);
                File.Copy(file.FullName, copyDirectory + '\\' + fwe + "_bak" + extension, overwrite:true);
            }
        }
    }
}
