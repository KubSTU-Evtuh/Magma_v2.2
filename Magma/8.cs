using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinGost;

namespace Magma
{
    public partial class CryptedMessageForm : Form
    {
        byte[] encrByteFile, byteKey;
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        public CryptedMessageForm()
        {
            InitializeComponent();
            FillMessageTextBox();
            FillCryptedMessageTextBox();
            FillKeyTextBox();

        }

        private void FillMessageTextBox()
        {
            MessageTextBox.Text = InputData.GetInstance().Message;
        }

        private void FillCryptedMessageTextBox()
        {
            byteKey = CreateKey(InputData.GetInstance().Key);
            E32 e32;
            byte[] btFile = Encoding.Default.GetBytes(InputData.GetInstance().Message);
            if ((byteKey == null) || (byteKey.Length != 32))
                MessageBox.Show("Введдите 256-битный ключ.");
            else
            {
                e32 = new E32(btFile, byteKey);
                encrByteFile = e32.GetEncryptFile;
                CryptedMessageTextBox.Text = Encoding.Default.GetString(encrByteFile);
            }
        }

        private void FillKeyTextBox()
        {
            KeyTextBox.Text = InputData.GetInstance().Key;
        }

        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            new TestResultsForm().Show();
            this.Close();
        }
    }
}
