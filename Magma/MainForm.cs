using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinGost;

namespace Magma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            new InsertValuesForm().Show();
        }

        private void CryptButton_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://vk.com/away.php?utf=1&to=https%3A%2F%2Fspy-soft.net%2Fmagma-encryption%2F");
        }

        private void VideoLessonButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.youtube.com/watch?v=x9je_XIZ5u4");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitButton_Click(sender, e);
        }
    }
}
