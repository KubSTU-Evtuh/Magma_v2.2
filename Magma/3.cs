using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Magma
{
    public partial class TranslatingKeyForm : Form
    {
        private readonly string key;
        private string k0 = string.Empty;
        private string k1 = string.Empty;
        private string k2 = string.Empty;
        private string k3 = string.Empty;
        private string k4 = string.Empty;
        private string k5 = string.Empty;

        public TranslatingKeyForm()
        {
            InitializeComponent();
            key = InputData.GetInstance().Key;
            KeyTextBox.Text = Regex.Replace(KeyTextBox.Text, "\\?{3}", key);
        }

        private void DemonstrationButton_Click(object sender, EventArgs e)
        {
            #region K0
            if (K0TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K0TextBox.Text.Trim().Length < 8)
                {
                    k0 = ByteConverter.GetByteCode(key.Substring(0, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[0]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(0);
                    LetterHighlightTextBox.Text = key[0].ToString();
                }
                else if (K0TextBox.Text.Trim().Length < 16)
                {
                    k0 = ByteConverter.GetByteCode(key.Substring(0, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[1]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(1);
                    LetterHighlightTextBox.Text = key[1].ToString();
                }
                else if (K0TextBox.Text.Trim().Length < 24)
                {
                    k0 = ByteConverter.GetByteCode(key.Substring(0, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[2]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(2);
                    LetterHighlightTextBox.Text = key[2].ToString();
                }
                else
                {
                    k0 = ByteConverter.GetByteCode(key.Substring(0, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[3]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(3);
                    LetterHighlightTextBox.Text = key[3].ToString();
                }
                K0TextBox.Text = k0;
            }
            #endregion
            #region K1
            else if (K1TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K1TextBox.Text.Trim().Length < 8)
                {
                    k1 = ByteConverter.GetByteCode(key.Substring(4, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[4]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(4);
                    LetterHighlightTextBox.Text = key[4].ToString();
                }
                else if (K1TextBox.Text.Trim().Length < 16)
                {
                    k1 = ByteConverter.GetByteCode(key.Substring(4, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[5]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(5);
                    LetterHighlightTextBox.Text = key[5].ToString();
                }
                else if (K1TextBox.Text.Trim().Length < 24)
                {
                    k1 = ByteConverter.GetByteCode(key.Substring(4, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[6]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(6);
                    LetterHighlightTextBox.Text = key[6].ToString();
                }
                else
                {
                    k1 = ByteConverter.GetByteCode(key.Substring(4, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[7]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(7);
                    LetterHighlightTextBox.Text = key[7].ToString();
                }
                K1TextBox.Text = k1;
            }
            #endregion
            #region K2
            else if (K2TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K2TextBox.Text.Trim().Length < 8)
                {
                    k2 = ByteConverter.GetByteCode(key.Substring(8, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[8]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(8);
                    LetterHighlightTextBox.Text = key[8].ToString();
                }
                else if (K2TextBox.Text.Trim().Length < 16)
                {
                    k2 = ByteConverter.GetByteCode(key.Substring(8, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[9]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(9);
                    LetterHighlightTextBox.Text = key[9].ToString();
                }
                else if (K2TextBox.Text.Trim().Length < 24)
                {
                    k2 = ByteConverter.GetByteCode(key.Substring(8, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[10]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(10);
                    LetterHighlightTextBox.Text = key[10].ToString();
                }
                else
                {
                    k2 = ByteConverter.GetByteCode(key.Substring(8, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[11]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(11);
                    LetterHighlightTextBox.Text = key[11].ToString();
                }
                K2TextBox.Text = k2;
            }
            #endregion
            #region K3
            else if (K3TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K3TextBox.Text.Trim().Length < 8)
                {
                    k3 = ByteConverter.GetByteCode(key.Substring(12, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[12]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(12);
                    LetterHighlightTextBox.Text = key[12].ToString();
                }
                else if (K3TextBox.Text.Trim().Length < 16)
                {
                    k3 = ByteConverter.GetByteCode(key.Substring(12, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[13]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(13);
                    LetterHighlightTextBox.Text = key[13].ToString();
                }
                else if (K3TextBox.Text.Trim().Length < 24)
                {
                    k3 = ByteConverter.GetByteCode(key.Substring(12, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[14]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(14);
                    LetterHighlightTextBox.Text = key[14].ToString();
                }
                else
                {
                    k3 = ByteConverter.GetByteCode(key.Substring(12, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[15]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(15);
                    LetterHighlightTextBox.Text = key[15].ToString();
                }
                K3TextBox.Text = k3;
            }
            #endregion
            #region K4
            else if (K4TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K4TextBox.Text.Trim().Length < 8)
                {
                    k4 = ByteConverter.GetByteCode(key.Substring(16, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[16]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(16);
                    LetterHighlightTextBox.Text = key[16].ToString();
                }
                else if (K4TextBox.Text.Trim().Length < 16)
                {
                    k4 = ByteConverter.GetByteCode(key.Substring(16, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[17]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(17);
                    LetterHighlightTextBox.Text = key[17].ToString();
                }
                else if (K4TextBox.Text.Trim().Length < 24)
                {
                    k4 = ByteConverter.GetByteCode(key.Substring(16, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[18]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(18);
                    LetterHighlightTextBox.Text = key[18].ToString();
                }
                else
                {
                    k4 = ByteConverter.GetByteCode(key.Substring(16, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[19]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(19);
                    LetterHighlightTextBox.Text = key[19].ToString();
                }
                K4TextBox.Text = k4;
            }
            #endregion
            #region K5
            else if (K5TextBox.Text.Trim().Length < 32)
            {
                SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
                if (K5TextBox.Text.Trim().Length < 8)
                {
                    k5 = ByteConverter.GetByteCode(key.Substring(20, 1));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[20]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(20);
                    LetterHighlightTextBox.Text = key[20].ToString();
                }
                else if (K5TextBox.Text.Trim().Length < 16)
                {
                    k5 = ByteConverter.GetByteCode(key.Substring(20, 2));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[21]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(21);
                    LetterHighlightTextBox.Text = key[21].ToString();
                }
                else if (K5TextBox.Text.Trim().Length < 24)
                {
                    k5 = ByteConverter.GetByteCode(key.Substring(20, 3));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[22]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(22);
                    LetterHighlightTextBox.Text = key[22].ToString();
                }
                else
                {
                    k5 = ByteConverter.GetByteCode(key.Substring(20, 4));
                    SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(key[23]), Color.Red);
                    SelectByteCodeOfLetterInKeyTextBox(23);
                    LetterHighlightTextBox.Text = key[23].ToString();
                }
                K5TextBox.Text = k5;
            }
            #endregion
            else
            {
                MessageBox.Show("Поля K6 и K7 вводятся пользователем вручную.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectByteCodeOfLetterInRTB(string byteCode, Color highlight)
        {
            if (!Regex.Match(LetterHighlightTextBox.Text, @"[а-яА-Я]").Success)
            {
                return;
            }
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

        private void SelectByteCodeOfLetterInKeyTextBox(int index)
        {
            int start = 2 + KeyTextBox.Text.IndexOf(": ");
            KeyTextBox.SelectionStart = start + index;
            KeyTextBox.SelectionLength = 1;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (K0TextBox.Text.Trim().Equals(string.Empty) ||
                K1TextBox.Text.Trim().Equals(string.Empty) ||
                K2TextBox.Text.Trim().Equals(string.Empty) ||
                K3TextBox.Text.Trim().Equals(string.Empty) ||
                K4TextBox.Text.Trim().Equals(string.Empty) ||
                K5TextBox.Text.Trim().Equals(string.Empty) ||
                K6TextBox.Text.Trim().Equals(string.Empty) ||
                K7TextBox.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Не заполнены все поля K[i].", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputData.GetInstance().UserAnswers.K0 = K0TextBox.Text;
                InputData.GetInstance().UserAnswers.K1 = K1TextBox.Text;
                InputData.GetInstance().UserAnswers.K2 = K2TextBox.Text;
                InputData.GetInstance().UserAnswers.K3 = K3TextBox.Text;
                InputData.GetInstance().UserAnswers.K4 = K4TextBox.Text;
                InputData.GetInstance().UserAnswers.K5 = K5TextBox.Text;
                InputData.GetInstance().UserAnswers.K6 = K6TextBox.Text;
                InputData.GetInstance().UserAnswers.K7 = K7TextBox.Text;
                new BitwiseAdditionFirstRoundForm().Show();
                this.Close();
            }
        }

        private void LetterHighlightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LetterHighlightTextBox.Text.Length > 1)
                LetterHighlightTextBox.Text = LetterHighlightTextBox.Text.Substring(0, 1);
            ByteCodeLabel.Text = ByteConverter.GetByteCode(LetterHighlightTextBox.Text);
            SelectByteCodeOfLetterInRTB(richTextBox1.Text, Color.Black);
            SelectByteCodeOfLetterInRTB(ByteConverter.GetByteCode(LetterHighlightTextBox.Text), Color.Red);
        }
    }
}
