using System;
using System.Windows.Forms;

namespace Magma
{
    public partial class PermutationTableForm1 : Form
    {
        public PermutationTableForm1()
        {
            InitializeComponent();
            A0K0ResultTextBox.Text = InputData.GetA0PlusK0();
        }

        private void BlockTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox blockTextBox = (sender as TextBox);
            if (blockTextBox.Text.Length > 4)
                blockTextBox.Text = blockTextBox.Text.Substring(0, 4);
        }

        private void DemonstrationButton_Click(object sender, EventArgs e)
        {
            if (OldBlockTextBox8.Text.Trim() == string.Empty || NewBlockTextBox8.Text.Trim() == string.Empty)
            {
                int blockNumber = 0;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox8.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox8.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox8.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox8.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox8.Text;
                    return;
                }
            }
            else if (OldBlockTextBox7.Text.Trim() == string.Empty || NewBlockTextBox7.Text.Trim() == string.Empty)
            {
                int blockNumber = 1;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox7.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox7.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox7.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox7.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox7.Text;
                    return;
                }
            }
            else if (OldBlockTextBox6.Text.Trim() == string.Empty || NewBlockTextBox6.Text.Trim() == string.Empty)
            {
                int blockNumber = 2;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox6.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox6.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox6.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox6.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox6.Text;
                    return;
                }
            }
            else if (OldBlockTextBox5.Text.Trim() == string.Empty || NewBlockTextBox5.Text.Trim() == string.Empty)
            {
                int blockNumber = 3;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox5.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox5.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox5.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox5.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox5.Text;
                    return;
                }
            }
            else if (OldBlockTextBox4.Text.Trim() == string.Empty || NewBlockTextBox4.Text.Trim() == string.Empty)
            {   
                int blockNumber = 4;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox4.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox4.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox4.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox4.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox4.Text;
                    return;
                }
            }
            else if (OldBlockTextBox3.Text.Trim() == string.Empty || NewBlockTextBox3.Text.Trim() == string.Empty)
            {
                int blockNumber = 5;
                HighlightBlock(blockNumber);
                if (OldBlockTextBox3.Text.Trim() == string.Empty)
                {
                    OldBlockTextBox3.Text = GetOldBlockValue(blockNumber);
                    return;
                }
                if (NewBlockTextBox3.Text.Trim() == string.Empty)
                {
                    NewBlockTextBox3.Text = GetNewBlockValue(blockNumber);
                    N0TextBox.Text += NewBlockTextBox3.Text;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Дальнейшее заполнение полей произведится самостоятельно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetOldBlockValue(int blockNumber)
        {
            return InputData.GetA0PlusK0().Substring(blockNumber * 4, 4);
        }

        private string GetNewBlockValue(int blockNumber)
        {
            string result = Convert.ToString(new PermutationTable().Permuate(Convert.ToInt32(InputData.GetA0PlusK0().Substring(blockNumber * 4, 4), 2), blockNumber), 2);
            return FormatBinaryString(result);
        }

        private string FormatBinaryString(string input)
        {
            switch (input.Length)
            {
                case 0:
                    return "0000" + input;
                case 1:
                    return "000" + input;
                case 2:
                    return "00" + input;
                case 3:
                    return "0" + input;
                default:
                    return input.Substring(0, 4);
            }
        }

        private void HighlightBlock(int blockNumber)
        {
            A0K0ResultTextBox.SelectionStart = 5 * blockNumber;
            A0K0ResultTextBox.SelectionLength = 4;
        }

        private void DecadeNumberNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BinaryNumberTextBox1.Text = FormatBinaryString(Convert.ToString(Convert.ToInt32(DecadeNumberNumericUpDown1.Value), 2));
        }

        private void BinaryNumberTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DecadeNumberTextBox2.Text = Convert.ToInt32(BinaryNumberTextBox2.Text, 2).ToString();
            }
            catch
            {
                DecadeNumberTextBox2.Text = "???";
            }
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (OldBlockTextBox8.Text.Length < 4 || NewBlockTextBox8.Text.Length < 4 ||
                OldBlockTextBox7.Text.Length < 4 || NewBlockTextBox7.Text.Length < 4 ||
                OldBlockTextBox6.Text.Length < 4 || NewBlockTextBox6.Text.Length < 4 ||
                OldBlockTextBox5.Text.Length < 4 || NewBlockTextBox5.Text.Length < 4 ||
                OldBlockTextBox4.Text.Length < 4 || NewBlockTextBox4.Text.Length < 4 ||
                OldBlockTextBox3.Text.Length < 4 || NewBlockTextBox3.Text.Length < 4 ||
                OldBlockTextBox2.Text.Length < 4 || NewBlockTextBox2.Text.Length < 4 ||
                OldBlockTextBox1.Text.Length < 4 || NewBlockTextBox1.Text.Length < 4)
            {
                MessageBox.Show("Не заполнены все блоки.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (N0TextBox.Text.Length != 32)
            {
                MessageBox.Show("Поле N0 должно содержать ровно 32 символа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new CyclicShiftForm().Show();
                this.Close();
            }
        }

        private void N0TextBox_TextChanged(object sender, EventArgs e)
        {
            if(N0TextBox.Text.Trim().Length > 32)
            {
                N0TextBox.Text = N0TextBox.Text.Substring(0, 32);
            }
        }
    }
}
