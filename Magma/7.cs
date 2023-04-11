using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Magma
{
    public partial class XORForm : Form
    {
        private int demoCount = 0;
        private string n0XORl0;

        public XORForm()
        {
            InitializeComponent();
            L0TextBox.Text = ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(0, 4));
            N0ShiftedTextBox.Text = InputData.GetN0Shifted();
            n0XORl0 = InputData.GetN0XORL0();
        }

        private void XORResultTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (XORResultTextBox.Text.Trim().Length > 32)
            {
                XORResultTextBox.Text = XORResultTextBox.Text.Substring(0, 32);
            }
        }

        private void DemonstrationButton_Click(object sender, System.EventArgs e)
        {
            if(demoCount < 24)
            {
                demoCount++;
                XORResultTextBox.Text = n0XORl0.Substring(0, demoCount);
            }
            else
            {
                MessageBox.Show("Дальнейшее заполнение поля проводится самостоятельно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NextStepButton_Click(object sender, System.EventArgs e)
        {
            if (XORResultTextBox.Text.Length != 32)
            {
                MessageBox.Show("Поле \"N0 - 11 XOR L0 =\" должно содержать ровно 32 символа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new CryptedMessageForm().Show();
                this.Close();
            }
        }
    }
}
