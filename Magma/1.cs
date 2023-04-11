using System;
using System.Windows.Forms;

namespace Magma
{
    public partial class InsertValuesForm : Form
    {
        public InsertValuesForm()
        {
            InitializeComponent();
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if(MessageTextBox.Text.Length > 8)
            {
                MessageTextBox.Text = MessageTextBox.Text.Substring(0, 8);
            }
            MessageLabel.Text = $"Количество символов в строке: {MessageTextBox.Text.Length}.";
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTextBox.Text.Length > 32)
            {
                KeyTextBox.Text = KeyTextBox.Text.Substring(0, 32);
            }
            KeyLabel.Text = $"Количество символов в строке: {KeyTextBox.Text.Length}.";
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Length < 8)
            {
                MessageBox.Show("Шифруемое сообщение должно содержать 8 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (KeyTextBox.Text.Length < 32)
            {
                MessageBox.Show("Ключ шифрования должен содержать 32 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InputData.SetInstance(new InputData.Data(MessageTextBox.Text, KeyTextBox.Text));
                new TranslatingValuesForm1().Show();
                this.Close();
            }
        }
    }
}
