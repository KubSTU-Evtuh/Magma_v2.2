using System;
using System.Windows.Forms;

namespace Magma
{
    public partial class BitwiseAdditionFirstRoundForm : Form
    {
        private int demoCount = 0;
        private string result = string.Empty;

        public BitwiseAdditionFirstRoundForm()
        {
            InitializeComponent();
            FillA0();
            FillK0();
            result = InputData.GetA0PlusK0();
        }

        private void FillA0()
        {
            A0TextBox.Text = ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(4, 4));
        }

        private void FillK0()
        {
            K0TextBox.Text = ByteConverter.GetByteCode(InputData.GetInstance().Key.Substring(0, 4));
        }

        private void DemonstrationButton_Click(object sender, EventArgs e)
        {
            demoCount++;
            if (demoCount <= 24)
            {
                A0K0TextBox.Text = ShowA0K0();
                SelectTextInTextBox(A0TextBox);
                SelectTextInTextBox(K0TextBox);
            }
        }

        private string ShowA0K0()
        {
            string outStr = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                if (i < 32 - demoCount)
                    outStr += " ";
                else
                    outStr += this.result[i];
            }
            return outStr;
        }

        private void SelectTextInTextBox(TextBox textBox)
        {
            textBox.SelectionStart = 35 - (demoCount + (demoCount - 1) / 8);
            textBox.SelectionLength = 1;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private void A0K0TextBox_TextChanged(object sender, EventArgs e)
        {
            if (A0K0TextBox.Text.Length > 32)
            {
                MessageBox.Show("Поле A0K0 должно содержать 32 символа (операция сложения производится по mod 2^32).", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                A0K0TextBox.Text = A0K0TextBox.Text.Substring(0, 32);
            }
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (A0K0TextBox.Text.Trim().Length != 32)
            {
                MessageBox.Show("Поле A0K0 должно содержать 32 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new PermutationTableForm1().Show();
                this.Close();
            }
        }
    }
}
