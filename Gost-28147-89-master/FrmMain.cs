using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WinGost
{
    public partial class FrmMain : Form
    {
        byte[] encrByteFile, byteKey, decrByteFile;

        /// <summary>
        /// Постоянная "соль" для ключа
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик кнопки шифрования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileEncryptButton_Click(object sender, EventArgs e)
        {
            if(KeyTextBox.Text.Trim().Length < 32)
            {
                MessageBox.Show("Поле \"Ключ\" должно содержать 32 символа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (decrTextBox.Text.Trim().Length != 8)
            {
                MessageBox.Show("Текст шифруемого сообщения должен содержать 8 символов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            E32 e32;
            byteKey = CreateKey(KeyTextBox.Text);
            if (decrTextBox.Text == "")
                MessageBox.Show("Введите данные для шифрования.");
            else
            {
                byte[] btFile = Encoding.Default.GetBytes(decrTextBox.Text);

                if ((byteKey == null) || (byteKey.Length != 32))
                    MessageBox.Show("Введдите 256-битный ключ.");
                else
                {
                    e32 = new E32(btFile, byteKey);
                    encrByteFile = e32.GetEncryptFile;
                    encrTextBox.Text = Encoding.Default.GetString(encrByteFile);
                }
            }
        }

        /// <summary>
        /// Обработчик кнопки дешефрования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDecryptButton_Click(object sender, EventArgs e)
        {
            if (encrTextBox.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Поле для расшифровки пустое.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (encrTextBox.Text.Trim().Length != 8)
            {
                MessageBox.Show("Зашифрованное сообщение должно иметь длину 8 символов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            D32 d32;
            byteKey = CreateKey(KeyTextBox.Text);
            byte[] btFile = encrByteFile;
            if (byteKey.Length != 32)
            {
                MessageBox.Show("Введдите 256-битный ключ.");
            }
            else
            {
                d32 = new D32(btFile, byteKey);
                decrByteFile = d32.GetDecryptFile;
                encrTextBox.Text = Encoding.Default.GetString(decrByteFile);
            }
        }

        /// <summary>
        /// Создание 256 битного ключа
        /// </summary>
        /// <param name="password"></param>
        /// <param name="keyBytes"></param>
        /// <returns></returns>
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTextBox.Text.Trim().Length > 32)
            {
                KeyTextBox.Text = KeyTextBox.Text.Substring(0, 32);
            }
        }
    }
}
