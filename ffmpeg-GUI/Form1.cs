using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffmpeg_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ffmpeg|ffmpeg.exe";
            ofd.ShowDialog();

            ffmpegPath.Text = '"' + ofd.FileName + '"';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "video|*.avi;*.mp4;*.mkv";
            ofd.ShowDialog();

            ocVideoPath.Text = '"' + ofd.FileName + '"';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
                dialog.Description = "保存先を指定してください";
                dialog.ShowNewFolderButton = true;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveVideoPath.Text = '"' + dialog.SelectedPath + '"';
                }
                else {
                    saveVideoPath.Text = "\"\"";
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
        }
    }
}
