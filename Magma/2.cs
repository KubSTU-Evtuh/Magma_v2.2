using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Magma
{
    public partial class TranslatingValuesForm : Form
    {
        private int demoCount = 0;

        public TranslatingValuesForm()
        {
            InitializeComponent();
            MessageTextBox.Text = Regex.Replace(MessageTextBox.Text, "\\?{3}", InputData.GetInstance().Message);
        }

        private void L0R0TextBox_TextChanged(object sender, EventArgs e)
        {
            if(L0R0TextBox.Text.Length > 64)
            {
                L0R0TextBox.Text = L0R0TextBox.Text.Substring(0,64);
            }
        }

        private void L0TextBox_TextChanged(object sender, EventArgs e)
        {
            if (L0TextBox.Text.Length > 32)
            {
                L0TextBox.Text = L0TextBox.Text.Substring(0, 32);
            }
        }

        private void R0TextBox_TextChanged(object sender, EventArgs e)
        {
            if (R0TextBox.Text.Length > 32)
            {
                R0TextBox.Text = R0TextBox.Text.Substring(0, 32);
            }
        }

        private void DemonstrationButton_Click(object sender, EventArgs e)
        {
            if (demoCount < 4)
            {
                string byteCode = ByteConverter.GetByteCode(InputData.GetInstance().Message[demoCount]);
                L0TextBox.Text = Regex.Replace(L0TextBox.Text, " ", "") + byteCode;
                L0R0TextBox.Text = L0TextBox.Text;
                SelectByteCodeOfLetter(richTextBox1.Text, Color.Black);
                SelectByteCodeOfLetter(byteCode, Color.Red);
                SelectByteCodeOfLetterInMessageTextBox(demoCount);
                LetterHighlightTextBox.Text = InputData.GetInstance().Message[demoCount].ToString();
                demoCount++;
            }
            else
            {
                MessageBox.Show("Дозаполнение поля L0R0 производится самостоятельно.\n" +
                    "Заполнение поля R0 производится так же самостоятельно.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SelectByteCodeOfLetter(string byteCode, Color highlight)
        {
            if (!Regex.Match(LetterHighlightTextBox.Text, @"[а-яА-Я]").Success)
            {
                return;
            }
            if (byteCode == null)
                return;
            int posStart = richTextBox1.SelectionStart; // сохраняем позицию курсора
            int i = 0;
            while (i <= richTextBox1.Text.Length - byteCode.Length)
            {
                i = richTextBox1.Text.IndexOf(byteCode, i);
                if (i < 0) break;
                richTextBox1.Select(i, byteCode.Length); //выделяем слово
                richTextBox1.SelectionColor = highlight; //меняем цвет выделенному слову
                i += byteCode.Length;
                richTextBox1.SelectionStart = posStart; // курсор в начальное положение
                richTextBox1.SelectionColor = Color.Black;
            }
        }

        private void SelectByteCodeOfLetterInMessageTextBox(int index)
        {
            int start = 2 + MessageTextBox.Text.IndexOf(": ");
            MessageTextBox.SelectionStart = start + index;
            MessageTextBox.SelectionLength = 1;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (Regex.Replace(L0R0TextBox.Text, " ", "").Length != 64 ||
                Regex.Replace(L0TextBox.Text, " ", "").Length != 32 ||
                Regex.Replace(R0TextBox.Text, " ", "").Length != 32)
            {
                MessageBox.Show("Вы не заполнили все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                InputData.GetInstance().UserAnswers.L0R0 = L0R0TextBox.Text;
                InputData.GetInstance().UserAnswers.L0 = L0TextBox.Text;
                InputData.GetInstance().UserAnswers.R0 = R0TextBox.Text;
                new TranslatingKeyForm().Show();
                this.Close();
            }
        }

        private void LetterHighlightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LetterHighlightTextBox.Text.Length > 1)
                LetterHighlightTextBox.Text = LetterHighlightTextBox.Text.Substring(0, 1);
            ByteCodeLabel.Text = ByteConverter.GetByteCode(LetterHighlightTextBox.Text);
            SelectByteCodeOfLetter(richTextBox1.Text, Color.Black);
            SelectByteCodeOfLetter(ByteConverter.GetByteCode(LetterHighlightTextBox.Text), Color.Red);
        }
    }
}
