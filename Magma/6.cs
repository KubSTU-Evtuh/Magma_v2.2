using System;
using System.Windows.Forms;

namespace Magma
{
    public partial class CyclicShiftForm : Form
    {
        public CyclicShiftForm()
        {
            InitializeComponent();
            N0TextBox.Text = InputData.GetN0();
        }

        private void NewN0TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (NewN0TextBox.Text.Trim().Length > 32)
            {
                NewN0TextBox.Text = NewN0TextBox.Text.Substring(0, 32);
            }
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (NewN0TextBox.Text.Trim().Length != 32)
            {
                MessageBox.Show("Поле \"N0 - 11 =\" должно содержать ровно 32 символа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputData.GetInstance().UserAnswers.N0Shifted = NewN0TextBox.Text;
                new XORForm().Show();
                this.Close();
            }
        }
    }
}
